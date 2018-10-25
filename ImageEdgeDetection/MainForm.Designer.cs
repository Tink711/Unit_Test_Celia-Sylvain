namespace ImageEdgeDetection
{
    partial class MainForm
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
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnOpenOriginal = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.grpChooseImage = new System.Windows.Forms.GroupBox();
            this.grpChooseFilter = new System.Windows.Forms.GroupBox();
            this.grpChooseEdgeDetection = new System.Windows.Forms.GroupBox();
            this.comboEdgeDetection = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.grpChooseImage.SuspendLayout();
            this.grpChooseFilter.SuspendLayout();
            this.grpChooseEdgeDetection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(12, 12);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(1077, 1054);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 13;
            this.picPreview.TabStop = false;
            this.picPreview.Click += new System.EventHandler(this.picPreview_Click);
            // 
            // btnOpenOriginal
            // 
            this.btnOpenOriginal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnOpenOriginal.Location = new System.Drawing.Point(16, 62);
            this.btnOpenOriginal.Name = "btnOpenOriginal";
            this.btnOpenOriginal.Size = new System.Drawing.Size(399, 70);
            this.btnOpenOriginal.TabIndex = 15;
            this.btnOpenOriginal.Text = "Load image";
            this.btnOpenOriginal.UseVisualStyleBackColor = true;
            this.btnOpenOriginal.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnSaveNewImage.Location = new System.Drawing.Point(16, 81);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(406, 77);
            this.btnSaveNewImage.TabIndex = 16;
            this.btnSaveNewImage.Text = "Save image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            this.btnSaveNewImage.Click += new System.EventHandler(this.btnSaveNewImage_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(16, 67);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(399, 54);
            this.cmbFilter.TabIndex = 20;
            this.cmbFilter.SelectedIndexChanged += new System.EventHandler(this.FilterChangedEventHandler);
            // 
            // grpChooseImage
            // 
            this.grpChooseImage.Controls.Add(this.btnOpenOriginal);
            this.grpChooseImage.Location = new System.Drawing.Point(1106, 12);
            this.grpChooseImage.Name = "grpChooseImage";
            this.grpChooseImage.Size = new System.Drawing.Size(430, 176);
            this.grpChooseImage.TabIndex = 21;
            this.grpChooseImage.TabStop = false;
            this.grpChooseImage.Text = "1. Choose image";
            // 
            // grpChooseFilter
            // 
            this.grpChooseFilter.Controls.Add(this.cmbFilter);
            this.grpChooseFilter.Location = new System.Drawing.Point(1106, 212);
            this.grpChooseFilter.Name = "grpChooseFilter";
            this.grpChooseFilter.Size = new System.Drawing.Size(430, 179);
            this.grpChooseFilter.TabIndex = 22;
            this.grpChooseFilter.TabStop = false;
            this.grpChooseFilter.Text = "2. Choose filter";
            // 
            // grpChooseEdgeDetection
            // 
            this.grpChooseEdgeDetection.Controls.Add(this.comboEdgeDetection);
            this.grpChooseEdgeDetection.Location = new System.Drawing.Point(1106, 428);
            this.grpChooseEdgeDetection.Name = "grpChooseEdgeDetection";
            this.grpChooseEdgeDetection.Size = new System.Drawing.Size(430, 194);
            this.grpChooseEdgeDetection.TabIndex = 23;
            this.grpChooseEdgeDetection.TabStop = false;
            this.grpChooseEdgeDetection.Text = "3. Choose edge detection";
            // 
            // comboEdgeDetection
            // 
            this.comboEdgeDetection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEdgeDetection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboEdgeDetection.FormattingEnabled = true;
            this.comboEdgeDetection.Location = new System.Drawing.Point(16, 69);
            this.comboEdgeDetection.Name = "comboEdgeDetection";
            this.comboEdgeDetection.Size = new System.Drawing.Size(399, 54);
            this.comboEdgeDetection.TabIndex = 24;
            this.comboEdgeDetection.SelectedIndexChanged += new System.EventHandler(this.EdgeDetectionChangedEventHandler);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSaveNewImage);
            this.groupBox1.Location = new System.Drawing.Point(1106, 628);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 203);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "4. Save";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1548, 1078);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpChooseEdgeDetection);
            this.Controls.Add(this.grpChooseFilter);
            this.Controls.Add(this.grpChooseImage);
            this.Controls.Add(this.picPreview);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image Edge Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.grpChooseImage.ResumeLayout(false);
            this.grpChooseFilter.ResumeLayout(false);
            this.grpChooseEdgeDetection.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnOpenOriginal;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.GroupBox grpChooseImage;
        private System.Windows.Forms.GroupBox grpChooseFilter;
        private System.Windows.Forms.GroupBox grpChooseEdgeDetection;
        private System.Windows.Forms.ComboBox comboEdgeDetection;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

