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
            this.components = new System.ComponentModel.Container();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.viewPictureBox = new System.Windows.Forms.PictureBox();
            this.viewGroupBox = new System.Windows.Forms.GroupBox();
            this.viewGridCheckBox = new System.Windows.Forms.CheckBox();
            this.viewZoomTrackBarLabel = new System.Windows.Forms.Label();
            this.viewZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.gridPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.clearSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.resizeSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.heightSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.widthSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.sizegGridPropertiesSLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
            this.neighbourhoodCAPropertiesComboBoxLabel = new System.Windows.Forms.Label();
            this.neighbourhoodCAPropertiesComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.boundaryConditionPropertiesComboBoxLabel = new System.Windows.Forms.Label();
            this.boundaryConditionCAPropertiesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.randomPlacementButton = new System.Windows.Forms.Button();
            this.nucleonAmoutCAPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).BeginInit();
            this.gridPropertiesGroupBox.SuspendLayout();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSizeGridPropertiesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSizeGridPropertiesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.AutoSize = true;
            this.viewPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.viewPanel.Controls.Add(this.viewPictureBox);
            this.viewPanel.Location = new System.Drawing.Point(12, 3);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(562, 535);
            this.viewPanel.TabIndex = 0;
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(100, 100);
            this.viewPictureBox.TabIndex = 0;
            this.viewPictureBox.TabStop = false;
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGroupBox.Controls.Add(this.viewGridCheckBox);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBarLabel);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBar);
            this.viewGroupBox.Location = new System.Drawing.Point(580, 12);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(174, 91);
            this.viewGroupBox.TabIndex = 1;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
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
            // viewZoomTrackBarLabel
            // 
            this.viewZoomTrackBarLabel.AutoSize = true;
            this.viewZoomTrackBarLabel.Location = new System.Drawing.Point(12, 20);
            this.viewZoomTrackBarLabel.Name = "viewZoomTrackBarLabel";
            this.viewZoomTrackBarLabel.Size = new System.Drawing.Size(34, 13);
            this.viewZoomTrackBarLabel.TabIndex = 1;
            this.viewZoomTrackBarLabel.Text = "Zoom";
            // 
            // viewZoomTrackBar
            // 
            this.viewZoomTrackBar.Location = new System.Drawing.Point(53, 19);
            this.viewZoomTrackBar.Minimum = 1;
            this.viewZoomTrackBar.Name = "viewZoomTrackBar";
            this.viewZoomTrackBar.Size = new System.Drawing.Size(104, 45);
            this.viewZoomTrackBar.TabIndex = 0;
            this.viewZoomTrackBar.Value = 1;
            // 
            // gridPropertiesGroupBox
            // 
            this.gridPropertiesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gridPropertiesGroupBox.Controls.Add(this.heightSizeGridPropertiesNumericUpDown);
            this.gridPropertiesGroupBox.Controls.Add(this.widthSizeGridPropertiesNumericUpDown);
            this.gridPropertiesGroupBox.Controls.Add(this.clearSizeGridPropertiesButton);
            this.gridPropertiesGroupBox.Controls.Add(this.resizeSizeGridPropertiesButton);
            this.gridPropertiesGroupBox.Controls.Add(this.heightSizeGridPropertiesLabel);
            this.gridPropertiesGroupBox.Controls.Add(this.widthSizeGridPropertiesLabel);
            this.gridPropertiesGroupBox.Controls.Add(this.sizegGridPropertiesSLabel);
            this.gridPropertiesGroupBox.Location = new System.Drawing.Point(580, 109);
            this.gridPropertiesGroupBox.Name = "gridPropertiesGroupBox";
            this.gridPropertiesGroupBox.Size = new System.Drawing.Size(174, 117);
            this.gridPropertiesGroupBox.TabIndex = 2;
            this.gridPropertiesGroupBox.TabStop = false;
            this.gridPropertiesGroupBox.Text = "Grid Properties";
            // 
            // clearSizeGridPropertiesButton
            // 
            this.clearSizeGridPropertiesButton.Location = new System.Drawing.Point(93, 85);
            this.clearSizeGridPropertiesButton.Name = "clearSizeGridPropertiesButton";
            this.clearSizeGridPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.clearSizeGridPropertiesButton.TabIndex = 7;
            this.clearSizeGridPropertiesButton.Text = "Clear";
            this.clearSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            // 
            // resizeSizeGridPropertiesButton
            // 
            this.resizeSizeGridPropertiesButton.Location = new System.Drawing.Point(12, 85);
            this.resizeSizeGridPropertiesButton.Name = "resizeSizeGridPropertiesButton";
            this.resizeSizeGridPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.resizeSizeGridPropertiesButton.TabIndex = 6;
            this.resizeSizeGridPropertiesButton.Text = "Resize";
            this.resizeSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            // 
            // heightSizeGridPropertiesLabel
            // 
            this.heightSizeGridPropertiesLabel.AutoSize = true;
            this.heightSizeGridPropertiesLabel.Location = new System.Drawing.Point(18, 62);
            this.heightSizeGridPropertiesLabel.Name = "heightSizeGridPropertiesLabel";
            this.heightSizeGridPropertiesLabel.Size = new System.Drawing.Size(47, 13);
            this.heightSizeGridPropertiesLabel.TabIndex = 3;
            this.heightSizeGridPropertiesLabel.Text = "• Height";
            // 
            // widthSizeGridPropertiesLabel
            // 
            this.widthSizeGridPropertiesLabel.AutoSize = true;
            this.widthSizeGridPropertiesLabel.Location = new System.Drawing.Point(18, 40);
            this.widthSizeGridPropertiesLabel.Name = "widthSizeGridPropertiesLabel";
            this.widthSizeGridPropertiesLabel.Size = new System.Drawing.Size(44, 13);
            this.widthSizeGridPropertiesLabel.TabIndex = 2;
            this.widthSizeGridPropertiesLabel.Text = "• Width";
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
            // caGroupBox
            // 
            this.caGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caGroupBox.Controls.Add(this.nucleonAmoutCAPropertiesNumericUpDown);
            this.caGroupBox.Controls.Add(this.randomPlacementButton);
            this.caGroupBox.Controls.Add(this.label1);
            this.caGroupBox.Controls.Add(this.boundaryConditionPropertiesComboBoxLabel);
            this.caGroupBox.Controls.Add(this.boundaryConditionCAPropertiesComboBox);
            this.caGroupBox.Controls.Add(this.neighbourhoodCAPropertiesComboBoxLabel);
            this.caGroupBox.Controls.Add(this.neighbourhoodCAPropertiesComboBox);
            this.caGroupBox.Location = new System.Drawing.Point(580, 232);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Size = new System.Drawing.Size(174, 172);
            this.caGroupBox.TabIndex = 3;
            this.caGroupBox.TabStop = false;
            this.caGroupBox.Text = "Cellural Automata Properties";
            // 
            // neighbourhoodCAPropertiesComboBoxLabel
            // 
            this.neighbourhoodCAPropertiesComboBoxLabel.AutoSize = true;
            this.neighbourhoodCAPropertiesComboBoxLabel.Location = new System.Drawing.Point(6, 22);
            this.neighbourhoodCAPropertiesComboBoxLabel.Name = "neighbourhoodCAPropertiesComboBoxLabel";
            this.neighbourhoodCAPropertiesComboBoxLabel.Size = new System.Drawing.Size(83, 13);
            this.neighbourhoodCAPropertiesComboBoxLabel.TabIndex = 1;
            this.neighbourhoodCAPropertiesComboBoxLabel.Text = "Neighbourhood:";
            // 
            // neighbourhoodCAPropertiesComboBox
            // 
            this.neighbourhoodCAPropertiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighbourhoodCAPropertiesComboBox.FormattingEnabled = true;
            this.neighbourhoodCAPropertiesComboBox.Items.AddRange(new object[] {
            "Periodic"});
            this.neighbourhoodCAPropertiesComboBox.Location = new System.Drawing.Point(68, 38);
            this.neighbourhoodCAPropertiesComboBox.Name = "neighbourhoodCAPropertiesComboBox";
            this.neighbourhoodCAPropertiesComboBox.Size = new System.Drawing.Size(100, 21);
            this.neighbourhoodCAPropertiesComboBox.TabIndex = 0;
            // 
            // boundaryConditionPropertiesComboBoxLabel
            // 
            this.boundaryConditionPropertiesComboBoxLabel.AutoSize = true;
            this.boundaryConditionPropertiesComboBoxLabel.Location = new System.Drawing.Point(6, 62);
            this.boundaryConditionPropertiesComboBoxLabel.Name = "boundaryConditionPropertiesComboBoxLabel";
            this.boundaryConditionPropertiesComboBoxLabel.Size = new System.Drawing.Size(102, 13);
            this.boundaryConditionPropertiesComboBoxLabel.TabIndex = 3;
            this.boundaryConditionPropertiesComboBoxLabel.Text = "Boundary Condition:";
            // 
            // boundaryConditionCAPropertiesComboBox
            // 
            this.boundaryConditionCAPropertiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boundaryConditionCAPropertiesComboBox.FormattingEnabled = true;
            this.boundaryConditionCAPropertiesComboBox.Items.AddRange(new object[] {
            "von Neumann"});
            this.boundaryConditionCAPropertiesComboBox.Location = new System.Drawing.Point(68, 78);
            this.boundaryConditionCAPropertiesComboBox.Name = "boundaryConditionCAPropertiesComboBox";
            this.boundaryConditionCAPropertiesComboBox.Size = new System.Drawing.Size(100, 21);
            this.boundaryConditionCAPropertiesComboBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nucleon Amout:";
            // 
            // randomPlacementButton
            // 
            this.randomPlacementButton.Location = new System.Drawing.Point(9, 144);
            this.randomPlacementButton.Name = "randomPlacementButton";
            this.randomPlacementButton.Size = new System.Drawing.Size(159, 23);
            this.randomPlacementButton.TabIndex = 7;
            this.randomPlacementButton.Text = "Random nucleon placement";
            this.randomPlacementButton.UseVisualStyleBackColor = true;
            // 
            // nucleonAmoutCAPropertiesNumericUpDown
            // 
            this.nucleonAmoutCAPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 118);
            this.nucleonAmoutCAPropertiesNumericUpDown.Name = "nucleonAmoutCAPropertiesNumericUpDown";
            this.nucleonAmoutCAPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.nucleonAmoutCAPropertiesNumericUpDown.TabIndex = 8;
            // 
            // widthSizeGridPropertiesNumericUpDown
            // 
            this.widthSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 38);
            this.widthSizeGridPropertiesNumericUpDown.Name = "widthSizeGridPropertiesNumericUpDown";
            this.widthSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.widthSizeGridPropertiesNumericUpDown.TabIndex = 9;
            // 
            // heightSizeGridPropertiesNumericUpDown
            // 
            this.heightSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 60);
            this.heightSizeGridPropertiesNumericUpDown.Name = "heightSizeGridPropertiesNumericUpDown";
            this.heightSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.heightSizeGridPropertiesNumericUpDown.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 546);
            this.Controls.Add(this.caGroupBox);
            this.Controls.Add(this.viewGroupBox);
            this.Controls.Add(this.gridPropertiesGroupBox);
            this.Controls.Add(this.viewPanel);
            this.Menu = this.mainMenu;
            this.Name = "Form1";
            this.Text = "MultiscaleModeling";
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).EndInit();
            this.gridPropertiesGroupBox.ResumeLayout(false);
            this.gridPropertiesGroupBox.PerformLayout();
            this.caGroupBox.ResumeLayout(false);
            this.caGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSizeGridPropertiesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightSizeGridPropertiesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel viewPanel;
        private System.Windows.Forms.GroupBox viewGroupBox;
        private System.Windows.Forms.PictureBox viewPictureBox;
        private System.Windows.Forms.GroupBox gridPropertiesGroupBox;
        private System.Windows.Forms.CheckBox viewGridCheckBox;
        private System.Windows.Forms.Label viewZoomTrackBarLabel;
        private System.Windows.Forms.TrackBar viewZoomTrackBar;
        private System.Windows.Forms.Label heightSizeGridPropertiesLabel;
        private System.Windows.Forms.Label widthSizeGridPropertiesLabel;
        private System.Windows.Forms.Label sizegGridPropertiesSLabel;
        private System.Windows.Forms.Button resizeSizeGridPropertiesButton;
        private System.Windows.Forms.Button clearSizeGridPropertiesButton;
        private System.Windows.Forms.GroupBox caGroupBox;
        private System.Windows.Forms.Label neighbourhoodCAPropertiesComboBoxLabel;
        private System.Windows.Forms.ComboBox neighbourhoodCAPropertiesComboBox;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.Button randomPlacementButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label boundaryConditionPropertiesComboBoxLabel;
        private System.Windows.Forms.ComboBox boundaryConditionCAPropertiesComboBox;
        private System.Windows.Forms.NumericUpDown heightSizeGridPropertiesNumericUpDown;
        private System.Windows.Forms.NumericUpDown widthSizeGridPropertiesNumericUpDown;
        private System.Windows.Forms.NumericUpDown nucleonAmoutCAPropertiesNumericUpDown;
    }
}

