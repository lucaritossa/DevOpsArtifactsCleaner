using Newtonsoft.Json;
using System.Security;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

public class UserSettingsModel
{
    public string Organization { get; set; } = string.Empty;
    public string Project { get; set; } = string.Empty;
    public string FeedId { get; set; } = string.Empty;
    public string ProtocolType { get; set; } = "nuget";
    public bool IncludeAllVersions { get; set; } = true;



    [JsonIgnore]
    public SecureString? Pat { get; set; }

    public MainFormSettings MainForm { get; set; } = new();

    public class MainFormSettings
    {
        public int WindowWidth { get; set; }
        public int WindowHeight { get; set; }
        public int VerticalSplitterDistance { get; set; }
        public int HorizontalSplitterDistance { get; set; }
        public int VerticalSplitterDefaultDistance { get; set; }
        public int HorizontalSplitterDefaultDistance { get; set; }
    }
}