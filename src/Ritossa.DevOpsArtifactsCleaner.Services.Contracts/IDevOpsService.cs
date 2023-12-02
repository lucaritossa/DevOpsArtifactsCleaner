using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts
{
    public interface IDevOpsService
    {
        bool TestConnection(UserSettingsModel userSettings, IProgress<string> progress);
        List<PackageModel> GetAllPackages(UserSettingsModel settings, IProgress<string> progress);
        bool UnlistVersions(UserSettingsModel settings, List<PackageVersionModel> toUnlist, IProgress<string> progress);
        bool RelistVersions(UserSettingsModel settings, List<PackageVersionModel> toRelist, IProgress<string> progress);
        bool DeletePackageVersions(UserSettingsModel settings, List<PackageVersionModel> toDelete, IProgress<string> progress);
        List<PackageVersionModel> GetAllPackageVersions(List<PackageModel> source);
    }

}
