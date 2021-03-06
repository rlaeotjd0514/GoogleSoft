﻿namespace GOOGLESOFT
{
    partial class YoutubeAPIServiceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YoutubeAPIServiceForm));
            this.YoutubFormMover = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SearchResult = new System.Windows.Forms.Panel();
            this.WebQueryAsync = new System.ComponentModel.BackgroundWorker();
            this.SearchPercent = new System.Windows.Forms.Label();
            this.downloadUrl = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.JsonResult = new System.Windows.Forms.RichTextBox();
            this.YoutubFormMover.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YoutubFormMover
            // 
            this.YoutubFormMover.BackColor = System.Drawing.Color.Red;
            this.YoutubFormMover.Controls.Add(this.button1);
            this.YoutubFormMover.Location = new System.Drawing.Point(0, 0);
            this.YoutubFormMover.Margin = new System.Windows.Forms.Padding(0);
            this.YoutubFormMover.Name = "YoutubFormMover";
            this.YoutubFormMover.Size = new System.Drawing.Size(1173, 33);
            this.YoutubFormMover.TabIndex = 0;
            this.YoutubFormMover.MouseDown += new System.Windows.Forms.MouseEventHandler(this.YoutubFormMover_MouseDown);
            this.YoutubFormMover.MouseMove += new System.Windows.Forms.MouseEventHandler(this.YoutubFormMover_MouseMove);
            this.YoutubFormMover.MouseUp += new System.Windows.Forms.MouseEventHandler(this.YoutubFormMover_MouseUp);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GOOGLESOFT.Properties.Resources.FormClose;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1138, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(35, 32);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.KeyWord);
            this.panel1.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(86, 84);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 40);
            this.panel1.TabIndex = 1;
            // 
            // KeyWord
            // 
            this.KeyWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyWord.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyWord.Location = new System.Drawing.Point(4, 4);
            this.KeyWord.Margin = new System.Windows.Forms.Padding(4);
            this.KeyWord.Multiline = true;
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(438, 32);
            this.KeyWord.TabIndex = 0;
            this.KeyWord.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyWord_KeyPress);
            this.KeyWord.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.KeyWord_PreviewKeyDown);
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::GOOGLESOFT.Properties.Resources.searchButton;
            this.SearchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(537, 84);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(70, 40);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::GOOGLESOFT.Properties.Resources.setting;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(43, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 40);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // SearchResult
            // 
            this.SearchResult.AutoScroll = true;
            this.SearchResult.Location = new System.Drawing.Point(43, 131);
            this.SearchResult.Name = "SearchResult";
            this.SearchResult.Size = new System.Drawing.Size(564, 499);
            this.SearchResult.TabIndex = 4;
            // 
            // WebQueryAsync
            // 
            this.WebQueryAsync.DoWork += new System.ComponentModel.DoWorkEventHandler(this.WebQueryAsync_DoWork);
            this.WebQueryAsync.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.WebQueryAsync_ProgressChanged);
            this.WebQueryAsync.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.WebQueryAsync_RunWorkerCompleted);
            // 
            // SearchPercent
            // 
            this.SearchPercent.AutoSize = true;
            this.SearchPercent.Location = new System.Drawing.Point(620, 137);
            this.SearchPercent.Name = "SearchPercent";
            this.SearchPercent.Size = new System.Drawing.Size(38, 12);
            this.SearchPercent.TabIndex = 6;
            this.SearchPercent.Text = "label2";
            // 
            // downloadUrl
            // 
            this.downloadUrl.Location = new System.Drawing.Point(805, 151);
            this.downloadUrl.Name = "downloadUrl";
            this.downloadUrl.Size = new System.Drawing.Size(235, 21);
            this.downloadUrl.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1046, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "download";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // JsonResult
            // 
            this.JsonResult.Location = new System.Drawing.Point(622, 178);
            this.JsonResult.Name = "JsonResult";
            this.JsonResult.Size = new System.Drawing.Size(538, 440);
            this.JsonResult.TabIndex = 9;
            this.JsonResult.Text = "";
            // 
            // YoutubeAPIServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 630);
            this.Controls.Add(this.JsonResult);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.downloadUrl);
            this.Controls.Add(this.SearchPercent);
            this.Controls.Add(this.SearchResult);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YoutubFormMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "YoutubeAPIServiceForm";
            this.Text = "YoutubeAPIServiceForm";
            this.YoutubFormMover.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel YoutubFormMover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SearchResult;
        private System.ComponentModel.BackgroundWorker WebQueryAsync;
        private System.Windows.Forms.Label SearchPercent;
        private System.Windows.Forms.TextBox downloadUrl;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.RichTextBox JsonResult;
    }
}