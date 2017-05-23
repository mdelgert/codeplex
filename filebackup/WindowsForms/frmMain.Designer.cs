namespace FileBackup
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnFileDialog = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnArchivePath = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArchivePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtArchivePassword = new System.Windows.Forms.TextBox();
            this.l_CompressProgress = new System.Windows.Forms.Label();
            this.pb_CompressProgress = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStorageAccount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStorageKey = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblSchedule = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.chkWindowsAzure = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(139, 58);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(304, 20);
            this.txtBackupPath.TabIndex = 3;
            this.txtBackupPath.Text = "C:\\codeplex\\Bible";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup Path:";
            // 
            // btnFileDialog
            // 
            this.btnFileDialog.Location = new System.Drawing.Point(450, 55);
            this.btnFileDialog.Name = "btnFileDialog";
            this.btnFileDialog.Size = new System.Drawing.Size(75, 23);
            this.btnFileDialog.TabIndex = 4;
            this.btnFileDialog.Text = "Select";
            this.btnFileDialog.UseVisualStyleBackColor = true;
            this.btnFileDialog.Click += new System.EventHandler(this.btnFileDialog_Click);
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(12, 185);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(513, 29);
            this.btnBackup.TabIndex = 8;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnArchivePath
            // 
            this.btnArchivePath.Location = new System.Drawing.Point(449, 81);
            this.btnArchivePath.Name = "btnArchivePath";
            this.btnArchivePath.Size = new System.Drawing.Size(75, 23);
            this.btnArchivePath.TabIndex = 6;
            this.btnArchivePath.Text = "Select";
            this.btnArchivePath.UseVisualStyleBackColor = true;
            this.btnArchivePath.Click += new System.EventHandler(this.btnArchivePath_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Archive Path:";
            // 
            // txtArchivePath
            // 
            this.txtArchivePath.Location = new System.Drawing.Point(139, 84);
            this.txtArchivePath.Name = "txtArchivePath";
            this.txtArchivePath.Size = new System.Drawing.Size(304, 20);
            this.txtArchivePath.TabIndex = 5;
            this.txtArchivePath.Text = "D:\\Test.7z";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Archive Password:";
            // 
            // txtArchivePassword
            // 
            this.txtArchivePassword.Location = new System.Drawing.Point(139, 110);
            this.txtArchivePassword.Name = "txtArchivePassword";
            this.txtArchivePassword.Size = new System.Drawing.Size(386, 20);
            this.txtArchivePassword.TabIndex = 7;
            this.txtArchivePassword.Text = "Password";
            // 
            // l_CompressProgress
            // 
            this.l_CompressProgress.AutoSize = true;
            this.l_CompressProgress.Location = new System.Drawing.Point(9, 217);
            this.l_CompressProgress.Name = "l_CompressProgress";
            this.l_CompressProgress.Size = new System.Drawing.Size(48, 13);
            this.l_CompressProgress.TabIndex = 9;
            this.l_CompressProgress.Text = "Progress";
            // 
            // pb_CompressProgress
            // 
            this.pb_CompressProgress.Location = new System.Drawing.Point(12, 233);
            this.pb_CompressProgress.Name = "pb_CompressProgress";
            this.pb_CompressProgress.Size = new System.Drawing.Size(512, 25);
            this.pb_CompressProgress.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Storage Account Name:";
            // 
            // txtStorageAccount
            // 
            this.txtStorageAccount.Location = new System.Drawing.Point(139, 6);
            this.txtStorageAccount.Name = "txtStorageAccount";
            this.txtStorageAccount.Size = new System.Drawing.Size(386, 20);
            this.txtStorageAccount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Storage Account Key:";
            // 
            // txtStorageKey
            // 
            this.txtStorageKey.Location = new System.Drawing.Point(139, 32);
            this.txtStorageKey.Name = "txtStorageKey";
            this.txtStorageKey.Size = new System.Drawing.Size(386, 20);
            this.txtStorageKey.TabIndex = 2;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(104, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "Exit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Open";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(9, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(515, 29);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close Window";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblSchedule
            // 
            this.lblSchedule.AutoSize = true;
            this.lblSchedule.Location = new System.Drawing.Point(16, 162);
            this.lblSchedule.Name = "lblSchedule";
            this.lblSchedule.Size = new System.Drawing.Size(58, 13);
            this.lblSchedule.TabIndex = 17;
            this.lblSchedule.Text = "Scheduler:";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(139, 159);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(181, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "hh:mm:tt";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(326, 159);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(198, 20);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "File Only:";
            // 
            // chkWindowsAzure
            // 
            this.chkWindowsAzure.AutoSize = true;
            this.chkWindowsAzure.Checked = true;
            this.chkWindowsAzure.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWindowsAzure.Location = new System.Drawing.Point(139, 137);
            this.chkWindowsAzure.Name = "chkWindowsAzure";
            this.chkWindowsAzure.Size = new System.Drawing.Size(154, 17);
            this.chkWindowsAzure.TabIndex = 21;
            this.chkWindowsAzure.Text = "Backup to windows azure?";
            this.chkWindowsAzure.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 321);
            this.Controls.Add(this.chkWindowsAzure);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblSchedule);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtStorageKey);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStorageAccount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb_CompressProgress);
            this.Controls.Add(this.l_CompressProgress);
            this.Controls.Add(this.txtArchivePassword);
            this.Controls.Add(this.btnArchivePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtArchivePath);
            this.Controls.Add(this.btnFileDialog);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBackupPath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Backup";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnFileDialog;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnArchivePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArchivePath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtArchivePassword;
        private System.Windows.Forms.Label l_CompressProgress;
        private System.Windows.Forms.ProgressBar pb_CompressProgress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStorageAccount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStorageKey;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblSchedule;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkWindowsAzure;
    }
}