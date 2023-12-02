using Ritossa.DevOpsArtifactsCleaner.Services.Contracts;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;
using System.Security;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Forms
{
    public partial class OptionsForm : Form
    {
        private const string MASKED_PAT = "***";

        private readonly IUserSettingsService _userSettingsService;
        private readonly IDevOpsService _devOpsService;

        private UserSettingsModel? _userSettings;

        public OptionsForm(IUserSettingsService userSettingsService, IDevOpsService devOpsService)
        {
            _userSettingsService = userSettingsService;
            _devOpsService = devOpsService;

            InitializeComponent();

            if (!DesignMode)
                LoadSettings();
        }

        private void LoadSettings()
        {
            var settings = _userSettingsService.LoadFrom(Properties.Settings.Default);

            tbOrganization.Text = settings.Organization;
            tbProject.Text = settings.Project;
            tbFeedId.Text = settings.FeedId;
            tbPat.Text = settings.Pat?.Length > 0 ? MASKED_PAT : string.Empty;

            _userSettings = settings;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var userSettings = PrepareSettings();

            var progress = new Progress<string>(message => toolStripStatusLabel.Text = message);

            var isConnectionSuccessful = false;
            await Task.Run(() => isConnectionSuccessful = _devOpsService.TestConnection(userSettings, progress));

            if (!isConnectionSuccessful)
            {
                var message = toolStripStatusLabel.Text;
                toolStripStatusLabel.Text = string.Empty;

                MessageBox.Show($"Connection failed: {message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (SaveSettings(userSettings))
            {
                toolStripStatusLabel.Text = string.Empty;
                MessageBox.Show("Connection tested with success! Settings saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private UserSettingsModel PrepareSettings()
        {
            SecureString? patAsSecureString = null;

            if (string.IsNullOrWhiteSpace(tbPat.Text))
            {
                MessageBox.Show("Please enter a valid PAT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new UserSettingsModel();
            }

            if (tbPat.Text != MASKED_PAT)
            {
                patAsSecureString = new SecureString();
                tbPat.Text.ToCharArray().ToList().ForEach(patAsSecureString.AppendChar);
            }
            else
            {
                patAsSecureString = _userSettings?.Pat;
            }

            if (_userSettings == null)
                throw new InvalidOperationException("User settings not loaded");

            var userSettings = new UserSettingsModel
            {
                Organization = tbOrganization.Text,
                Project = tbProject.Text,
                FeedId = tbFeedId.Text,
                Pat = patAsSecureString
            };

            return userSettings;
        }

        private bool SaveSettings(UserSettingsModel userSettings)
        {
            _userSettingsService.Save(userSettings, Properties.Settings.Default);
            _userSettings = userSettings;

            return true;
        }
    }
}
