using RestSharp;
using Ritossa.DevOpsArtifactsCleaner.ApiClient;
using Ritossa.DevOpsArtifactsCleaner.ApiClient.Params;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;
using Ritossa.DevOpsArtifactsCleaner.Services.Converters;

namespace Ritossa.DevOpsArtifactsCleaner.Services
{
    internal class DevOpsService : IDevOpsService
    {
        private readonly DevOpsArtifactsApiClient _devOpsArtifactsApiClient = DevOpsArtifactsApiClient.GetInstance();

        public bool TestConnection(UserSettingsModel userSettings, IProgress<string> progress)
        {
            if (userSettings is null) throw new ArgumentNullException(nameof(userSettings));

            var parameters = new BaseParams
            {
                Pat = userSettings.Pat,
                Organization = userSettings.Organization,
                Project = userSettings.Project,
                FeedId = userSettings.FeedId
            };

            progress.Report("Testing connection...");

            var response = _devOpsArtifactsApiClient.TestConnection(parameters);

            if (Exit_WhenError(response, progress))
                return false;

            progress.Report("Connection successful");
            return true;
        }

        public async Task<List<PackageModel>> GetAllPackagesAsync(UserSettingsModel settings, IProgress<string> progress)
        {
            var parameters = new GetAllPackagesParams
            {
                Pat = settings.Pat,
                Organization = settings.Organization,
                Project = settings.Project,
                FeedId = settings.FeedId,
                ProtocolType = settings.ProtocolType,
                IncludeAllVersions = settings.IncludeAllVersions
            };

            progress.Report("Getting packages...");

            var response = await _devOpsArtifactsApiClient.GetAllPackagesAsync(parameters).ConfigureAwait(false);

            if (Exit_WhenError(response, progress)) return new();

            if (response.Data.Count == 0)
            {
                progress.Report("No packages found");
                return new List<PackageModel>();
            }

            response.Data.Value = response.Data.Value.OrderBy(_ => _.Name).ToList();

            response.Data.Value.ForEach(_ =>
                _.Versions = _.Versions
                    .OrderByDescending(v => v.IsLatest)
                    .ThenByDescending(v => v.Version)
                    .ToList());

            progress.Report($"{response.Data.Count} packages found");

            return response.Data.Value.ToModel();
        }

        public async Task<bool> UnlistVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toUnlist, IProgress<string> progress)
        {
            var parameters = new UnlistNugetPackageVersionParams
            {
                Pat = settings.Pat,
                Organization = settings.Organization,
                Project = settings.Project,
                FeedId = settings.FeedId,
                Packages = toUnlist.ConvertAll(_ => new UnlistNugetPackageVersionParams.Package { IdOrName = _.Name, Version = _.Version })
            };

            progress.Report("Unlisting selected versions...");

            var response = await _devOpsArtifactsApiClient.UnlistNugetPackageVersionAsync(parameters).ConfigureAwait(false);

            if (Exit_WhenError(response, progress))
                return false;

            progress.Report($"{toUnlist.Count} versions unlisted");
            return true;
        }

