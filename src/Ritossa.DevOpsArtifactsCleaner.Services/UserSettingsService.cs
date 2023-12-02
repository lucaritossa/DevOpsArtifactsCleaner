using Ritossa.DevOpsArtifactsCleaner.Services.Contracts;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;
using System.Security;
using System.Security.Cryptography;
using System.Text;

namespace Ritossa.DevOpsArtifactsCleaner.Services
{
    internal class UserSettingsService : IUserSettingsService
    {
        private static byte[] _additionalEntropy = { 1, 2, 8, 5, 2 };

        public void Save(UserSettingsModel source, ISettings settings)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(source);

            settings.UserSettings = json;

            if (source.Pat is not null)
                settings.ProtectedPat = Protect(new System.Net.NetworkCredential(string.Empty, source.Pat).Password);

            settings.Save();
        }

        public UserSettingsModel LoadFrom(ISettings settings)
        {
            UserSettingsModel userSettings;

            if (string.IsNullOrEmpty(settings.UserSettings))
                userSettings = new();
            else
                userSettings = Newtonsoft.Json.JsonConvert.DeserializeObject<UserSettingsModel>(settings.UserSettings);

            if (userSettings == null)
                userSettings = new();

            if (string.IsNullOrEmpty(settings.ProtectedPat))
                return userSettings;

            var secureString = new SecureString();

            Unprotect(settings.ProtectedPat).ToCharArray().ToList().ForEach(secureString.AppendChar);

            userSettings.Pat = secureString;

            return userSettings;
        }

        public bool AreUserSettingsDefined(ISettings settings)
        {
            return !string.IsNullOrEmpty(settings.UserSettings) && !string.IsNullOrEmpty(settings.ProtectedPat);
        }

        private string Protect(string content)
        {
            var bytes = Encoding.UTF8.GetBytes(content);
            var protectedBytes = ProtectedData.Protect(bytes, _additionalEntropy, DataProtectionScope.CurrentUser);
            var protectedJson = Convert.ToBase64String(protectedBytes);
            return protectedJson;
        }

        private string Unprotect(string protectedContent)
        {
            var protectedBytes = Convert.FromBase64String(protectedContent);
            var bytes = ProtectedData.Unprotect(protectedBytes, _additionalEntropy, DataProtectionScope.CurrentUser);
            var json = Encoding.UTF8.GetString(bytes);
            return json;
        }
    }

}
