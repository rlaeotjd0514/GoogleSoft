namespace GOOGLESOFT
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
            // YoutubeAPIServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1172, 630);
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

        }

        #endregion

        private System.Windows.Forms.Panel YoutubFormMover;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox KeyWord;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel SearchResult;
    }
}