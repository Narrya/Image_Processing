namespace Webcam
{
    partial class Webcam
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
            this.btnList = new System.Windows.Forms.Button();
            this.btnCStart = new System.Windows.Forms.Button();
            this.pbCamera = new System.Windows.Forms.PictureBox();
            this.btnCStop = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageProcessingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageStatisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(110, 452);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(109, 27);
            this.btnList.TabIndex = 0;
            this.btnList.Text = "List Camera";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnCStart
            // 
            this.btnCStart.Location = new System.Drawing.Point(247, 452);
            this.btnCStart.Name = "btnCStart";
            this.btnCStart.Size = new System.Drawing.Size(109, 27);
            this.btnCStart.TabIndex = 1;
            this.btnCStart.Text = "Camera Start";
            this.btnCStart.UseVisualStyleBackColor = true;
            this.btnCStart.Click += new System.EventHandler(this.btnCStart_Click);
            // 
            // pbCamera
            // 
            this.pbCamera.Location = new System.Drawing.Point(12, 39);
            this.pbCamera.Name = "pbCamera";
            this.pbCamera.Size = new System.Drawing.Size(758, 396);
            this.pbCamera.TabIndex = 2;
            this.pbCamera.TabStop = false;
            // 
            // btnCStop
            // 
            this.btnCStop.Location = new System.Drawing.Point(380, 452);
            this.btnCStop.Name = "btnCStop";
            this.btnCStop.Size = new System.Drawing.Size(109, 27);
            this.btnCStop.TabIndex = 3;
            this.btnCStop.Text = "Camera Stop";
            this.btnCStop.UseVisualStyleBackColor = true;
            this.btnCStop.Click += new System.EventHandler(this.btnCStop_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(507, 452);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(109, 27);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save picture";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageProcessingToolStripMenuItem,
            this.imageStatisticsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(782, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageProcessingToolStripMenuItem
            // 
            this.imageProcessingToolStripMenuItem.Name = "imageProcessingToolStripMenuItem";
            this.imageProcessingToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.imageProcessingToolStripMenuItem.Text = "Image processing";
            this.imageProcessingToolStripMenuItem.Click += new System.EventHandler(this.imageProcessingToolStripMenuItem_Click);
            // 
            // imageStatisticsToolStripMenuItem
            // 
            this.imageStatisticsToolStripMenuItem.Name = "imageStatisticsToolStripMenuItem";
            this.imageStatisticsToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.imageStatisticsToolStripMenuItem.Text = "ImageStatistics";
            this.imageStatisticsToolStripMenuItem.Click += new System.EventHandler(this.imageStatisticsToolStripMenuItem_Click);
            // 
            // Webcam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCStop);
            this.Controls.Add(this.pbCamera);
            this.Controls.Add(this.btnCStart);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Webcam";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Webcam";
            ((System.ComponentModel.ISupportInitialize)(this.pbCamera)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnCStart;
        private System.Windows.Forms.PictureBox pbCamera;
        private System.Windows.Forms.Button btnCStop;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageProcessingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageStatisticsToolStripMenuItem;
    }
}

