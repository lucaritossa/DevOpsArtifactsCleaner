using Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Converters
{
    internal static class ArtifactPackageConverter
    {
        public static PackageModel ToModel(this ArtifactPackage artifact)
        {
            var item = new PackageModel();

            item.Id = artifact.Id;
            item.Name = artifact.Name;
            item.ProtocolType = artifact.ProtocolType;
            item.Url = artifact.Url;
            item.Versions = artifact.Versions.ToModel();

            return item;
        }

        public static List<PackageModel> ToModel(this List<ArtifactPackage> artifacts)
        {
            return new List<PackageModel>(artifacts.Select(ToModel).ToList());
        }
    }
}
