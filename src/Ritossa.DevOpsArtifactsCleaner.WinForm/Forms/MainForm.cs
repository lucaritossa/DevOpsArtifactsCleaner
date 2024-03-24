using Equin.ApplicationFramework;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts;
using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;
using Ritossa.DevOpsArtifactsCleaner.WinForm.Converters;
using Ritossa.DevOpsArtifactsCleaner.WinForm.Models;
using System.Collections;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Forms
{
    public partial class MainForm : Form
    {
        #region Private Fields

        private readonly IDevOpsService _devOpsService;
        private readonly IUserSettingsService _userSettingsService;
        private readonly OptionsForm _optionsForm;

        private List<PackageModel> _allPackages = new();
        private List<PackageVersionModel> _allPackageVersions;
        private UserSettingsModel? _userSettings;

        private const string FILTERED_LIST_MESSAGE = "You are seeing a filtered list";

        #endregion

        #region Constructors

        public MainForm(OptionsForm optionsForm, IUserSettingsService userSettingsService, IDevOpsService devOpsService)
        {
            _optionsForm = optionsForm;
            _userSettingsService = userSettingsService;
            _devOpsService = devOpsService;

            InitializeComponent();
        }

        #endregion

        #region Common Methods

        private void LoadSettings()
        {
            if (!_userSettingsService.AreUserSettingsDefined(Properties.Settings.Default))
            {
                MessageBox.Show("Please configure your settings first", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _optionsForm.ShowDialog();
            }

            _userSettings = _userSettingsService.LoadFrom(Properties.Settings.Default);

            tbOrganization.Text = _userSettings.Organization;
            tbProject.Text = _userSettings.Project;
            tbFeedId.Text = _userSettings.FeedId;
            comboBoxProtocolType.Text = _userSettings.ProtocolType;
            cbIncludeAllVersions.Checked = _userSettings.IncludeAllVersions;
        }

        private bool SaveSettings()
        {
            if (_userSettings == null)
                throw new InvalidOperationException("User settings not loaded");

            _userSettings.ProtocolType = comboBoxProtocolType.Text;
            _userSettings.IncludeAllVersions = cbIncludeAllVersions.Checked;

            _userSettings.MainForm.VerticalSplitterDistance = verticalSplitContainer.SplitterDistance;

            if (_userSettings.MainForm.VerticalSplitterDefaultDistance == 0)
                _userSettings.MainForm.VerticalSplitterDefaultDistance = verticalSplitContainer.SplitterDistance;

            if (_userSettings.MainForm.HorizontalSplitterDefaultDistance == 0)
                _userSettings.MainForm.HorizontalSplitterDefaultDistance = horizontalSplitContainer.SplitterDistance;

            _userSettings.MainForm.HorizontalSplitterDistance = horizontalSplitContainer.SplitterDistance;
            _userSettings.MainForm.WindowWidth = Size.Width;
            _userSettings.MainForm.WindowHeight = Size.Height;

            _userSettingsService.Save(_userSettings, Properties.Settings.Default);

            return true;
        }

        private void Reset()
        {
            masterDataGridView.DataSource = masterBindingSource;
            masterBindingSource.DataSource = null;

            detailsDataGridView.DataSource = detailsBindingSource;
            detailsBindingSource.DataSource = null;

            packagesVersionsDataGridView.DataSource = packagesVersionsBindingSource;
            packagesVersionsBindingSource.DataSource = null;

            btnRelist.Enabled = btnUnlist.Enabled = btnDelete.Enabled = false;
            verticalSplitContainer.Enabled = false;

            tbPackageName.Text = string.Empty;
            lblVersionsCount.Text = string.Empty;
        }

        private async Task LoadData()
        {
            try
            {
                if (!SaveSettings())
                    return;

                btnLoad.Enabled = false;

                toolStripStatusLabel.Text = "Loading packages...";
                toolStripProgressBar.ProgressBar.Show();

                SuspendLayout();

                Reset();

                var progress = new Progress<string>(message => toolStripStatusLabel.Text = message);

                await Task.Run(() => _allPackages = _devOpsService.GetAllPackages(_userSettings, progress));

                if (_allPackages.Count <= 0)
                {
                    toolStripProgressBar.ProgressBar.Hide();
                    var message = toolStripStatusLabel.Text;
                    toolStripStatusLabel.Text = string.Empty;

                    MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _allPackageVersions = _devOpsService.GetAllPackageVersions(_allPackages);

                masterBindingSource.DataSource = _allPackages.ToDataSource();
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = nameof(PackageSourceItem.Versions);

                btnRelist.Enabled = btnUnlist.Enabled = btnDelete.Enabled = true;
                verticalSplitContainer.Enabled = true;

                masterBindingSource.Position = 0;
                detailsBindingSource.Position = 0;
                packagesVersionsBindingSource.Position = 0;

                FilterMasterDataSource();
                FilterDetailsDataSource();
            }
            finally
            {
                ResumeLayout();

                toolStripProgressBar.ProgressBar.Hide();
                btnLoad.Enabled = true;
            }
        }

        private List<T> GetSelectedRows<T>(IEnumerable selectedRowCollection)
        {
            var result = new List<T>();

            foreach (var row in selectedRowCollection.Cast<DataGridViewRow>())
            {
                if (row is null) continue;
                if (row.DataBoundItem is not ObjectView<T> view) continue;

                result.Add(view.Object);
            }

            return result;
        }

        #endregion

        #region Form Behavior events

        private async void MainForm_Shown(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                LoadSettings();

                if (_userSettings.MainForm is { WindowWidth: > 0, WindowHeight: > 0 })
                {
                    Size = new Size(_userSettings.MainForm.WindowWidth, _userSettings.MainForm.WindowHeight);
                    CenterToScreen();
                }

                if (_userSettings.MainForm.VerticalSplitterDistance > 0)
                    verticalSplitContainer.SplitterDistance = _userSettings.MainForm.VerticalSplitterDistance;

                if (_userSettings.MainForm.HorizontalSplitterDistance > 0)
                    horizontalSplitContainer.SplitterDistance = _userSettings.MainForm.HorizontalSplitterDistance;

                await LoadData();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to exit?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (result == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }

            SaveSettings();
        }

        #endregion

        #region ToolStrip events

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using AboutBox aboutBox = new();
            aboutBox.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = _optionsForm.ShowDialog();

            if (result != DialogResult.OK)
                return;

            LoadSettings();
            Reset();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resetLayoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = MinimumSize;

            if (_userSettings.MainForm.VerticalSplitterDefaultDistance > 0)
                verticalSplitContainer.SplitterDistance = _userSettings.MainForm.VerticalSplitterDefaultDistance;

            if (_userSettings.MainForm.HorizontalSplitterDefaultDistance > 0)
                horizontalSplitContainer.SplitterDistance = _userSettings.MainForm.HorizontalSplitterDefaultDistance;
        }

        #endregion

        #region Main Buttons events

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (detailsDataGridView.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select at least one version to delete", "Info", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }

                var toDelete = GetSelectedRows<PackageVersionModel>(packagesVersionsDataGridView.SelectedRows);

                var dialog = MessageBox.Show(
                    $"Are you sure you want to send {toDelete.Count} package versions to the feed's Recycle Bin?\n\n" +
                    "This is disruptive. Any project that relies on selected versions will be unable to build.",
                    "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);

                if (dialog != DialogResult.Yes)
                    return;

                toolStripProgressBar.ProgressBar.Show();

                var progress = new Progress<string>(message => toolStripStatusLabel.Text = message);

                var isSuccessful = false;
                await Task.Run(() =>
                {
                    var chunks = SplitIntoChunks(toDelete, 100);

                    foreach (var chunk in chunks)
                    {
                        isSuccessful = _devOpsService.DeletePackageVersions(_userSettings, chunk, progress);

                        if (isSuccessful == false)
                            break;
                    }
                });


                if (!isSuccessful)
                {
                    toolStripProgressBar.ProgressBar.Hide();
                    var message = toolStripStatusLabel.Text;
                    toolStripStatusLabel.Text = string.Empty;

                    MessageBox.Show($"Deleting failed\n\n{message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"{toDelete.Count} versions deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabel.Text = string.Empty;
            }
            finally
            {
                ResumeLayout();

                toolStripProgressBar.ProgressBar.Hide();
            }
        }

        private async void btnUnlist_Click(object sender, EventArgs e)
        {
            try
            {
                if (packagesVersionsDataGridView.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select at least one version to unlist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var toUnlist = GetSelectedRows<PackageVersionModel>(packagesVersionsDataGridView.SelectedRows);

                var dialog = MessageBox.Show($"Unlisting {toUnlist.Count} versions discourages new usage without impacting existing consumers.\n\nDo you want to continue?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialog != DialogResult.Yes)
                    return;

                toolStripProgressBar.ProgressBar.Show();

                var progress = new Progress<string>(message => toolStripStatusLabel.Text = message);

                var isSuccessful = false;
                await Task.Run(() =>
                {
                    var chunks = SplitIntoChunks(toUnlist, 100);

                    foreach (var chunk in chunks)
                    {
                        isSuccessful = _devOpsService.UnlistVersions(_userSettings, chunk, progress);

                        if (isSuccessful == false)
                            break;
                    }
                });

                if (!isSuccessful)
                {
                    toolStripProgressBar.ProgressBar.Hide();
                    var message = toolStripStatusLabel.Text;
                    toolStripStatusLabel.Text = string.Empty;

                    MessageBox.Show($"Unlisting failed\n\n{message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"{toUnlist.Count} versions unlisted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabel.Text = string.Empty;

                SuspendLayout();

                foreach (DataGridViewRow item in packagesVersionsDataGridView.SelectedRows)
                {
                    var packageVersionItem = (ObjectView<PackageVersionModel>)packagesVersionsDataGridView.Rows[item.Index].DataBoundItem;
                    packageVersionItem.Object.IsListed = false;
                }

                foreach (DataGridViewRow item in detailsDataGridView.SelectedRows)
                {
                    var versionItem = (ObjectView<VersionModel>)detailsDataGridView.Rows[item.Index].DataBoundItem;

                    if (toUnlist.Any(_ => _.VersionId == versionItem.Object.Id))
                        versionItem.Object.IsListed = false;
                }

                packagesVersionsDataGridView.Refresh();
                detailsDataGridView.Refresh();
            }
            finally
            {
                ResumeLayout();

                toolStripProgressBar.ProgressBar.Hide();
            }
        }

        private async void btnRelist_Click(object sender, EventArgs e)
        {
            try
            {
                if (packagesVersionsDataGridView.SelectedRows.Count <= 0)
                {
                    MessageBox.Show("Please select at least one version to relist", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var toRelist = GetSelectedRows<PackageVersionModel>(packagesVersionsDataGridView.SelectedRows);

                var dialog = MessageBox.Show($"Relisting {toRelist.Count} versions makes them available for new usage.\n\nDo you want to continue?", "Please confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dialog != DialogResult.Yes)
                    return;


                toolStripProgressBar.ProgressBar.Show();

                var progress = new Progress<string>(message => toolStripStatusLabel.Text = message);

                var isSuccessful = false;
                await Task.Run(() =>
                {
                    var chunks = SplitIntoChunks(toRelist, 100);

                    foreach (var chunk in chunks)
                    {
                        isSuccessful = _devOpsService.RelistVersions(_userSettings, toRelist, progress);

                        if (isSuccessful == false)
                            break;
                    }
                });

                if (!isSuccessful)
                {
                    toolStripProgressBar.ProgressBar.Hide();
                    var message = toolStripStatusLabel.Text;
                    toolStripStatusLabel.Text = string.Empty;

                    MessageBox.Show($"Relisting failed\n\n{message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show($"{toRelist.Count} versions deleted", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                toolStripStatusLabel.Text = string.Empty;

                SuspendLayout();

                foreach (DataGridViewRow item in packagesVersionsDataGridView.SelectedRows)
                {
                    var packageVersionItem = (ObjectView<PackageVersionModel>)packagesVersionsDataGridView.Rows[item.Index].DataBoundItem;
                    packageVersionItem.Object.IsListed = true;
                }

                foreach (DataGridViewRow item in detailsDataGridView.SelectedRows)
                {
                    var versionItem = (ObjectView<VersionModel>)detailsDataGridView.Rows[item.Index].DataBoundItem;

                    if (toRelist.Any(_ => _.VersionId == versionItem.Object.Id))
                        versionItem.Object.IsListed = true;
                }

                packagesVersionsDataGridView.Refresh();
                detailsDataGridView.Refresh();
            }
            finally
            {
                ResumeLayout();

                toolStripProgressBar.ProgressBar.Hide();
            }
        }

        private static List<List<PackageVersionModel>> SplitIntoChunks(List<PackageVersionModel> list, int chunkSize)
        {
            List<List<PackageVersionModel>> chunks = new List<List<PackageVersionModel>>();

            for (int i = 0; i < list.Count; i += chunkSize)
            {
                List<PackageVersionModel> chunk = list.Skip(i).Take(chunkSize).ToList();
                chunks.Add(chunk);
            }

            return chunks;
        }

        #endregion

        #region Master (packages) gridview events

        private void masterBindingSource_CurrentItemChanged(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();

                if (masterBindingSource.Current is not ObjectView<PackageSourceItem> view) return;

                var package = view.Object;

                tbPackageName.Text = package.Name;

                var originalPackage = _allPackages.FirstOrDefault(_ => _.Id == package.Id);

                if (originalPackage is not null)
                {
                    var count = originalPackage.Versions.Count;
                    var preReleaseCount = originalPackage.Versions.Count(_ => _.IsPreRelease);
                    var officialReleaseCount = count - preReleaseCount;

                    lblVersionsCount.Text = cbIncludeAllVersions.Checked
                        ? $"{count} ({officialReleaseCount} official / {preReleaseCount} pre-release)"
                        : "(?) include all versions to know this value";
                }

                FilterDetailsDataSource();
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void tbFilterPackages_TextChanged(object sender, EventArgs e)
        {
            pictureBoxFilterPackages.Visible = !string.IsNullOrWhiteSpace(tbFilterPackages.Text);
            FilterMasterDataSource();
        }

        private void btnClearFilterPackages_Click(object sender, EventArgs e)
        {
            tbFilterPackages.Text = string.Empty;
        }

        private void pictureBoxFilterPackages_MouseHover(object sender, EventArgs e)
        {
            toolTipFilterIsActive.Show(FILTERED_LIST_MESSAGE, pictureBoxFilterPackages, 1, -75);
        }

        private void pictureBoxFilterPackages_MouseLeave(object sender, EventArgs e)
        {
            toolTipFilterIsActive.Hide(pictureBoxFilterPackages);
        }

        private void FilterMasterDataSource()
        {
            if (masterBindingSource.DataSource is not BindingListView<PackageSourceItem> view) return;

            view.RemoveFilter();
            view.ApplyFilter(_ => _.Name.Contains(tbFilterPackages.Text, StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion

        #region Details (versions) gridview events

        private void detailsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                SuspendLayout();

                packagesVersionsBindingSource.DataSource = null;

                var selectedRow = new List<VersionModel>();

                foreach (var row in detailsDataGridView.SelectedRows.Cast<DataGridViewRow>())
                {
                    if (row is null) continue;
                    if (row.DataBoundItem is not ObjectView<VersionModel> viewItem) continue;

                    selectedRow.Add(viewItem.Object);
                }

                if (selectedRow.Count <= 0) return;

                var versionsSelected = selectedRow.Select(_ => _.Version).ToList();
                if (versionsSelected.Count <= 0) return;

                var dataSource = _allPackageVersions.Where(_ => versionsSelected.Contains(_.Version)).ToList().ToDataSource();
                packagesVersionsBindingSource.DataSource = dataSource;

                FilterPackagesVersionsDataSource();

                packagesVersionsDataGridView.SelectAll();
            }
            finally
            {
                ResumeLayout();
            }
        }

        private void cbShowOfficialRelease_CheckedChanged(object sender, EventArgs e)
        {
            FilterDetailsDataSource();
        }

        private void cbShowPreRelease_CheckedChanged(object sender, EventArgs e)
        {
            FilterDetailsDataSource();
        }

        private void cbShowListed_CheckedChanged(object sender, EventArgs e)
        {
            FilterDetailsDataSource();
        }

        private void cbShowUnlisted_CheckedChanged(object sender, EventArgs e)
        {
            FilterDetailsDataSource();
        }

        private void FilterDetailsDataSource()
        {
            if (masterBindingSource.Current is not ObjectView<PackageSourceItem> view) return;

            view.Object.Versions.RemoveFilter();

            view.Object.Versions.ApplyFilter(_ =>
                (_.IsPreRelease == cbShowPreRelease.Checked || _.IsOfficialRelease == cbShowOfficialRelease.Checked) &&
                (_.IsListed == cbShowListed.Checked || _.IsUnlisted == cbShowUnlisted.Checked));
        }

        #endregion

        #region Packages versions gridview events

        private void tbFilterPackagesVersions_TextChanged(object sender, EventArgs e)
        {
            pictureBoxFilterPackagesVersions.Visible = !string.IsNullOrWhiteSpace(tbFilterPackagesVersions.Text);
            FilterPackagesVersionsDataSource();
        }

        private void btnClearFilterPackagesVersions_Click(object sender, EventArgs e)
        {
            tbFilterPackagesVersions.Text = string.Empty;
        }

        private void pictureBoxFilterPackagesVersions_MouseHover(object sender, EventArgs e)
        {
            toolTipFilterIsActive.Show(FILTERED_LIST_MESSAGE, pictureBoxFilterPackagesVersions, 1, -75);
        }

        private void pictureBoxFilterPackagesVersions_MouseLeave(object sender, EventArgs e)
        {
            toolTipFilterIsActive.Hide(pictureBoxFilterPackagesVersions);
        }

        private void FilterPackagesVersionsDataSource()
        {
            if (packagesVersionsBindingSource.DataSource is not BindingListView<PackageVersionModel> view) return;

            view.RemoveFilter();
            view.ApplyFilter(_ => _.Name.Contains(tbFilterPackagesVersions.Text, StringComparison.InvariantCultureIgnoreCase));
        }

        #endregion

    }
}
