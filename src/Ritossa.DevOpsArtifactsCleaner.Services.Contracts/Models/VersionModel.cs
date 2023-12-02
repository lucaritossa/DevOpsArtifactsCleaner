namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models
{
    public class VersionModel
    {
        public string Id { get; set; }

        public string Version { get; set; }

        public bool IsLatest { get; set; }

        public bool IsListed { get; set; }

        public bool IsUnlisted => !IsListed;

        public bool IsPreRelease => Version.Contains("-");

        public bool IsOfficialRelease => !IsPreRelease;

        public string StorageId { get; set; }

        public DateTime PublishDate { get; set; }
    }
}
