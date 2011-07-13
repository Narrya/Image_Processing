namespace Webcam
{
    partial class ImageStatistics
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnLimage = new System.Windows.Forms.Button();
            this.btnPimage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(367, 436);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loaded Image - Statistic";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(403, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 436);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Processed image - Statistic";
            // 
            // btnLimage
            // 
            this.btnLimage.Location = new System.Drawing.Point(111, 454);
            this.btnLimage.Name = "btnLimage";
            this.btnLimage.Size = new System.Drawing.Size(162, 25);
            this.btnLimage.TabIndex = 5;
            this.btnLimage.Text = "Loaded Image";
            this.btnLimage.UseVisualStyleBackColor = true;
            // 
            // btnPimage
            // 
            this.btnPimage.Location = new System.Drawing.Point(523, 454);
            this.btnPimage.Name = "btnPimage";
            this.btnPimage.Size = new System.Drawing.Size(162, 25);
            this.btnPimage.TabIndex = 6;
            this.btnPimage.Text = "Processed image";
            this.btnPimage.UseVisualStyleBackColor = true;
            // 
            // ImageStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.btnPimage);
            this.Controls.Add(this.btnLimage);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImageStatistics";
            this.Text = "ImageStatistics";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnLimage;
        private System.Windows.Forms.Button btnPimage;

    }
}