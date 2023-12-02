namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models
{
    public class PackageVersionModel
    {
        #region Package

        public string PackageId { get; set; }
        public string Name { get; set; }
        public string ProtocolType { get; set; }

        #endregion

        #region Version

        public string VersionId { get; set; }
        public string Version { get; set; }
        public bool IsLatest { get; set; }
        public bool IsListed { get; set; }
        public bool IsUnlisted => !IsListed;
        public bool IsPreRelease => Version.Contains("-");
        public bool IsOfficialRelease => !IsPreRelease;
        public string StorageId { get; set; }
        public DateTime PublishDate { get; set; }

        #endregion
    }
}
