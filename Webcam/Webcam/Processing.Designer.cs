namespace Webcam
{
    partial class Processing
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
            this.btnOpen = new System.Windows.Forms.Button();
            this.pbChoose = new System.Windows.Forms.PictureBox();
            this.pBNew = new System.Windows.Forms.PictureBox();
            this.cBFilters = new System.Windows.Forms.ComboBox();
            this.btnSaveTransform = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBNew)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(158, 451);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(110, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Open Image";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // pbChoose
            // 
            this.pbChoose.Location = new System.Drawing.Point(20, 20);
            this.pbChoose.Name = "pbChoose";
            this.pbChoose.Size = new System.Drawing.Size(372, 425);
            this.pbChoose.TabIndex = 1;
            this.pbChoose.TabStop = false;
            // 
            // pBNew
            // 
            this.pBNew.Location = new System.Drawing.Point(398, 20);
            this.pBNew.Name = "pBNew";
            this.pBNew.Size = new System.Drawing.Size(358, 425);
            this.pBNew.TabIndex = 2;
            this.pBNew.TabStop = false;
            // 
            // cBFilters
            // 
            this.cBFilters.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cBFilters.FormattingEnabled = true;
            this.cBFilters.Items.AddRange(new object[] {
            "HSL_Filter",
            "Mediana",
            "Binarization",
            "Fourier Transformation",
            "FillHoles",
            "Grayscale",
            "Opening",
            "Closing",
            "Erosion",
            "Dilatation",
            "Edges"});
            this.cBFilters.Location = new System.Drawing.Point(398, 451);
            this.cBFilters.Name = "cBFilters";
            this.cBFilters.Size = new System.Drawing.Size(183, 21);
            this.cBFilters.TabIndex = 3;
            this.cBFilters.SelectedIndexChanged += new System.EventHandler(this.cBFilters_SelectedIndexChanged);
            // 
            // btnSaveTransform
            // 
            this.btnSaveTransform.Location = new System.Drawing.Point(606, 451);
            this.btnSaveTransform.Name = "btnSaveTransform";
            this.btnSaveTransform.Size = new System.Drawing.Size(150, 23);
            this.btnSaveTransform.TabIndex = 4;
            this.btnSaveTransform.Text = "Save Transform Image";
            this.btnSaveTransform.UseVisualStyleBackColor = true;
            this.btnSaveTransform.Click += new System.EventHandler(this.btnSaveTransform_Click);
            // 
            // Processing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 491);
            this.Controls.Add(this.btnSaveTransform);
            this.Controls.Add(this.cBFilters);
            this.Controls.Add(this.pBNew);
            this.Controls.Add(this.pbChoose);
            this.Controls.Add(this.btnOpen);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Processing";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Processing";
            ((System.ComponentModel.ISupportInitialize)(this.pbChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBNew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.PictureBox pbChoose;
        private System.Windows.Forms.PictureBox pBNew;
        private System.Windows.Forms.ComboBox cBFilters;
        private System.Windows.Forms.Button btnSaveTransform;
    }
}