namespace GOOGLESOFT
{
    partial class GoogleLoginForm
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
            this.LoginBrowser = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // LoginBrowser
            // 
            this.LoginBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginBrowser.Location = new System.Drawing.Point(0, 0);
            this.LoginBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.LoginBrowser.Name = "LoginBrowser";
            this.LoginBrowser.Size = new System.Drawing.Size(401, 563);
            this.LoginBrowser.TabIndex = 0;
            this.LoginBrowser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.LoginBrowser_DocumentCompleted);
            // 
            // GoogleLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 563);
            this.Controls.Add(this.LoginBrowser);
            this.Name = "GoogleLoginForm";
            this.Text = "GoogleLoginForm";
            this.Load += new System.EventHandler(this.GoogleLoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser LoginBrowser;
    }
}