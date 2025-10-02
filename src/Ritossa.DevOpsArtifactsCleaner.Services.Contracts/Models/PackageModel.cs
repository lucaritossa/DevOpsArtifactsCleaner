using System.Diagnostics;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models
{
    [DebuggerDisplay("{Name}")]
    public class PackageModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string ProtocolType { get; set; }
        public string Url { get; set; }

        public List<VersionModel> Versions { get; set; }
    }
}
