using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.Services.Contracts
{

    public interface IUserSettingsService
    {
        void Save(UserSettingsModel source, ISettings settings);
        UserSettingsModel LoadFrom(ISettings settings);
        bool AreUserSettingsDefined(ISettings settings);
    }
}
