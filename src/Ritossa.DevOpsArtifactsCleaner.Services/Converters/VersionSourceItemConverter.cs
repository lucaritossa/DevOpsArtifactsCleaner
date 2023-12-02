using Ritossa.DevOpsArtifactsCleaner.ApiClient.Models;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Converters
{
    internal static class ArtifactVersionConverter
    {
        public static VersionModel ToModel(this ArtifactVersion artifactVersion)
        {
            var item = new VersionModel();

            item.Id = artifactVersion.Id;
            item.Version = artifactVersion.Version;
            item.IsLatest = artifactVersion.IsLatest;
            item.IsListed = artifactVersion.IsListed;
            item.StorageId = artifactVersion.StorageId;
            item.PublishDate = artifactVersion.PublishDate;

            return item;
        }

        public static List<VersionModel> ToModel(this List<ArtifactVersion> artifactVersionModels)
        {
            return artifactVersionModels.Select(ToModel).ToList();
        }
    }
}
