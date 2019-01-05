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
            this.HomeButton = new System.Windows.Forms.Button();
            this.TwitchTVButton = new System.Windows.Forms.Button();
            this.GoogleStorageButton = new System.Windows.Forms.Button();
            this.GoogleSheetButton = new System.Windows.Forms.Button();
            this.GoogleComputeButton = new System.Windows.Forms.Button();
            this.GmailButton = new System.Windows.Forms.Button();
            this.GoogleDriveButton = new System.Windows.Forms.Button();
            this.youtubeAPIButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.OffButton = new System.Windows.Forms.Button();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.UserLoginButton = new System.Windows.Forms.Button();
            this.InnerViewButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginBoxPassword = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LoginBoxID = new System.Windows.Forms.TextBox();
            this.GoogleLoginButton = new System.Windows.Forms.Button();
            this.GoogleInnerViewPanel = new System.Windows.Forms.Panel();
            this.AccessTokenTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ApiLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceMenu.SuspendLayout();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GoogleInnerViewPanel.SuspendLayout();
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
            this.ServiceMenu.Size = new System.Drawing.Size(179, 672);
            this.ServiceMenu.TabIndex = 0;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Lime;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(20, 81);
            this.SidePanel.TabIndex = 1;
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
            this.HomeButton.Size = new System.Drawing.Size(179, 81);
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
            this.TwitchTVButton.Location = new System.Drawing.Point(0, 567);
            this.TwitchTVButton.Margin = new System.Windows.Forms.Padding(0);
            this.TwitchTVButton.Name = "TwitchTVButton";
            this.TwitchTVButton.Size = new System.Drawing.Size(179, 105);
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
            this.GoogleStorageButton.Location = new System.Drawing.Point(0, 486);
            this.GoogleStorageButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleStorageButton.Name = "GoogleStorageButton";
            this.GoogleStorageButton.Size = new System.Drawing.Size(179, 81);
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
            this.GoogleSheetButton.Location = new System.Drawing.Point(0, 405);
            this.GoogleSheetButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleSheetButton.Name = "GoogleSheetButton";
            this.GoogleSheetButton.Size = new System.Drawing.Size(179, 81);
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
            this.GoogleComputeButton.Location = new System.Drawing.Point(0, 324);
            this.GoogleComputeButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleComputeButton.Name = "GoogleComputeButton";
            this.GoogleComputeButton.Size = new System.Drawing.Size(179, 81);
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
            this.GmailButton.Location = new System.Drawing.Point(0, 243);
            this.GmailButton.Margin = new System.Windows.Forms.Padding(0);
            this.GmailButton.Name = "GmailButton";
            this.GmailButton.Size = new System.Drawing.Size(179, 81);
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
            this.GoogleDriveButton.Location = new System.Drawing.Point(0, 162);
            this.GoogleDriveButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleDriveButton.Name = "GoogleDriveButton";
            this.GoogleDriveButton.Size = new System.Drawing.Size(179, 81);
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
            this.youtubeAPIButton.Location = new System.Drawing.Point(0, 81);
            this.youtubeAPIButton.Margin = new System.Windows.Forms.Padding(0);
            this.youtubeAPIButton.Name = "youtubeAPIButton";
            this.youtubeAPIButton.Size = new System.Drawing.Size(179, 81);
            this.youtubeAPIButton.TabIndex = 0;
            this.youtubeAPIButton.Text = "Youtube API";
            this.youtubeAPIButton.UseVisualStyleBackColor = true;
            this.youtubeAPIButton.Click += new System.EventHandler(this.youtubeAPIButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(179, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 10);
            this.panel1.TabIndex = 0;
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.FlatAppearance.BorderSize = 0;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Image = global::GOOGLESOFT.Properties.Resources.setting;
            this.SettingButton.Location = new System.Drawing.Point(1084, 13);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(50, 50);
            this.SettingButton.TabIndex = 2;
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // OffButton
            // 
            this.OffButton.BackColor = System.Drawing.Color.Transparent;
            this.OffButton.FlatAppearance.BorderSize = 0;
            this.OffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OffButton.Image = global::GOOGLESOFT.Properties.Resources.onoff2;
            this.OffButton.Location = new System.Drawing.Point(1139, 12);
            this.OffButton.Name = "OffButton";
            this.OffButton.Size = new System.Drawing.Size(50, 50);
            this.OffButton.TabIndex = 1;
            this.OffButton.UseVisualStyleBackColor = false;
            this.OffButton.Click += new System.EventHandler(this.OffButton_Click);
            // 
            // LoginPanel
            // 
            this.LoginPanel.AllowDrop = true;
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LoginPanel.Controls.Add(this.UserLoginButton);
            this.LoginPanel.Controls.Add(this.InnerViewButton);
            this.LoginPanel.Controls.Add(this.panel3);
            this.LoginPanel.Controls.Add(this.panel2);
            this.LoginPanel.Controls.Add(this.pictureBox2);
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.LoginBoxPassword);
            this.LoginPanel.Controls.Add(this.textBox1);
            this.LoginPanel.Controls.Add(this.LoginBoxID);
            this.LoginPanel.Location = new System.Drawing.Point(204, 26);
            this.LoginPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(386, 216);
            this.LoginPanel.TabIndex = 3;
            this.LoginPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseDown);
            this.LoginPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseMove);
            this.LoginPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LoginPanel_MouseUp);
            // 
            // UserLoginButton
            // 
            this.UserLoginButton.BackColor = System.Drawing.Color.Red;
            this.UserLoginButton.FlatAppearance.BorderSize = 0;
            this.UserLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLoginButton.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.UserLoginButton.Location = new System.Drawing.Point(195, 166);
            this.UserLoginButton.Name = "UserLoginButton";
            this.UserLoginButton.Size = new System.Drawing.Size(173, 39);
            this.UserLoginButton.TabIndex = 8;
            this.UserLoginButton.Text = "USER LOGIN";
            this.UserLoginButton.UseVisualStyleBackColor = false;
            this.UserLoginButton.Click += new System.EventHandler(this.UserLoginButton_Click);
            // 
            // InnerViewButton
            // 
            this.InnerViewButton.FlatAppearance.BorderSize = 0;
            this.InnerViewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InnerViewButton.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.InnerViewButton.Image = global::GOOGLESOFT.Properties.Resources.downarrow;
            this.InnerViewButton.Location = new System.Drawing.Point(4, 155);
            this.InnerViewButton.Name = "InnerViewButton";
            this.InnerViewButton.Size = new System.Drawing.Size(50, 50);
            this.InnerViewButton.TabIndex = 7;
            this.InnerViewButton.UseVisualStyleBackColor = true;
            this.InnerViewButton.Click += new System.EventHandler(this.InnerViewButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(15, 144);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 2);
            this.panel3.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(15, 99);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(318, 2);
            this.panel2.TabIndex = 5;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::GOOGLESOFT.Properties.Resources.lock5050;
            this.pictureBox2.Location = new System.Drawing.Point(15, 106);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 40);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GOOGLESOFT.Properties.Resources.little_human;
            this.pictureBox1.Location = new System.Drawing.Point(15, 61);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 40);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LoginBoxPassword
            // 
            this.LoginBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBoxPassword.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBoxPassword.Location = new System.Drawing.Point(64, 111);
            this.LoginBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBoxPassword.Name = "LoginBoxPassword";
            this.LoginBoxPassword.Size = new System.Drawing.Size(275, 36);
            this.LoginBoxPassword.TabIndex = 2;
            this.LoginBoxPassword.Text = "Password";
            this.LoginBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBoxPassword.Leave += new System.EventHandler(this.LoginBoxPassword_Leave);
            this.LoginBoxPassword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginBoxPassword_MouseDown);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(0, 11);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(386, 36);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Google Login";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LoginBoxID
            // 
            this.LoginBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginBoxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginBoxID.Font = new System.Drawing.Font("맑은 고딕", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.LoginBoxID.Location = new System.Drawing.Point(64, 66);
            this.LoginBoxID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginBoxID.Name = "LoginBoxID";
            this.LoginBoxID.Size = new System.Drawing.Size(275, 36);
            this.LoginBoxID.TabIndex = 0;
            this.LoginBoxID.Text = "ID";
            this.LoginBoxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoginBoxID.Leave += new System.EventHandler(this.LoginBoxID_Leave);
            this.LoginBoxID.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LoginBoxID_MouseDown);
            // 
            // GoogleLoginButton
            // 
            this.GoogleLoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GoogleLoginButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.GoogleLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.GoogleLoginButton.FlatAppearance.BorderSize = 5;
            this.GoogleLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.GoogleLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GoogleLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GoogleLoginButton.Font = new System.Drawing.Font("맑은 고딕", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.GoogleLoginButton.ForeColor = System.Drawing.Color.White;
            this.GoogleLoginButton.Location = new System.Drawing.Point(847, 13);
            this.GoogleLoginButton.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleLoginButton.Name = "GoogleLoginButton";
            this.GoogleLoginButton.Size = new System.Drawing.Size(234, 56);
            this.GoogleLoginButton.TabIndex = 4;
            this.GoogleLoginButton.Text = "API LOGIN";
            this.GoogleLoginButton.UseVisualStyleBackColor = false;
            this.GoogleLoginButton.Click += new System.EventHandler(this.GoogleLoginButton_Click);
            // 
            // GoogleInnerViewPanel
            // 
            this.GoogleInnerViewPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GoogleInnerViewPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GoogleInnerViewPanel.Controls.Add(this.AccessTokenTextBox);
            this.GoogleInnerViewPanel.Controls.Add(this.label2);
            this.GoogleInnerViewPanel.Controls.Add(this.ApiLabel);
            this.GoogleInnerViewPanel.Controls.Add(this.label1);
            this.GoogleInnerViewPanel.Location = new System.Drawing.Point(204, 242);
            this.GoogleInnerViewPanel.Margin = new System.Windows.Forms.Padding(0);
            this.GoogleInnerViewPanel.Name = "GoogleInnerViewPanel";
            this.GoogleInnerViewPanel.Size = new System.Drawing.Size(386, 260);
            this.GoogleInnerViewPanel.TabIndex = 4;
            this.GoogleInnerViewPanel.Visible = false;
            this.GoogleInnerViewPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.GoogleInnerViewPanel_Paint);
            // 
            // AccessTokenTextBox
            // 
            this.AccessTokenTextBox.Location = new System.Drawing.Point(20, 116);
            this.AccessTokenTextBox.Name = "AccessTokenTextBox";
            this.AccessTokenTextBox.Size = new System.Drawing.Size(348, 21);
            this.AccessTokenTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "AccessToken";
            // 
            // ApiLabel
            // 
            this.ApiLabel.AutoSize = true;
            this.ApiLabel.Font = new System.Drawing.Font("돋움", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ApiLabel.Location = new System.Drawing.Point(17, 55);
            this.ApiLabel.Name = "ApiLabel";
            this.ApiLabel.Size = new System.Drawing.Size(0, 13);
            this.ApiLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "API KEY";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = global::GOOGLESOFT.Properties.Resources.Makise_Kurisu_background1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1192, 675);
            this.Controls.Add(this.GoogleInnerViewPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.OffButton);
            this.Controls.Add(this.GoogleLoginButton);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ServiceMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "r";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ServiceMenu.ResumeLayout(false);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GoogleInnerViewPanel.ResumeLayout(false);
            this.GoogleInnerViewPanel.PerformLayout();
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
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox LoginBoxID;
        private System.Windows.Forms.TextBox LoginBoxPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button GoogleLoginButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button InnerViewButton;
        private System.Windows.Forms.Panel GoogleInnerViewPanel;
        private System.Windows.Forms.Label ApiLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button UserLoginButton;
        private System.Windows.Forms.TextBox AccessTokenTextBox;
        private System.Windows.Forms.Label label2;
    }
}

