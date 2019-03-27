namespace GOOGLESOFT
{
    partial class ComputeApiForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ModeSelection = new System.Windows.Forms.TrackBar();
            this.CreateInstanceButton = new System.Windows.Forms.Button();
            this.RunInstanceButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Blue;
            this.flowLayoutPanel1.Controls.Add(this.ModeSelection);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1043, 40);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // ModeSelection
            // 
            this.ModeSelection.Location = new System.Drawing.Point(3, 3);
            this.ModeSelection.Maximum = 1;
            this.ModeSelection.Name = "ModeSelection";
            this.ModeSelection.Size = new System.Drawing.Size(50, 45);
            this.ModeSelection.TabIndex = 1;
            // 
            // CreateInstanceButton
            // 
            this.CreateInstanceButton.Location = new System.Drawing.Point(25, 54);
            this.CreateInstanceButton.Name = "CreateInstanceButton";
            this.CreateInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.CreateInstanceButton.TabIndex = 1;
            this.CreateInstanceButton.Text = "Create I";
            this.CreateInstanceButton.UseVisualStyleBackColor = true;
            this.CreateInstanceButton.Click += new System.EventHandler(this.CreateInstanceButton_Click);
            // 
            // RunInstanceButton
            // 
            this.RunInstanceButton.Location = new System.Drawing.Point(25, 83);
            this.RunInstanceButton.Name = "RunInstanceButton";
            this.RunInstanceButton.Size = new System.Drawing.Size(75, 23);
            this.RunInstanceButton.TabIndex = 2;
            this.RunInstanceButton.Text = "Run I";
            this.RunInstanceButton.UseVisualStyleBackColor = true;
            // 
            // ComputeApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 625);
            this.Controls.Add(this.RunInstanceButton);
            this.Controls.Add(this.CreateInstanceButton);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ComputeApiForm";
            this.Text = "ComputeApiForm";
            this.Load += new System.EventHandler(this.ComputeApiForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ModeSelection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TrackBar ModeSelection;
        private System.Windows.Forms.Button CreateInstanceButton;
        private System.Windows.Forms.Button RunInstanceButton;
    }
}