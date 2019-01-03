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
            this.panel1 = new System.Windows.Forms.Panel();
            this.KeyWord = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.YoutubFormMover.Size = new System.Drawing.Size(1341, 41);
            this.YoutubFormMover.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.KeyWord);
            this.panel1.Font = new System.Drawing.Font("맑은 고딕", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(24, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(510, 50);
            this.panel1.TabIndex = 1;
            // 
            // KeyWord
            // 
            this.KeyWord.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyWord.Font = new System.Drawing.Font("맑은 고딕", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.KeyWord.Location = new System.Drawing.Point(5, 5);
            this.KeyWord.Margin = new System.Windows.Forms.Padding(5);
            this.KeyWord.Multiline = true;
            this.KeyWord.Name = "KeyWord";
            this.KeyWord.Size = new System.Drawing.Size(500, 40);
            this.KeyWord.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.BackgroundImage = global::GOOGLESOFT.Properties.Resources.searchButton;
            this.SearchButton.FlatAppearance.BorderSize = 0;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(540, 85);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(80, 50);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::GOOGLESOFT.Properties.Resources.FormClose;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1301, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // YoutubeAPIServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1340, 695);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YoutubFormMover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "YoutubeAPIServiceForm";
            this.Text = "YoutubeAPIServiceForm";
            this.Load += new System.EventHandler(this.YoutubeAPIServiceForm_Load);
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
    }
}