        public async Task<bool> RelistVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toRelist, IProgress<string> progress)
        {
            var parameters = new RelistNugetPackageVersionParams
            {
                Pat = settings.Pat,
                Organization = settings.Organization,
                Project = settings.Project,
                FeedId = settings.FeedId,
                Packages = toRelist.ConvertAll(_ => new RelistNugetPackageVersionParams.Package { IdOrName = _.Name, Version = _.Version })
            };

            progress.Report("Relisting selected versions...");
            var response = await _devOpsArtifactsApiClient.RelistNugetPackageVersionAsync(parameters).ConfigureAwait(false);

            if (Exit_WhenError(response, progress))
                return false;

            progress.Report($"{toRelist.Count} versions relisted");

            return true;
        }


        public async Task<bool> DeletePackageVersionsAsync(UserSettingsModel settings, List<PackageVersionModel> toDelete, IProgress<string> progress)
        {
            var parameters = new DeleteNugetPackageVersionParams
            {
                Pat = settings.Pat,
                Organization = settings.Organization,
                Project = settings.Project,
                FeedId = settings.FeedId,
                Packages = toDelete.ConvertAll(_ => new DeleteNugetPackageVersionParams.Package { IdOrName = _.Name, Version = _.Version })
            };

            progress.Report("Deleting selected versions...");

            var response = await _devOpsArtifactsApiClient.DeleteNugetPackageVersionAsync(parameters).ConfigureAwait(false);

            if (Exit_WhenError(response, progress))
                return false;

            progress.Report($"{toDelete.Count} versions deleted");
            return true;
        }

        public List<PackageVersionModel> GetAllPackageVersions(List<PackageModel> source)
        {
            var result = new List<PackageVersionModel>();

            foreach (var package in source)
            {
                foreach (var version in package.Versions)
                {
                    result.Add(new PackageVersionModel
                    {
                        PackageId = package.Id,
                        Name = package.Name,
                        ProtocolType = package.ProtocolType,
                        VersionId = version.Id,
                        Version = version.Version,
                        IsLatest = version.IsLatest,
                        IsListed = version.IsListed,
                        StorageId = version.StorageId,
                        PublishDate = version.PublishDate
                    });
                }
            }

            return result.OrderByDescending(_ => _.Version).ThenBy(_ => _.Name).ToList();
        }

        private bool Exit_WhenError(RestResponseBase response, IProgress<string> progress)
        {
            if (response.IsSuccessful)
            {
                if (response.ContentType != null && !response.ContentType.Contains("application/json"))
                {
                    progress.Report($"Unexpected response with content type [{response.ContentType}] and status code [{response.StatusCode}]");
                    return true;
                }

                return false;

            }

            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.Unauthorized:
                    progress.Report("Unauthorized. Please check your PAT and permissions");
                    break;
                case System.Net.HttpStatusCode.NotFound:
                    progress.Report("Organization, Project or Feed not found");
                    break;
                case System.Net.HttpStatusCode.Forbidden:
                    progress.Report("Forbidden. Please check your permissions");
                    break;
                case System.Net.HttpStatusCode.BadRequest:
                    progress.Report("Bad Request. Please check your parameters");
                    break;
                case System.Net.HttpStatusCode.InternalServerError:
                    progress.Report("Internal Server Error. Please try again later");
                    break;
                case System.Net.HttpStatusCode.ServiceUnavailable:
                    progress.Report("Service Unavailable. Please try again later");
                    break;
                case System.Net.HttpStatusCode.GatewayTimeout:
                    progress.Report("Gateway Timeout. Please try again later");
                    break;
                case System.Net.HttpStatusCode.RequestTimeout:
                    progress.Report("Request Timeout. Please try again later");
                    break;
                case System.Net.HttpStatusCode.RequestedRangeNotSatisfiable:
                    progress.Report("Requested Range Not Satisfiable. Please try again later");
                    break;
                case System.Net.HttpStatusCode.RequestEntityTooLarge:
                    progress.Report("Request Entity Too Large. Please try again later");
                    break;
                case System.Net.HttpStatusCode.RequestUriTooLong:
                    progress.Report("Request Uri Too Long. Please try again later");
                    break;
                case System.Net.HttpStatusCode.UnsupportedMediaType:
                    progress.Report("Unsupported Media Type. Please try again later");
                    break;
                case System.Net.HttpStatusCode.NotImplemented:
                    progress.Report("Not Implemented. Please try again later");
                    break;
                case System.Net.HttpStatusCode.HttpVersionNotSupported:
                    progress.Report("Http Version Not Supported. Please try again later");
                    break;
                default:
                    if (!string.IsNullOrEmpty(response.ErrorMessage))
                        progress.Report($"Unknown error with message [{response.ErrorMessage}]");
                    else
                        progress.Report($"Unknown error with status code [{response.StatusCode}] and description [{response.StatusDescription}]");
                    break;
            }

            return true;
        }
    }
}
