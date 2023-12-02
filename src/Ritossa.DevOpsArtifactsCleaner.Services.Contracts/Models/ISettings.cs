namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models
{
    public interface ISettings
    {
        string UserSettings { get; set; }
        string ProtectedPat { get; set; }
        void Save();
    }
}
