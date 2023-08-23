namespace SavingImageToDataBase
{
    partial class frmMain
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
            this.cmbIndices = new System.Windows.Forms.ComboBox();
            this.btnRetrieve = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.pcbPictures = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSaveToPc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPictures)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIndices
            // 
            this.cmbIndices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbIndices.FormattingEnabled = true;
            this.cmbIndices.Location = new System.Drawing.Point(118, 256);
            this.cmbIndices.Name = "cmbIndices";
            this.cmbIndices.Size = new System.Drawing.Size(166, 21);
            this.cmbIndices.TabIndex = 11;
            this.cmbIndices.Text = "Image indices";
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRetrieve.Location = new System.Drawing.Point(12, 250);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(100, 31);
            this.btnRetrieve.TabIndex = 10;
            this.btnRetrieve.Text = "Retrieve Picture";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClear.Location = new System.Drawing.Point(290, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 31);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear Picture";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // pcbPictures
            // 
            this.pcbPictures.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbPictures.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pcbPictures.Location = new System.Drawing.Point(12, 12);
            this.pcbPictures.Name = "pcbPictures";
            this.pcbPictures.Size = new System.Drawing.Size(590, 232);
            this.pcbPictures.TabIndex = 8;
            this.pcbPictures.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(396, 250);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 31);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Image";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.Location = new System.Drawing.Point(502, 250);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(100, 31);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select Image";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnSaveToPc
            // 
            this.btnSaveToPc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveToPc.Location = new System.Drawing.Point(12, 287);
            this.btnSaveToPc.Name = "btnSaveToPc";
            this.btnSaveToPc.Size = new System.Drawing.Size(590, 31);
            this.btnSaveToPc.TabIndex = 12;
            this.btnSaveToPc.Text = "Save Image To PC";
            this.btnSaveToPc.UseVisualStyleBackColor = true;
            this.btnSaveToPc.Click += new System.EventHandler(this.btnSaveToPc_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 327);
            this.Controls.Add(this.btnSaveToPc);
            this.Controls.Add(this.cmbIndices);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pcbPictures);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelect);
            this.MinimumSize = new System.Drawing.Size(630, 322);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPictures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIndices;
        private System.Windows.Forms.Button btnRetrieve;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.PictureBox pcbPictures;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnSaveToPc;
    }
}

