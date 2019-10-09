namespace MultiscaleModeling
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewPictureBox = new System.Windows.Forms.PictureBox();
            this.viewZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.viewZoomTrackBarLabel = new System.Windows.Forms.Label();
            this.viewGridCheckBox = new System.Windows.Forms.CheckBox();
            this.sizegGridPropertiesSLabel = new System.Windows.Forms.Label();
            this.widthSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.heightSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.viewPictureBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(550, 540);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.viewGridCheckBox);
            this.groupBox1.Controls.Add(this.viewZoomTrackBarLabel);
            this.groupBox1.Controls.Add(this.viewZoomTrackBar);
            this.groupBox1.Location = new System.Drawing.Point(573, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 117);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.heightSizeGridPropertiesLabel);
            this.groupBox2.Controls.Add(this.widthSizeGridPropertiesLabel);
            this.groupBox2.Controls.Add(this.sizegGridPropertiesSLabel);
            this.groupBox2.Location = new System.Drawing.Point(573, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(174, 171);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Grid Properties";
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(547, 537);
            this.viewPictureBox.TabIndex = 0;
            this.viewPictureBox.TabStop = false;
            // 
            // viewZoomTrackBar
            // 
            this.viewZoomTrackBar.Location = new System.Drawing.Point(53, 19);
            this.viewZoomTrackBar.Name = "viewZoomTrackBar";
            this.viewZoomTrackBar.Size = new System.Drawing.Size(104, 45);
            this.viewZoomTrackBar.TabIndex = 0;
            // 
            // viewZoomTrackBarLabel
            // 
            this.viewZoomTrackBarLabel.AutoSize = true;
            this.viewZoomTrackBarLabel.Location = new System.Drawing.Point(12, 20);
            this.viewZoomTrackBarLabel.Name = "viewZoomTrackBarLabel";
            this.viewZoomTrackBarLabel.Size = new System.Drawing.Size(34, 13);
            this.viewZoomTrackBarLabel.TabIndex = 1;
            this.viewZoomTrackBarLabel.Text = "Zoom";
            // 
            // viewGridCheckBox
            // 
            this.viewGridCheckBox.AllowDrop = true;
            this.viewGridCheckBox.AutoSize = true;
            this.viewGridCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewGridCheckBox.Location = new System.Drawing.Point(12, 70);
            this.viewGridCheckBox.Name = "viewGridCheckBox";
            this.viewGridCheckBox.Size = new System.Drawing.Size(145, 17);
            this.viewGridCheckBox.TabIndex = 2;
            this.viewGridCheckBox.Text = "Show Grid Between Cells";
            this.viewGridCheckBox.UseVisualStyleBackColor = true;
            // 
            // sizegGridPropertiesSLabel
            // 
            this.sizegGridPropertiesSLabel.AutoSize = true;
            this.sizegGridPropertiesSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizegGridPropertiesSLabel.Location = new System.Drawing.Point(9, 16);
            this.sizegGridPropertiesSLabel.Name = "sizegGridPropertiesSLabel";
            this.sizegGridPropertiesSLabel.Size = new System.Drawing.Size(39, 15);
            this.sizegGridPropertiesSLabel.TabIndex = 0;
            this.sizegGridPropertiesSLabel.Text = "Size:";
            // 
            // widthSizeGridPropertiesLabel
            // 
            this.widthSizeGridPropertiesLabel.AutoSize = true;
            this.widthSizeGridPropertiesLabel.Location = new System.Drawing.Point(14, 40);
            this.widthSizeGridPropertiesLabel.Name = "widthSizeGridPropertiesLabel";
            this.widthSizeGridPropertiesLabel.Size = new System.Drawing.Size(44, 13);
            this.widthSizeGridPropertiesLabel.TabIndex = 2;
            this.widthSizeGridPropertiesLabel.Text = "• Width";
            // 
            // heightSizeGridPropertiesLabel
            // 
            this.heightSizeGridPropertiesLabel.AutoSize = true;
            this.heightSizeGridPropertiesLabel.Location = new System.Drawing.Point(14, 62);
            this.heightSizeGridPropertiesLabel.Name = "heightSizeGridPropertiesLabel";
            this.heightSizeGridPropertiesLabel.Size = new System.Drawing.Size(47, 13);
            this.heightSizeGridPropertiesLabel.TabIndex = 3;
            this.heightSizeGridPropertiesLabel.Text = "• Height";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 561);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox viewPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox viewGridCheckBox;
        private System.Windows.Forms.Label viewZoomTrackBarLabel;
        private System.Windows.Forms.TrackBar viewZoomTrackBar;
        private System.Windows.Forms.Label heightSizeGridPropertiesLabel;
        private System.Windows.Forms.Label widthSizeGridPropertiesLabel;
        private System.Windows.Forms.Label sizegGridPropertiesSLabel;
    }
}

