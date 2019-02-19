namespace GOOGLESOFT
{
    partial class SearchResultControl
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.Label();
            this.Thumbnail = new System.Windows.Forms.PictureBox();
            this.DownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.mp4DownloadButton = new System.Windows.Forms.Button();
            this.Mp3DownloadButton = new System.Windows.Forms.Button();
            this.intersource = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 13.5F, System.Drawing.FontStyle.Bold);
            this.Title.Location = new System.Drawing.Point(190, 8);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(94, 37);
            this.Title.TabIndex = 1;
            this.Title.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // Description
            // 
            this.Description.AutoSize = true;
            this.Description.Location = new System.Drawing.Point(194, 48);
            this.Description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(126, 18);
            this.Description.TabIndex = 3;
            this.Description.Text = "No Description";
            // 
            // Thumbnail
            // 
            this.Thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Thumbnail.Location = new System.Drawing.Point(11, 8);
            this.Thumbnail.Margin = new System.Windows.Forms.Padding(0);
            this.Thumbnail.Name = "Thumbnail";
            this.Thumbnail.Size = new System.Drawing.Size(175, 135);
            this.Thumbnail.TabIndex = 0;
            this.Thumbnail.TabStop = false;
            // 
            // DownloadProgressBar
            // 
            this.DownloadProgressBar.Location = new System.Drawing.Point(0, 0);
            this.DownloadProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.DownloadProgressBar.Name = "DownloadProgressBar";
            this.DownloadProgressBar.Size = new System.Drawing.Size(714, 152);
            this.DownloadProgressBar.TabIndex = 4;
            // 
            // mp4DownloadButton
            // 
            this.mp4DownloadButton.Location = new System.Drawing.Point(11, 108);
            this.mp4DownloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.mp4DownloadButton.Name = "mp4DownloadButton";
            this.mp4DownloadButton.Size = new System.Drawing.Size(61, 34);
            this.mp4DownloadButton.TabIndex = 5;
            this.mp4DownloadButton.Text = "Mp4";
            this.mp4DownloadButton.UseVisualStyleBackColor = true;
            this.mp4DownloadButton.Click += new System.EventHandler(this.mp4DownloadButton_Click);
            // 
            // Mp3DownloadButton
            // 
            this.Mp3DownloadButton.Location = new System.Drawing.Point(125, 108);
            this.Mp3DownloadButton.Margin = new System.Windows.Forms.Padding(4);
            this.Mp3DownloadButton.Name = "Mp3DownloadButton";
            this.Mp3DownloadButton.Size = new System.Drawing.Size(61, 34);
            this.Mp3DownloadButton.TabIndex = 5;
            this.Mp3DownloadButton.Text = "Mp3";
            this.Mp3DownloadButton.UseVisualStyleBackColor = true;
            this.Mp3DownloadButton.Click += new System.EventHandler(this.Mp3DownloadButton_Click);
            // 
            // intersource
            // 
            this.intersource.Location = new System.Drawing.Point(229, 110);
            this.intersource.Margin = new System.Windows.Forms.Padding(4);
            this.intersource.Name = "intersource";
            this.intersource.Size = new System.Drawing.Size(480, 28);
            this.intersource.TabIndex = 6;
            // 
            // SearchResultControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.intersource);
            this.Controls.Add(this.Mp3DownloadButton);
            this.Controls.Add(this.mp4DownloadButton);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Thumbnail);
            this.Controls.Add(this.DownloadProgressBar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SearchResultControl";
            this.Size = new System.Drawing.Size(714, 152);
            ((System.ComponentModel.ISupportInitialize)(this.Thumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Thumbnail;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Description;
        private System.Windows.Forms.ProgressBar DownloadProgressBar;
        private System.Windows.Forms.Button mp4DownloadButton;
        private System.Windows.Forms.Button Mp3DownloadButton;
        private System.Windows.Forms.TextBox intersource;
    }
}
