namespace Ritossa.DevOpsArtifactsCleaner.WinForm.Forms
{
    partial class OptionsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbOrganization = new TextBox();
            lblOrganization = new Label();
            tbProject = new TextBox();
            lblProject = new Label();
            tbFeedId = new TextBox();
            lblFeedId = new Label();
            lblPat = new Label();
            tbPat = new TextBox();
            btnSave = new Button();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel = new ToolStripStatusLabel();
            toolStripProgressBar = new ToolStripProgressBar();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // tbOrganization
            // 
            tbOrganization.Location = new Point(145, 26);
            tbOrganization.Name = "tbOrganization";
            tbOrganization.Size = new Size(354, 23);
            tbOrganization.TabIndex = 3;
            // 
            // lblOrganization
            // 
            lblOrganization.AutoSize = true;
            lblOrganization.Location = new Point(61, 29);
            lblOrganization.Name = "lblOrganization";
            lblOrganization.Size = new Size(78, 15);
            lblOrganization.TabIndex = 2;
            lblOrganization.Text = "Organization:";
            // 
            // tbProject
            // 
            tbProject.Location = new Point(145, 55);
            tbProject.Name = "tbProject";
            tbProject.PlaceholderText = "optional";
            tbProject.Size = new Size(354, 23);
            tbProject.TabIndex = 13;
            // 
            // lblProject
            // 
            lblProject.AutoSize = true;
            lblProject.Location = new Point(92, 58);
            lblProject.Name = "lblProject";
            lblProject.Size = new Size(47, 15);
            lblProject.TabIndex = 12;
            lblProject.Text = "Project:";
            // 
            // tbFeedId
            // 
            tbFeedId.Location = new Point(145, 84);
            tbFeedId.Name = "tbFeedId";
            tbFeedId.Size = new Size(354, 23);
            tbFeedId.TabIndex = 15;
            // 
            // lblFeedId
            // 
            lblFeedId.AutoSize = true;
            lblFeedId.Location = new Point(91, 87);
            lblFeedId.Name = "lblFeedId";
            lblFeedId.Size = new Size(48, 15);
            lblFeedId.TabIndex = 14;
            lblFeedId.Text = "Feed Id:";
            // 
            // lblPat
            // 
            lblPat.AutoSize = true;
            lblPat.Location = new Point(11, 116);
            lblPat.Name = "lblPat";
            lblPat.Size = new Size(128, 15);
            lblPat.TabIndex = 16;
            lblPat.Text = "Personal Access Token:";
            // 
            // tbPat
            // 
            tbPat.Location = new Point(145, 113);
            tbPat.Name = "tbPat";
            tbPat.Size = new Size(354, 23);
            tbPat.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSave.Location = new Point(385, 165);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(115, 23);
            btnSave.TabIndex = 18;
            btnSave.Text = "TEST && &SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel, toolStripProgressBar });
            statusStrip1.Location = new Point(0, 191);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(512, 22);
            statusStrip1.TabIndex = 19;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            toolStripStatusLabel.Name = "toolStripStatusLabel";
            toolStripStatusLabel.Size = new Size(39, 17);
            toolStripStatusLabel.Text = "Ready";
            // 
            // toolStripProgressBar
            // 
            toolStripProgressBar.Name = "toolStripProgressBar";
            toolStripProgressBar.Size = new Size(100, 16);
            toolStripProgressBar.Style = ProgressBarStyle.Marquee;
            toolStripProgressBar.Visible = false;
            // 
            // OptionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 213);
            Controls.Add(statusStrip1);
            Controls.Add(btnSave);
            Controls.Add(lblPat);
            Controls.Add(tbPat);
            Controls.Add(tbFeedId);
            Controls.Add(lblFeedId);
            Controls.Add(tbProject);
            Controls.Add(lblProject);
            Controls.Add(tbOrganization);
            Controls.Add(lblOrganization);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OptionsForm";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Options";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbOrganization;
        private Label lblOrganization;
        private TextBox tbProject;
        private Label lblProject;
        private TextBox tbFeedId;
        private Label lblFeedId;
        private Label lblPat;
        private TextBox tbPat;
        private Button btnSave;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel;
        private ToolStripProgressBar toolStripProgressBar;
    }
}