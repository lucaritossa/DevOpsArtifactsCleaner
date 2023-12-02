using Ritossa.DevOpsArtifactsCleaner.Services.Contracts.Models;

namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            btnUnlist = new Button();
            tbOrganization = new TextBox();
            tbFeedId = new TextBox();
            lblOrganization = new Label();
            lblFeedId = new Label();
            comboBoxProtocolType = new ComboBox();
            lblProtocolType = new Label();
            cbIncludeAllVersions = new CheckBox();
            parametersGroupBox = new GroupBox();
            tbProject = new TextBox();
            lblProject = new Label();
            btnLoad = new Button();
            masterDataGridView = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            protocolTypeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urlDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            masterBindingSource = new BindingSource(components);
            detailsDataGridView = new DataGridView();
            versionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            isLatestDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isOfficialReleaseDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isPreReleaseDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            isListedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            IsUnlisted = new DataGridViewCheckBoxColumn();
            publishDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            idDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            storageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailsBindingSource = new BindingSource(components);
            verticalSplitContainer = new SplitContainer();
            packagesGroupBox = new GroupBox();
            pictureBoxFilterPackages = new PictureBox();
            btnClearFilterPackages = new Button();
            tbFilterPackages = new TextBox();
            lblFilterPackages = new Label();
            horizontalSplitContainer = new SplitContainer();
            sameVersionGroupBox = new GroupBox();
            pictureBoxFilterPackagesVersions = new PictureBox();
            btnRelist = new Button();
            btnCleanFilterPackagesVersions = new Button();
            btnDelete = new Button();
            tbFilterPackagesVersions = new TextBox();
            lblFilterPackagesVersions = new Label();
            packagesVersionsDataGridView = new DataGridView();
            versionDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            isLatestDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            isOfficialReleaseDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            isPreReleaseDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            isListedDataGridViewCheckBoxColumn1 = new DataGridViewCheckBoxColumn();
            isUnlistedDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            publishDateDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            packageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            versionIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            storageIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            protocolTypeDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            packagesVersionsBindingSource = new BindingSource(components);
            detailsGroupBox = new GroupBox();
            cbShowUnlisted = new CheckBox();
            cbShowListed = new CheckBox();
            tbPackageName = new TextBox();
            cbShowOfficialRelease = new CheckBox();
            cbShowPreRelease = new CheckBox();
            lblVersionsCount = new Label();
            lblVersions = new Label();
            lblPackage = new Label();
            toolTipFilterIsActive = new ToolTip(components);
            statusStrip = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            menuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            resetLayoutToolStripMenuItem = new ToolStripMenuItem();
            toolsToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            parametersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)masterDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalSplitContainer).BeginInit();
            verticalSplitContainer.Panel1.SuspendLayout();
            verticalSplitContainer.Panel2.SuspendLayout();
            verticalSplitContainer.SuspendLayout();
            packagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilterPackages).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horizontalSplitContainer).BeginInit();
            horizontalSplitContainer.Panel1.SuspendLayout();
            horizontalSplitContainer.Panel2.SuspendLayout();
            horizontalSplitContainer.SuspendLayout();
            sameVersionGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilterPackagesVersions).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packagesVersionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)packagesVersionsBindingSource).BeginInit();
            detailsGroupBox.SuspendLayout();
            statusStrip.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // btnUnlist
            // 
            btnUnlist.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnUnlist.Enabled = false;
            btnUnlist.Location = new Point(698, 293);
            btnUnlist.Name = "btnUnlist";
            btnUnlist.Size = new Size(75, 23);
            btnUnlist.TabIndex = 9;
            btnUnlist.Text = "&UNLIST";
            btnUnlist.UseVisualStyleBackColor = true;
            btnUnlist.Click += btnUnlist_Click;
            // 
            // tbOrganization
            // 
            tbOrganization.Enabled = false;
            tbOrganization.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbOrganization.Location = new Point(98, 22);
            tbOrganization.Name = "tbOrganization";
            tbOrganization.Size = new Size(163, 23);
            tbOrganization.TabIndex = 1;
            // 
            // tbFeedId
            // 
            tbFeedId.Enabled = false;
            tbFeedId.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbFeedId.Location = new Point(539, 23);
            tbFeedId.Name = "tbFeedId";
            tbFeedId.Size = new Size(121, 23);
            tbFeedId.TabIndex = 3;
            // 
            // lblOrganization
            // 
            lblOrganization.AutoSize = true;
            lblOrganization.Location = new Point(14, 26);
            lblOrganization.Name = "lblOrganization";
            lblOrganization.Size = new Size(78, 15);
            lblOrganization.TabIndex = 0;
            lblOrganization.Text = "Organization:";
            // 
            // lblFeedId
            // 
            lblFeedId.AutoSize = true;
            lblFeedId.Location = new Point(485, 26);
            lblFeedId.Name = "lblFeedId";
            lblFeedId.Size = new Size(48, 15);
            lblFeedId.TabIndex = 2;
            lblFeedId.Text = "Feed Id:";
            // 
            // comboBoxProtocolType
            // 
            comboBoxProtocolType.Enabled = false;
            comboBoxProtocolType.FormattingEnabled = true;
            comboBoxProtocolType.Items.AddRange(new object[] { "nuget", "npm" });
            comboBoxProtocolType.Location = new Point(98, 49);
            comboBoxProtocolType.Name = "comboBoxProtocolType";
            comboBoxProtocolType.Size = new Size(88, 23);
            comboBoxProtocolType.TabIndex = 5;
            comboBoxProtocolType.Text = "nuget";
            // 
            // lblProtocolType
            // 
            lblProtocolType.AutoSize = true;
            lblProtocolType.Location = new Point(10, 52);
            lblProtocolType.Name = "lblProtocolType";
            lblProtocolType.Size = new Size(82, 15);
            lblProtocolType.TabIndex = 4;
            lblProtocolType.Text = "Protocol Type:";
            // 
            // cbIncludeAllVersions
            // 
            cbIncludeAllVersions.AutoSize = true;
            cbIncludeAllVersions.Checked = true;
            cbIncludeAllVersions.CheckState = CheckState.Checked;
            cbIncludeAllVersions.Location = new Point(192, 51);
            cbIncludeAllVersions.Name = "cbIncludeAllVersions";
            cbIncludeAllVersions.RightToLeft = RightToLeft.Yes;
            cbIncludeAllVersions.Size = new Size(126, 19);
            cbIncludeAllVersions.TabIndex = 6;
            cbIncludeAllVersions.Text = "Include all versions";
            cbIncludeAllVersions.UseVisualStyleBackColor = true;
            // 
            // parametersGroupBox
            // 
            parametersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            parametersGroupBox.Controls.Add(tbProject);
            parametersGroupBox.Controls.Add(lblProject);
            parametersGroupBox.Controls.Add(btnLoad);
            parametersGroupBox.Controls.Add(cbIncludeAllVersions);
            parametersGroupBox.Controls.Add(tbOrganization);
            parametersGroupBox.Controls.Add(tbFeedId);
            parametersGroupBox.Controls.Add(lblProtocolType);
            parametersGroupBox.Controls.Add(lblOrganization);
            parametersGroupBox.Controls.Add(comboBoxProtocolType);
            parametersGroupBox.Controls.Add(lblFeedId);
            parametersGroupBox.Location = new Point(12, 12);
            parametersGroupBox.Name = "parametersGroupBox";
            parametersGroupBox.Size = new Size(1299, 80);
            parametersGroupBox.TabIndex = 11;
            parametersGroupBox.TabStop = false;
            parametersGroupBox.Text = "Parameters";
            // 
            // tbProject
            // 
            tbProject.Enabled = false;
            tbProject.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbProject.Location = new Point(320, 22);
            tbProject.Name = "tbProject";
            tbProject.Size = new Size(159, 23);
            tbProject.TabIndex = 11;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(267, 26);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(47, 15);
            lblProject.TabIndex = 10;
            lblProject.Text = "Project:";
            // 
            // btnLoad
            // 
            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLoad.Location = new Point(1234, 22);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(59, 50);
            btnLoad.TabIndex = 9;
            btnLoad.Text = "&LOAD";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // masterDataGridView
            // 
            masterDataGridView.AllowUserToAddRows = false;
            masterDataGridView.AllowUserToDeleteRows = false;
            masterDataGridView.AllowUserToOrderColumns = true;
            masterDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            masterDataGridView.AutoGenerateColumns = false;
            masterDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            masterDataGridView.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, protocolTypeDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn, urlDataGridViewTextBoxColumn });
            masterDataGridView.DataSource = masterBindingSource;
            masterDataGridView.Location = new Point(9, 47);
            masterDataGridView.MultiSelect = false;
            masterDataGridView.Name = "masterDataGridView";
            masterDataGridView.ReadOnly = true;
            masterDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            masterDataGridView.Size = new Size(416, 706);
            masterDataGridView.TabIndex = 12;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            nameDataGridViewTextBoxColumn.Width = 64;
            // 
            // protocolTypeDataGridViewTextBoxColumn
            // 
            protocolTypeDataGridViewTextBoxColumn.DataPropertyName = "ProtocolType";
            protocolTypeDataGridViewTextBoxColumn.HeaderText = "Protocol Type";
            protocolTypeDataGridViewTextBoxColumn.Name = "protocolTypeDataGridViewTextBoxColumn";
            protocolTypeDataGridViewTextBoxColumn.ReadOnly = true;
            protocolTypeDataGridViewTextBoxColumn.Visible = false;
            protocolTypeDataGridViewTextBoxColumn.Width = 104;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 100;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urlDataGridViewTextBoxColumn
            // 
            urlDataGridViewTextBoxColumn.DataPropertyName = "Url";
            urlDataGridViewTextBoxColumn.HeaderText = "Url";
            urlDataGridViewTextBoxColumn.Name = "urlDataGridViewTextBoxColumn";
            urlDataGridViewTextBoxColumn.ReadOnly = true;
            urlDataGridViewTextBoxColumn.Visible = false;
            urlDataGridViewTextBoxColumn.Width = 47;
            // 
            // masterBindingSource
            // 
            masterBindingSource.DataSource = typeof(Models.PackageSourceItem);
            masterBindingSource.CurrentItemChanged += masterBindingSource_CurrentItemChanged;
            // 
            // detailsDataGridView
            // 
            detailsDataGridView.AllowUserToAddRows = false;
            detailsDataGridView.AllowUserToDeleteRows = false;
            detailsDataGridView.AllowUserToOrderColumns = true;
            detailsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            detailsDataGridView.AutoGenerateColumns = false;
            detailsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsDataGridView.Columns.AddRange(new DataGridViewColumn[] { versionDataGridViewTextBoxColumn, isLatestDataGridViewCheckBoxColumn, isOfficialReleaseDataGridViewCheckBoxColumn, isPreReleaseDataGridViewCheckBoxColumn, isListedDataGridViewCheckBoxColumn, IsUnlisted, publishDateDataGridViewTextBoxColumn, idDataGridViewTextBoxColumn1, storageIdDataGridViewTextBoxColumn });
            detailsDataGridView.DataSource = detailsBindingSource;
            detailsDataGridView.Location = new Point(7, 0);
            detailsDataGridView.Name = "detailsDataGridView";
            detailsDataGridView.ReadOnly = true;
            detailsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            detailsDataGridView.Size = new Size(847, 313);
            detailsDataGridView.TabIndex = 13;
            detailsDataGridView.SelectionChanged += detailsDataGridView_SelectionChanged;
            // 
            // versionDataGridViewTextBoxColumn
            // 
            versionDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            versionDataGridViewTextBoxColumn.DataPropertyName = "Version";
            versionDataGridViewTextBoxColumn.HeaderText = "Version";
            versionDataGridViewTextBoxColumn.Name = "versionDataGridViewTextBoxColumn";
            versionDataGridViewTextBoxColumn.ReadOnly = true;
            versionDataGridViewTextBoxColumn.Width = 70;
            // 
            // isLatestDataGridViewCheckBoxColumn
            // 
            isLatestDataGridViewCheckBoxColumn.DataPropertyName = "IsLatest";
            isLatestDataGridViewCheckBoxColumn.HeaderText = "Latest";
            isLatestDataGridViewCheckBoxColumn.Name = "isLatestDataGridViewCheckBoxColumn";
            isLatestDataGridViewCheckBoxColumn.ReadOnly = true;
            isLatestDataGridViewCheckBoxColumn.Width = 44;
            // 
            // isOfficialReleaseDataGridViewCheckBoxColumn
            // 
            isOfficialReleaseDataGridViewCheckBoxColumn.DataPropertyName = "IsOfficialRelease";
            isOfficialReleaseDataGridViewCheckBoxColumn.HeaderText = "Official";
            isOfficialReleaseDataGridViewCheckBoxColumn.Name = "isOfficialReleaseDataGridViewCheckBoxColumn";
            isOfficialReleaseDataGridViewCheckBoxColumn.ReadOnly = true;
            isOfficialReleaseDataGridViewCheckBoxColumn.Width = 51;
            // 
            // isPreReleaseDataGridViewCheckBoxColumn
            // 
            isPreReleaseDataGridViewCheckBoxColumn.DataPropertyName = "IsPreRelease";
            isPreReleaseDataGridViewCheckBoxColumn.HeaderText = "Pre-Release";
            isPreReleaseDataGridViewCheckBoxColumn.Name = "isPreReleaseDataGridViewCheckBoxColumn";
            isPreReleaseDataGridViewCheckBoxColumn.ReadOnly = true;
            isPreReleaseDataGridViewCheckBoxColumn.Width = 74;
            // 
            // isListedDataGridViewCheckBoxColumn
            // 
            isListedDataGridViewCheckBoxColumn.DataPropertyName = "IsListed";
            isListedDataGridViewCheckBoxColumn.HeaderText = "Listed";
            isListedDataGridViewCheckBoxColumn.Name = "isListedDataGridViewCheckBoxColumn";
            isListedDataGridViewCheckBoxColumn.ReadOnly = true;
            isListedDataGridViewCheckBoxColumn.Width = 44;
            // 
            // IsUnlisted
            // 
            IsUnlisted.DataPropertyName = "IsUnlisted";
            IsUnlisted.HeaderText = "Unlisted";
            IsUnlisted.Name = "IsUnlisted";
            IsUnlisted.ReadOnly = true;
            IsUnlisted.Width = 56;
            // 
            // publishDateDataGridViewTextBoxColumn
            // 
            publishDateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            publishDateDataGridViewTextBoxColumn.DataPropertyName = "PublishDate";
            publishDateDataGridViewTextBoxColumn.HeaderText = "Publish Date";
            publishDateDataGridViewTextBoxColumn.Name = "publishDateDataGridViewTextBoxColumn";
            publishDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            idDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn1.HeaderText = "Id";
            idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            idDataGridViewTextBoxColumn1.ReadOnly = true;
            idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // storageIdDataGridViewTextBoxColumn
            // 
            storageIdDataGridViewTextBoxColumn.DataPropertyName = "StorageId";
            storageIdDataGridViewTextBoxColumn.HeaderText = "StorageId";
            storageIdDataGridViewTextBoxColumn.Name = "storageIdDataGridViewTextBoxColumn";
            storageIdDataGridViewTextBoxColumn.ReadOnly = true;
            storageIdDataGridViewTextBoxColumn.Visible = false;
            storageIdDataGridViewTextBoxColumn.Width = 82;
            // 
            // detailsBindingSource
            // 
            detailsBindingSource.DataSource = typeof(VersionModel);
            // 
            // verticalSplitContainer
            // 
            verticalSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            verticalSplitContainer.Enabled = false;
            verticalSplitContainer.Location = new Point(12, 98);
            verticalSplitContainer.Name = "verticalSplitContainer";
            // 
            // verticalSplitContainer.Panel1
            // 
            verticalSplitContainer.Panel1.Controls.Add(packagesGroupBox);
            // 
            // verticalSplitContainer.Panel2
            // 
            verticalSplitContainer.Panel2.Controls.Add(horizontalSplitContainer);
            verticalSplitContainer.Panel2.Controls.Add(detailsGroupBox);
            verticalSplitContainer.Size = new Size(1299, 765);
            verticalSplitContainer.SplitterDistance = 428;
            verticalSplitContainer.TabIndex = 14;
            // 
            // packagesGroupBox
            // 
            packagesGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            packagesGroupBox.Controls.Add(pictureBoxFilterPackages);
            packagesGroupBox.Controls.Add(btnClearFilterPackages);
            packagesGroupBox.Controls.Add(tbFilterPackages);
            packagesGroupBox.Controls.Add(masterDataGridView);
            packagesGroupBox.Controls.Add(lblFilterPackages);
            packagesGroupBox.Location = new Point(0, 9);
            packagesGroupBox.Name = "packagesGroupBox";
            packagesGroupBox.Size = new Size(425, 753);
            packagesGroupBox.TabIndex = 18;
            packagesGroupBox.TabStop = false;
            packagesGroupBox.Text = "Packages";
            // 
            // pictureBoxFilterPackages
            // 
            pictureBoxFilterPackages.Image = Properties.Resources.icons8_warning_48;
            pictureBoxFilterPackages.InitialImage = Properties.Resources.icons8_warning_48;
            pictureBoxFilterPackages.Location = new Point(381, 18);
            pictureBoxFilterPackages.Name = "pictureBoxFilterPackages";
            pictureBoxFilterPackages.Size = new Size(23, 23);
            pictureBoxFilterPackages.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFilterPackages.TabIndex = 20;
            pictureBoxFilterPackages.TabStop = false;
            pictureBoxFilterPackages.Visible = false;
            pictureBoxFilterPackages.MouseLeave += pictureBoxFilterPackages_MouseLeave;
            pictureBoxFilterPackages.MouseHover += pictureBoxFilterPackages_MouseHover;
            // 
            // btnClearFilterPackages
            // 
            btnClearFilterPackages.Location = new Point(356, 18);
            btnClearFilterPackages.Name = "btnClearFilterPackages";
            btnClearFilterPackages.Size = new Size(19, 23);
            btnClearFilterPackages.TabIndex = 19;
            btnClearFilterPackages.Text = "X";
            btnClearFilterPackages.UseVisualStyleBackColor = true;
            btnClearFilterPackages.Click += btnClearFilterPackages_Click;
            // 
            // tbFilterPackages
            // 
            tbFilterPackages.Location = new Point(51, 18);
            tbFilterPackages.Name = "tbFilterPackages";
            tbFilterPackages.Size = new Size(309, 23);
            tbFilterPackages.TabIndex = 17;
            tbFilterPackages.TextChanged += tbFilterPackages_TextChanged;
            // 
            // lblFilterPackages
            // 
            lblFilterPackages.AutoSize = true;
            lblFilterPackages.Location = new Point(9, 21);
            lblFilterPackages.Name = "lblFilterPackages";
            lblFilterPackages.Size = new Size(36, 15);
            lblFilterPackages.TabIndex = 16;
            lblFilterPackages.Text = "Filter:";
            // 
            // horizontalSplitContainer
            // 
            horizontalSplitContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            horizontalSplitContainer.Location = new Point(3, 115);
            horizontalSplitContainer.Name = "horizontalSplitContainer";
            horizontalSplitContainer.Orientation = Orientation.Horizontal;
            // 
            // horizontalSplitContainer.Panel1
            // 
            horizontalSplitContainer.Panel1.Controls.Add(detailsDataGridView);
            // 
            // horizontalSplitContainer.Panel2
            // 
            horizontalSplitContainer.Panel2.Controls.Add(sameVersionGroupBox);
            horizontalSplitContainer.Size = new Size(861, 647);
            horizontalSplitContainer.SplitterDistance = 321;
            horizontalSplitContainer.TabIndex = 24;
            // 
            // sameVersionGroupBox
            // 
            sameVersionGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sameVersionGroupBox.Controls.Add(pictureBoxFilterPackagesVersions);
            sameVersionGroupBox.Controls.Add(btnRelist);
            sameVersionGroupBox.Controls.Add(btnCleanFilterPackagesVersions);
            sameVersionGroupBox.Controls.Add(btnDelete);
            sameVersionGroupBox.Controls.Add(tbFilterPackagesVersions);
            sameVersionGroupBox.Controls.Add(btnUnlist);
            sameVersionGroupBox.Controls.Add(lblFilterPackagesVersions);
            sameVersionGroupBox.Controls.Add(packagesVersionsDataGridView);
            sameVersionGroupBox.Location = new Point(0, 3);
            sameVersionGroupBox.Name = "sameVersionGroupBox";
            sameVersionGroupBox.Size = new Size(861, 319);
            sameVersionGroupBox.TabIndex = 23;
            sameVersionGroupBox.TabStop = false;
            sameVersionGroupBox.Text = "All packages with selected version(s)";
            // 
            // pictureBoxFilterPackagesVersions
            // 
            pictureBoxFilterPackagesVersions.Image = Properties.Resources.icons8_warning_48;
            pictureBoxFilterPackagesVersions.InitialImage = Properties.Resources.icons8_warning_48;
            pictureBoxFilterPackagesVersions.Location = new Point(378, 19);
            pictureBoxFilterPackagesVersions.Name = "pictureBoxFilterPackagesVersions";
            pictureBoxFilterPackagesVersions.Size = new Size(23, 23);
            pictureBoxFilterPackagesVersions.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxFilterPackagesVersions.TabIndex = 21;
            pictureBoxFilterPackagesVersions.TabStop = false;
            pictureBoxFilterPackagesVersions.Visible = false;
            pictureBoxFilterPackagesVersions.MouseLeave += pictureBoxFilterPackagesVersions_MouseLeave;
            pictureBoxFilterPackagesVersions.MouseHover += pictureBoxFilterPackagesVersions_MouseHover;
            // 
            // btnRelist
            // 
            btnRelist.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRelist.Enabled = false;
            btnRelist.Location = new Point(617, 293);
            btnRelist.Name = "btnRelist";
            btnRelist.Size = new Size(75, 23);
            btnRelist.TabIndex = 16;
            btnRelist.Text = "&RELIST";
            btnRelist.UseVisualStyleBackColor = true;
            btnRelist.Click += btnRelist_Click;
            // 
            // btnCleanFilterPackagesVersions
            // 
            btnCleanFilterPackagesVersions.Location = new Point(353, 19);
            btnCleanFilterPackagesVersions.Name = "btnCleanFilterPackagesVersions";
            btnCleanFilterPackagesVersions.Size = new Size(19, 23);
            btnCleanFilterPackagesVersions.TabIndex = 20;
            btnCleanFilterPackagesVersions.Text = "X";
            btnCleanFilterPackagesVersions.UseVisualStyleBackColor = true;
            btnCleanFilterPackagesVersions.Click += btnClearFilterPackagesVersions_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Enabled = false;
            btnDelete.Location = new Point(779, 293);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 15;
            btnDelete.Text = "&DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbFilterPackagesVersions
            // 
            tbFilterPackagesVersions.Location = new Point(49, 19);
            tbFilterPackagesVersions.Name = "tbFilterPackagesVersions";
            tbFilterPackagesVersions.Size = new Size(309, 23);
            tbFilterPackagesVersions.TabIndex = 2;
            tbFilterPackagesVersions.TextChanged += tbFilterPackagesVersions_TextChanged;
            // 
            // lblFilterPackagesVersions
            // 
            lblFilterPackagesVersions.AutoSize = true;
            lblFilterPackagesVersions.Location = new Point(6, 22);
            lblFilterPackagesVersions.Name = "lblFilterPackagesVersions";
            lblFilterPackagesVersions.Size = new Size(36, 15);
            lblFilterPackagesVersions.TabIndex = 1;
            lblFilterPackagesVersions.Text = "Filter:";
            // 
            // packagesVersionsDataGridView
            // 
            packagesVersionsDataGridView.AllowUserToAddRows = false;
            packagesVersionsDataGridView.AllowUserToDeleteRows = false;
            packagesVersionsDataGridView.AllowUserToOrderColumns = true;
            packagesVersionsDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            packagesVersionsDataGridView.AutoGenerateColumns = false;
            packagesVersionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            packagesVersionsDataGridView.Columns.AddRange(new DataGridViewColumn[] { versionDataGridViewTextBoxColumn1, nameDataGridViewTextBoxColumn1, isLatestDataGridViewCheckBoxColumn1, isOfficialReleaseDataGridViewCheckBoxColumn1, isPreReleaseDataGridViewCheckBoxColumn1, isListedDataGridViewCheckBoxColumn1, isUnlistedDataGridViewCheckBoxColumn, publishDateDataGridViewTextBoxColumn1, packageIdDataGridViewTextBoxColumn, versionIdDataGridViewTextBoxColumn, storageIdDataGridViewTextBoxColumn1, protocolTypeDataGridViewTextBoxColumn1 });
            packagesVersionsDataGridView.DataSource = packagesVersionsBindingSource;
            packagesVersionsDataGridView.Location = new Point(7, 48);
            packagesVersionsDataGridView.Name = "packagesVersionsDataGridView";
            packagesVersionsDataGridView.ReadOnly = true;
            packagesVersionsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            packagesVersionsDataGridView.Size = new Size(847, 239);
            packagesVersionsDataGridView.TabIndex = 0;
            // 
            // versionDataGridViewTextBoxColumn1
            // 
            versionDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            versionDataGridViewTextBoxColumn1.DataPropertyName = "Version";
            versionDataGridViewTextBoxColumn1.HeaderText = "Version";
            versionDataGridViewTextBoxColumn1.MinimumWidth = 100;
            versionDataGridViewTextBoxColumn1.Name = "versionDataGridViewTextBoxColumn1";
            versionDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            nameDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            nameDataGridViewTextBoxColumn1.MinimumWidth = 150;
            nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            nameDataGridViewTextBoxColumn1.ReadOnly = true;
            nameDataGridViewTextBoxColumn1.Width = 150;
            // 
            // isLatestDataGridViewCheckBoxColumn1
            // 
            isLatestDataGridViewCheckBoxColumn1.DataPropertyName = "IsLatest";
            isLatestDataGridViewCheckBoxColumn1.HeaderText = "Latest";
            isLatestDataGridViewCheckBoxColumn1.MinimumWidth = 50;
            isLatestDataGridViewCheckBoxColumn1.Name = "isLatestDataGridViewCheckBoxColumn1";
            isLatestDataGridViewCheckBoxColumn1.ReadOnly = true;
            isLatestDataGridViewCheckBoxColumn1.Width = 80;
            // 
            // isOfficialReleaseDataGridViewCheckBoxColumn1
            // 
            isOfficialReleaseDataGridViewCheckBoxColumn1.DataPropertyName = "IsOfficialRelease";
            isOfficialReleaseDataGridViewCheckBoxColumn1.HeaderText = "Official";
            isOfficialReleaseDataGridViewCheckBoxColumn1.MinimumWidth = 50;
            isOfficialReleaseDataGridViewCheckBoxColumn1.Name = "isOfficialReleaseDataGridViewCheckBoxColumn1";
            isOfficialReleaseDataGridViewCheckBoxColumn1.ReadOnly = true;
            isOfficialReleaseDataGridViewCheckBoxColumn1.Width = 80;
            // 
            // isPreReleaseDataGridViewCheckBoxColumn1
            // 
            isPreReleaseDataGridViewCheckBoxColumn1.DataPropertyName = "IsPreRelease";
            isPreReleaseDataGridViewCheckBoxColumn1.HeaderText = "Pre-Release";
            isPreReleaseDataGridViewCheckBoxColumn1.MinimumWidth = 80;
            isPreReleaseDataGridViewCheckBoxColumn1.Name = "isPreReleaseDataGridViewCheckBoxColumn1";
            isPreReleaseDataGridViewCheckBoxColumn1.ReadOnly = true;
            isPreReleaseDataGridViewCheckBoxColumn1.Width = 80;
            // 
            // isListedDataGridViewCheckBoxColumn1
            // 
            isListedDataGridViewCheckBoxColumn1.DataPropertyName = "IsListed";
            isListedDataGridViewCheckBoxColumn1.HeaderText = "Listed";
            isListedDataGridViewCheckBoxColumn1.MinimumWidth = 50;
            isListedDataGridViewCheckBoxColumn1.Name = "isListedDataGridViewCheckBoxColumn1";
            isListedDataGridViewCheckBoxColumn1.ReadOnly = true;
            isListedDataGridViewCheckBoxColumn1.Width = 80;
            // 
            // isUnlistedDataGridViewCheckBoxColumn
            // 
            isUnlistedDataGridViewCheckBoxColumn.DataPropertyName = "IsUnlisted";
            isUnlistedDataGridViewCheckBoxColumn.HeaderText = "Unlisted";
            isUnlistedDataGridViewCheckBoxColumn.MinimumWidth = 50;
            isUnlistedDataGridViewCheckBoxColumn.Name = "isUnlistedDataGridViewCheckBoxColumn";
            isUnlistedDataGridViewCheckBoxColumn.ReadOnly = true;
            isUnlistedDataGridViewCheckBoxColumn.Width = 80;
            // 
            // publishDateDataGridViewTextBoxColumn1
            // 
            publishDateDataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            publishDateDataGridViewTextBoxColumn1.DataPropertyName = "PublishDate";
            publishDateDataGridViewTextBoxColumn1.HeaderText = "Publish Date";
            publishDateDataGridViewTextBoxColumn1.MinimumWidth = 100;
            publishDateDataGridViewTextBoxColumn1.Name = "publishDateDataGridViewTextBoxColumn1";
            publishDateDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            packageIdDataGridViewTextBoxColumn.HeaderText = "PackageId";
            packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            packageIdDataGridViewTextBoxColumn.ReadOnly = true;
            packageIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // versionIdDataGridViewTextBoxColumn
            // 
            versionIdDataGridViewTextBoxColumn.DataPropertyName = "VersionId";
            versionIdDataGridViewTextBoxColumn.HeaderText = "VersionId";
            versionIdDataGridViewTextBoxColumn.Name = "versionIdDataGridViewTextBoxColumn";
            versionIdDataGridViewTextBoxColumn.ReadOnly = true;
            versionIdDataGridViewTextBoxColumn.Visible = false;
            // 
            // storageIdDataGridViewTextBoxColumn1
            // 
            storageIdDataGridViewTextBoxColumn1.DataPropertyName = "StorageId";
            storageIdDataGridViewTextBoxColumn1.HeaderText = "StorageId";
            storageIdDataGridViewTextBoxColumn1.Name = "storageIdDataGridViewTextBoxColumn1";
            storageIdDataGridViewTextBoxColumn1.ReadOnly = true;
            storageIdDataGridViewTextBoxColumn1.Visible = false;
            // 
            // protocolTypeDataGridViewTextBoxColumn1
            // 
            protocolTypeDataGridViewTextBoxColumn1.DataPropertyName = "ProtocolType";
            protocolTypeDataGridViewTextBoxColumn1.HeaderText = "Protocol Type";
            protocolTypeDataGridViewTextBoxColumn1.MinimumWidth = 50;
            protocolTypeDataGridViewTextBoxColumn1.Name = "protocolTypeDataGridViewTextBoxColumn1";
            protocolTypeDataGridViewTextBoxColumn1.ReadOnly = true;
            protocolTypeDataGridViewTextBoxColumn1.Visible = false;
            protocolTypeDataGridViewTextBoxColumn1.Width = 50;
            // 
            // packagesVersionsBindingSource
            // 
            packagesVersionsBindingSource.DataSource = typeof(PackageVersionModel);
            // 
            // detailsGroupBox
            // 
            detailsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            detailsGroupBox.Controls.Add(cbShowUnlisted);
            detailsGroupBox.Controls.Add(cbShowListed);
            detailsGroupBox.Controls.Add(tbPackageName);
            detailsGroupBox.Controls.Add(cbShowOfficialRelease);
            detailsGroupBox.Controls.Add(cbShowPreRelease);
            detailsGroupBox.Controls.Add(lblVersionsCount);
            detailsGroupBox.Controls.Add(lblVersions);
            detailsGroupBox.Controls.Add(lblPackage);
            detailsGroupBox.Location = new Point(3, 3);
            detailsGroupBox.Name = "detailsGroupBox";
            detailsGroupBox.Size = new Size(861, 106);
            detailsGroupBox.TabIndex = 22;
            detailsGroupBox.TabStop = false;
            detailsGroupBox.Text = "Details";
            // 
            // cbShowUnlisted
            // 
            cbShowUnlisted.AutoSize = true;
            cbShowUnlisted.Checked = true;
            cbShowUnlisted.CheckState = CheckState.Checked;
            cbShowUnlisted.Location = new Point(391, 75);
            cbShowUnlisted.Name = "cbShowUnlisted";
            cbShowUnlisted.RightToLeft = RightToLeft.Yes;
            cbShowUnlisted.Size = new Size(101, 19);
            cbShowUnlisted.TabIndex = 24;
            cbShowUnlisted.Text = "Show Unlisted";
            cbShowUnlisted.UseVisualStyleBackColor = true;
            cbShowUnlisted.CheckedChanged += cbShowUnlisted_CheckedChanged;
            // 
            // cbShowListed
            // 
            cbShowListed.AutoSize = true;
            cbShowListed.Checked = true;
            cbShowListed.CheckState = CheckState.Checked;
            cbShowListed.Location = new Point(296, 75);
            cbShowListed.Name = "cbShowListed";
            cbShowListed.RightToLeft = RightToLeft.Yes;
            cbShowListed.Size = new Size(89, 19);
            cbShowListed.TabIndex = 23;
            cbShowListed.Text = "Show Listed";
            cbShowListed.UseVisualStyleBackColor = true;
            cbShowListed.CheckedChanged += cbShowListed_CheckedChanged;
            // 
            // tbPackageName
            // 
            tbPackageName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbPackageName.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            tbPackageName.Location = new Point(66, 21);
            tbPackageName.Name = "tbPackageName";
            tbPackageName.ReadOnly = true;
            tbPackageName.Size = new Size(789, 23);
            tbPackageName.TabIndex = 22;
            // 
            // cbShowOfficialRelease
            // 
            cbShowOfficialRelease.AutoSize = true;
            cbShowOfficialRelease.Checked = true;
            cbShowOfficialRelease.CheckState = CheckState.Checked;
            cbShowOfficialRelease.Location = new Point(7, 75);
            cbShowOfficialRelease.Name = "cbShowOfficialRelease";
            cbShowOfficialRelease.RightToLeft = RightToLeft.Yes;
            cbShowOfficialRelease.Size = new Size(138, 19);
            cbShowOfficialRelease.TabIndex = 18;
            cbShowOfficialRelease.Text = "Show Official Release";
            cbShowOfficialRelease.UseVisualStyleBackColor = true;
            cbShowOfficialRelease.CheckedChanged += cbShowOfficialRelease_CheckedChanged;
            // 
            // cbShowPreRelease
            // 
            cbShowPreRelease.AutoSize = true;
            cbShowPreRelease.Checked = true;
            cbShowPreRelease.CheckState = CheckState.Checked;
            cbShowPreRelease.Location = new Point(151, 75);
            cbShowPreRelease.Name = "cbShowPreRelease";
            cbShowPreRelease.RightToLeft = RightToLeft.Yes;
            cbShowPreRelease.Size = new Size(119, 19);
            cbShowPreRelease.TabIndex = 19;
            cbShowPreRelease.Text = "Show Pre-Release";
            cbShowPreRelease.UseVisualStyleBackColor = true;
            cbShowPreRelease.CheckedChanged += cbShowPreRelease_CheckedChanged;
            // 
            // lblVersionsCount
            // 
            lblVersionsCount.AutoSize = true;
            lblVersionsCount.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblVersionsCount.Location = new Point(66, 49);
            lblVersionsCount.Name = "lblVersionsCount";
            lblVersionsCount.Size = new Size(96, 15);
            lblVersionsCount.TabIndex = 21;
            lblVersionsCount.Text = "{versions count}";
            // 
            // lblVersions
            // 
            lblVersions.AutoSize = true;
            lblVersions.Location = new Point(7, 49);
            lblVersions.Name = "lblVersions";
            lblVersions.Size = new Size(53, 15);
            lblVersions.TabIndex = 20;
            lblVersions.Text = "Versions:";
            // 
            // lblPackage
            // 
            lblPackage.AutoSize = true;
            lblPackage.Location = new Point(6, 24);
            lblPackage.Name = "lblPackage";
            lblPackage.Size = new Size(54, 15);
            lblPackage.TabIndex = 16;
            lblPackage.Text = "Package:";
            // 
            // toolTipFilterIsActive
            // 
            toolTipFilterIsActive.IsBalloon = true;
            toolTipFilterIsActive.ToolTipTitle = "Remember";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip.Location = new Point(0, 866);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(1323, 22);
            statusStrip.TabIndex = 17;
            statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Alignment = ToolStripItemAlignment.Right;
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(250, 16);
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.Visible = false;
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, toolsToolStripMenuItem, helpToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(1323, 24);
            menuStrip.TabIndex = 18;
            menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { resetLayoutToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(44, 20);
            viewToolStripMenuItem.Text = "&View";
            // 
            // resetLayoutToolStripMenuItem
            // 
            resetLayoutToolStripMenuItem.Name = "resetLayoutToolStripMenuItem";
            resetLayoutToolStripMenuItem.Size = new Size(141, 22);
            resetLayoutToolStripMenuItem.Text = "&Reset Layout";
            resetLayoutToolStripMenuItem.Click += resetLayoutToolStripMenuItem_Click;
            // 
            // toolsToolStripMenuItem
            // 
            toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            toolsToolStripMenuItem.Size = new Size(46, 20);
            toolsToolStripMenuItem.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(116, 22);
            optionsToolStripMenuItem.Text = "&Options";
            optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1323, 888);
            Controls.Add(statusStrip);
            Controls.Add(menuStrip);
            Controls.Add(parametersGroupBox);
            Controls.Add(verticalSplitContainer);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip;
            MinimumSize = new Size(1135, 905);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DevOps Artifacts Cleaner";
            FormClosing += MainForm_FormClosing;
            Shown += MainForm_Shown;
            parametersGroupBox.ResumeLayout(false);
            parametersGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)masterDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)masterBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).EndInit();
            verticalSplitContainer.Panel1.ResumeLayout(false);
            verticalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)verticalSplitContainer).EndInit();
            verticalSplitContainer.ResumeLayout(false);
            packagesGroupBox.ResumeLayout(false);
            packagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilterPackages).EndInit();
            horizontalSplitContainer.Panel1.ResumeLayout(false);
            horizontalSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)horizontalSplitContainer).EndInit();
            horizontalSplitContainer.ResumeLayout(false);
            sameVersionGroupBox.ResumeLayout(false);
            sameVersionGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFilterPackagesVersions).EndInit();
            ((System.ComponentModel.ISupportInitialize)packagesVersionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)packagesVersionsBindingSource).EndInit();
            detailsGroupBox.ResumeLayout(false);
            detailsGroupBox.PerformLayout();
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUnlist;
        private TextBox tbOrganization;
        private TextBox tbFeedId;
        private Label lblOrganization;
        private Label lblFeedId;
        private ComboBox comboBoxProtocolType;
        private Label lblProtocolType;
        private CheckBox cbIncludeAllVersions;
        private GroupBox parametersGroupBox;
        private DataGridView masterDataGridView;
        private Button btnLoad;
        private DataGridView detailsDataGridView;
        private SplitContainer verticalSplitContainer;
        private Label lblPackage;
        private Label lblVersionsCount;
        private Label lblVersions;
        private CheckBox cbShowPreRelease;
        private CheckBox cbShowOfficialRelease;
        private GroupBox detailsGroupBox;
        private TextBox tbPackageName;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feedUriDataGridViewTextBoxColumn;
        private BindingSource masterBindingSource;
        private TextBox tbFilterPackages;
        private Label lblFilterPackages;
        private BindingSource detailsBindingSource;
        private CheckBox cbShowUnlisted;
        private CheckBox cbShowListed;
        private GroupBox packagesGroupBox;
        private TextBox tbProject;
        private Label lblProject;
        private GroupBox sameVersionGroupBox;
        private DataGridView packagesVersionsDataGridView;
        private BindingSource packagesVersionsBindingSource;
        private SplitContainer horizontalSplitContainer;
        private DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn isLatestDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isOfficialReleaseDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isPreReleaseDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn isListedDataGridViewCheckBoxColumn;
        private DataGridViewCheckBoxColumn IsUnlisted;
        private DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn storageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn versionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private DataGridViewCheckBoxColumn isLatestDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn isOfficialReleaseDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn isPreReleaseDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn isListedDataGridViewCheckBoxColumn1;
        private DataGridViewCheckBoxColumn isUnlistedDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn publishDateDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn versionIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn storageIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn protocolTypeDataGridViewTextBoxColumn1;
        private Button btnDelete;
        private Button btnClearFilterPackages;
        private Button btnCleanFilterPackagesVersions;
        private TextBox tbFilterPackagesVersions;
        private Label lblFilterPackagesVersions;
        private Button btnRelist;
        private PictureBox pictureBoxFilterPackages;
        private ToolTip toolTipFilterIsActive;
        private PictureBox pictureBoxFilterPackagesVersions;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn protocolTypeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urlDataGridViewTextBoxColumn;
        private StatusStrip statusStrip;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripStatusLabel toolStripStatusLabel;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem toolsToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem resetLayoutToolStripMenuItem;
    }
}
