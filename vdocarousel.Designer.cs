namespace vdomgr
{
    partial class vdocarousel
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
            this.flowLayoutPanelCarousel = new System.Windows.Forms.FlowLayoutPanel();
            this.PlayButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanelCarousel
            // 
            this.flowLayoutPanelCarousel.Location = new System.Drawing.Point(184, 12);
            this.flowLayoutPanelCarousel.Name = "flowLayoutPanelCarousel";
            this.flowLayoutPanelCarousel.Size = new System.Drawing.Size(688, 450);
            this.flowLayoutPanelCarousel.TabIndex = 0;
            // 
            // PlayButton
            // 
            this.PlayButton.Location = new System.Drawing.Point(441, 540);
            this.PlayButton.Name = "PlayButton";
            this.PlayButton.Size = new System.Drawing.Size(75, 23);
            this.PlayButton.TabIndex = 1;
            this.PlayButton.Text = "play";
            this.PlayButton.UseVisualStyleBackColor = true;
            this.PlayButton.Click += new System.EventHandler(this.PlayButton_Click);
            // 
            // vdocarousel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 667);
            this.Controls.Add(this.PlayButton);
            this.Controls.Add(this.flowLayoutPanelCarousel);
            this.Name = "vdocarousel";
            this.Text = "vdocarousel";
            this.Load += new System.EventHandler(this.vdocarousel_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCarousel;
        private System.Windows.Forms.Button PlayButton;
    }
}