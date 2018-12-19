namespace GOOGLESOFT
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ServiceMenu = new System.Windows.Forms.Panel();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.HomeButton = new System.Windows.Forms.Button();
            this.TwitchTVButton = new System.Windows.Forms.Button();
            this.GoogleStorageButton = new System.Windows.Forms.Button();
            this.GoogleSheetButton = new System.Windows.Forms.Button();
            this.GoogleComputeButton = new System.Windows.Forms.Button();
            this.GmailButton = new System.Windows.Forms.Button();
            this.GoogleDriveButton = new System.Windows.Forms.Button();
            this.youtubeAPIButton = new System.Windows.Forms.Button();
            this.ServiceMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServiceMenu
            // 
            this.ServiceMenu.BackColor = System.Drawing.Color.White;
            this.ServiceMenu.Controls.Add(this.SidePanel);
            this.ServiceMenu.Controls.Add(this.HomeButton);
            this.ServiceMenu.Controls.Add(this.TwitchTVButton);
            this.ServiceMenu.Controls.Add(this.GoogleStorageButton);
            this.ServiceMenu.Controls.Add(this.GoogleSheetButton);
            this.ServiceMenu.Controls.Add(this.GoogleComputeButton);
            this.ServiceMenu.Controls.Add(this.GmailButton);
            this.ServiceMenu.Controls.Add(this.GoogleDriveButton);
            this.ServiceMenu.Controls.Add(this.youtubeAPIButton);
            this.ServiceMenu.Location = new System.Drawing.Point(0, 0);
            this.ServiceMenu.Margin = new System.Windows.Forms.Padding(0);
            this.ServiceMenu.Name = "ServiceMenu";
            this.ServiceMenu.Size = new System.Drawing.Size(205, 840);
            this.ServiceMenu.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Lime;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(23, 101);
            this.SidePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(205, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1158, 12);
            this.panel1.TabIndex = 0;
            // 
            // SettingButton
            // 
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Image = global::GOOGLESOFT.Properties.Resources.setting;
            this.SettingButton.Location = new System.Drawing.Point(1238, 15);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(57, 62);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.UseVisualStyleBackColor = true;
            // 
            // OffButton
            // 
            this.OffButton.BackColor = System.Drawing.Color.Gray;
            this.OffButton.FlatAppearance.BorderSize = 0;
            this.OffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffButton.Image = global::GOOGLESOFT.Properties.Resources.onoff2;
            this.OffButton.Location = new System.Drawing.Point(1302, 15);
            this.OffButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(57, 62);
            this.OffButton.TabIndex = 1;
            this.OffButton.UseVisualStyleBackColor = false;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // HomeButton
            // 
            this.HomeButton.FlatAppearance.BorderSize = 0;
            this.HomeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.Location = new System.Drawing.Point(0, 0);
            this.HomeButton.Margin = new System.Windows.Forms.Padding(0);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(205, 101);
            this.HomeButton.TabIndex = 1;
            this.HomeButton.Text = "HOME";
            this.HomeButton.UseVisualStyleBackColor = true;
            this.HomeButton.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // TwitchTVButton
            // 
            this.TwitchTVButton.FlatAppearance.BorderSize = 0;
            this.TwitchTVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TwitchTVButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TwitchTVButton.Image = ((System.Drawing.Image)(resources.GetObject("TwitchTVButton.Image")));
            this.TwitchTVButton.Location = new System.Drawing.Point(0, 709);
            this.TwitchTVButton.Margin = new System.Windows.Forms.Padding(0);
            this.TwitchTVButton.Name = "TwitchTVButton";
            this.TwitchTVButton.Size = new System.Drawing.Size(205, 131);
            this.TwitchTVButton.TabIndex = 0;
            this.TwitchTVButton.Text = "Twitch TV";
            this.TwitchTVButton.UseVisualStyleBackColor = true;
            this.TwitchTVButton.Click += new System.EventHandler(this.TwitchTVButton_Click);
            // 
            // GoogleStorageButton
            // 
            this.GoogleStorageButton.FlatAppearance.BorderSize = 0;
            this.GoogleStorageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleStorageButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleStorageButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleStorageButton.Image")));
            this.GoogleStorageButton.Location = new System.Drawing.Point(0, 608);
            this.GoogleStorageButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleStorageButton.Name = "GoogleStorageButton";
            this.GoogleStorageButton.Size = new System.Drawing.Size(205, 101);
            this.GoogleStorageButton.TabIndex = 0;
            this.GoogleStorageButton.Text = "Google Storage";
            this.GoogleStorageButton.UseVisualStyleBackColor = true;
            this.GoogleStorageButton.Click += new System.EventHandler(this.GoogleStorageButton_Click);
            // 
            // GoogleSheetButton
            // 
            this.GoogleSheetButton.FlatAppearance.BorderSize = 0;
            this.GoogleSheetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleSheetButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleSheetButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleSheetButton.Image")));
            this.GoogleSheetButton.Location = new System.Drawing.Point(0, 506);
            this.GoogleSheetButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleSheetButton.Name = "GoogleSheetButton";
            this.GoogleSheetButton.Size = new System.Drawing.Size(205, 101);
            this.GoogleSheetButton.TabIndex = 0;
            this.GoogleSheetButton.Text = "Google Sheet";
            this.GoogleSheetButton.UseVisualStyleBackColor = true;
            this.GoogleSheetButton.Click += new System.EventHandler(this.GoogleSheetButton_Click);
            // 
            // GoogleComputeButton
            // 
            this.GoogleComputeButton.FlatAppearance.BorderSize = 0;
            this.GoogleComputeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleComputeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleComputeButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleComputeButton.Image")));
            this.GoogleComputeButton.Location = new System.Drawing.Point(0, 405);
            this.GoogleComputeButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleComputeButton.Name = "GoogleComputeButton";
            this.GoogleComputeButton.Size = new System.Drawing.Size(205, 101);
            this.GoogleComputeButton.TabIndex = 0;
            this.GoogleComputeButton.Text = "Google Compute";
            this.GoogleComputeButton.UseVisualStyleBackColor = true;
            this.GoogleComputeButton.Click += new System.EventHandler(this.GoogleComputeButton_Click);
            // 
            // GmailButton
            // 
            this.GmailButton.FlatAppearance.BorderSize = 0;
            this.GmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GmailButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GmailButton.Image = ((System.Drawing.Image)(resources.GetObject("GmailButton.Image")));
            this.GmailButton.Location = new System.Drawing.Point(0, 304);
            this.GmailButton.Margin = new System.Windows.Forms.Padding(0);
            this.GmailButton.Name = "GmailButton";
            this.GmailButton.Size = new System.Drawing.Size(205, 101);
            this.GmailButton.TabIndex = 0;
            this.GmailButton.Text = "Gmail";
            this.GmailButton.UseVisualStyleBackColor = true;
            this.GmailButton.Click += new System.EventHandler(this.GmailButton_Click);
            // 
            // GoogleDriveButton
            // 
            this.GoogleDriveButton.FlatAppearance.BorderSize = 0;
            this.GoogleDriveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleDriveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GoogleDriveButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleDriveButton.Image")));
            this.GoogleDriveButton.Location = new System.Drawing.Point(0, 202);
            this.GoogleDriveButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleDriveButton.Name = "GoogleDriveButton";
            this.GoogleDriveButton.Size = new System.Drawing.Size(205, 101);
            this.GoogleDriveButton.TabIndex = 0;
            this.GoogleDriveButton.Text = "Google Drive";
            this.GoogleDriveButton.UseVisualStyleBackColor = true;
            this.GoogleDriveButton.Click += new System.EventHandler(this.GoogleDriveButton_Click);
            // 
            // youtubeAPIButton
            // 
            this.youtubeAPIButton.FlatAppearance.BorderSize = 0;
            this.youtubeAPIButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.youtubeAPIButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.youtubeAPIButton.Image = ((System.Drawing.Image)(resources.GetObject("youtubeAPIButton.Image")));
            this.youtubeAPIButton.Location = new System.Drawing.Point(0, 101);
            this.youtubeAPIButton.Margin = new System.Windows.Forms.Padding(0);
            this.youtubeAPIButton.Name = "youtubeAPIButton";
            this.youtubeAPIButton.Size = new System.Drawing.Size(205, 101);
            this.youtubeAPIButton.TabIndex = 0;
            this.youtubeAPIButton.Text = "Youtube API";
            this.youtubeAPIButton.UseVisualStyleBackColor = true;
            this.youtubeAPIButton.Click += new System.EventHandler(this.youtubeAPIButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1362, 844);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServiceMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "r";
            this.ServiceMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ServiceMenu;
        private System.Windows.Forms.Button HomeButton;
        private System.Windows.Forms.Button TwitchTVButton;
        private System.Windows.Forms.Button GoogleStorageButton;
        private System.Windows.Forms.Button GoogleSheetButton;
        private System.Windows.Forms.Button GoogleComputeButton;
        private System.Windows.Forms.Button GmailButton;
        private System.Windows.Forms.Button GoogleDriveButton;
        private System.Windows.Forms.Button youtubeAPIButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button OffButton;
        private System.Windows.Forms.Button SettingButton;
    }
}

