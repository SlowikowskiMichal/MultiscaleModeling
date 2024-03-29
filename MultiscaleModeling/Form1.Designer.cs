﻿namespace MultiscaleModeling
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
            this.energyNeighborhoodRadioButton = new System.Windows.Forms.RadioButton();
            this.energyViewPropertiesRadioButton = new System.Windows.Forms.RadioButton();
            this.grainViewPropertiesRadioButton = new System.Windows.Forms.RadioButton();
            this.viewGridCheckBox = new System.Windows.Forms.CheckBox();
            this.viewZoomTrackBarLabel = new System.Windows.Forms.Label();
            this.viewZoomTrackBar = new System.Windows.Forms.TrackBar();
            this.gridPropertiesGroupBox = new System.Windows.Forms.GroupBox();
            this.heightSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clearSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.resizeSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.heightSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.widthSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.sizegGridPropertiesSLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
            this.probabilityCAPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.probabilityCAPropertiesLabel = new System.Windows.Forms.Label();
            this.nucleonAmoutCAPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.randomPlacementButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boundaryConditionPropertiesComboBoxLabel = new System.Windows.Forms.Label();
            this.boundaryConditionCAPropertiesComboBox = new System.Windows.Forms.ComboBox();
            this.neighbourhoodCAPropertiesComboBoxLabel = new System.Windows.Forms.Label();
            this.neighbourhoodCAPropertiesComboBox = new System.Windows.Forms.ComboBox();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.runCAExecutionButton = new System.Windows.Forms.Button();
            this.stopCAExecutionButton = new System.Windows.Forms.Button();
            this.caSimulationCAPropertiesLabel = new System.Windows.Forms.Label();
            this.executionGroupBox = new System.Windows.Forms.GroupBox();
            this.caExecutionProgressBar = new System.Windows.Forms.ProgressBar();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.openFileMenuItem = new System.Windows.Forms.MenuItem();
            this.jsonOpenFileMenuItem = new System.Windows.Forms.MenuItem();
            this.bitmapOpenFileMenuItem = new System.Windows.Forms.MenuItem();
            this.saveFileMenuItem = new System.Windows.Forms.MenuItem();
            this.jsonSaveFileMenuItem = new System.Windows.Forms.MenuItem();
            this.bitmapSaveFileMenuItem = new System.Windows.Forms.MenuItem();
            this.menuTabControl = new System.Windows.Forms.TabControl();
            this.propertiesTabPage = new System.Windows.Forms.TabPage();
            this.executionTabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.amountInsclusionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.amountInclusionsLabel = new System.Windows.Forms.Label();
            this.valueInclusionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.valueInclusionsLabel = new System.Windows.Forms.Label();
            this.typeInclusionsComboBox = new System.Windows.Forms.ComboBox();
            this.tyoeInclusionsLabel = new System.Windows.Forms.Label();
            this.generateInclusionsButton = new System.Windows.Forms.Button();
            this.substructureTabPage = new System.Windows.Forms.TabPage();
            this.grainBoundariesGroupBox = new System.Windows.Forms.GroupBox();
            this.gbPercentTextBox = new System.Windows.Forms.TextBox();
            this.sizePropertiesGrainBoundariesLabel = new System.Windows.Forms.Label();
            this.selectionModePropertiesGrainBoundariesLabel = new System.Windows.Forms.Label();
            this.gbPercentPropertiesGrainBoundariesLabel = new System.Windows.Forms.Label();
            this.generatePropertiesGrainBoundariesButtonButton = new System.Windows.Forms.Button();
            this.sizePropertiesGrainBoundariesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.selectionModePropertiesGrainBoundariesComboBox = new System.Windows.Forms.ComboBox();
            this.substructureGroupBox = new System.Windows.Forms.GroupBox();
            this.selectionTypeSubstructureLabel = new System.Windows.Forms.Label();
            this.selectionTypeSubstructureComboBox = new System.Windows.Forms.ComboBox();
            this.clearSubstructureButton = new System.Windows.Forms.Button();
            this.monteCarloTabPage = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbSizePropertiesMonteCarloNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.setEnergyModePropertiesMonteCarloComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.setEnergyValueButton = new System.Windows.Forms.Button();
            this.energyValuePropertiesMonteCarloNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.executionMonteCarloGroupBox = new System.Windows.Forms.GroupBox();
            this.currentIterationNumberMonteCarloTextBox = new System.Windows.Forms.TextBox();
            this.currentIterationMonteCarloLabel = new System.Windows.Forms.Label();
            this.iterationsMonteCarloLabel = new System.Windows.Forms.Label();
            this.iterationsNumberNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopMonteCarloButton = new System.Windows.Forms.Button();
            this.runIterationsMonteCarloButton = new System.Windows.Forms.Button();
            this.runMonteCarloButton = new System.Windows.Forms.Button();
            this.propertiesMonteCarloGroupBox = new System.Windows.Forms.GroupBox();
            this.stateAmountMonteCarloLlabel = new System.Windows.Forms.Label();
            this.randomStatesMonteCarloButton = new System.Windows.Forms.Button();
            this.stateMonteCarloNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.RectystallizationTabPage = new System.Windows.Forms.TabPage();
            this.removeRecrystallizationStatusButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.currentIterationExecutionRecrystallizationTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iterationsExecutionRecrystallizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.stopExecutionRecrystallizationButton = new System.Windows.Forms.Button();
            this.runIterationsExecutionRecrystallizationButton = new System.Windows.Forms.Button();
            this.runExecutionRecrystallizationButton = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.gbSizePropertiesRecrystallizationumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.applayPlacePropertiesRecrystallizationComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.applayModeRecrystallizationComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.randomPlacementPropertiesRecrystallizationButton = new System.Windows.Forms.Button();
            this.statesAmountPropertiesRecrystallizationNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.mouseModeLabel = new System.Windows.Forms.Label();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).BeginInit();
            this.gridPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightSizeGridPropertiesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSizeGridPropertiesNumericUpDown)).BeginInit();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityCAPropertiesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).BeginInit();
            this.executionGroupBox.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.propertiesTabPage.SuspendLayout();
            this.executionTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountInsclusionsNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueInclusionsNumericUpDown)).BeginInit();
            this.substructureTabPage.SuspendLayout();
            this.grainBoundariesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePropertiesGrainBoundariesNumericUpDown)).BeginInit();
            this.substructureGroupBox.SuspendLayout();
            this.monteCarloTabPage.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSizePropertiesMonteCarloNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyValuePropertiesMonteCarloNumericUpDown)).BeginInit();
            this.executionMonteCarloGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumberNumericUpDown)).BeginInit();
            this.propertiesMonteCarloGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateMonteCarloNumericUpDown)).BeginInit();
            this.RectystallizationTabPage.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsExecutionRecrystallizationNumericUpDown)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSizePropertiesRecrystallizationumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesAmountPropertiesRecrystallizationNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.viewPictureBox);
            this.viewPanel.Location = new System.Drawing.Point(12, 15);
            this.viewPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(667, 615);
            this.viewPanel.TabIndex = 0;
            // 
            // viewPictureBox
            // 
            this.viewPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.viewPictureBox.Location = new System.Drawing.Point(0, 0);
            this.viewPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewPictureBox.Name = "viewPictureBox";
            this.viewPictureBox.Size = new System.Drawing.Size(133, 123);
            this.viewPictureBox.TabIndex = 0;
            this.viewPictureBox.TabStop = false;
            this.viewPictureBox.Click += new System.EventHandler(this.ViewPictureBox_Click);
            this.viewPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPictureBox_Paint);
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGroupBox.Controls.Add(this.energyNeighborhoodRadioButton);
            this.viewGroupBox.Controls.Add(this.energyViewPropertiesRadioButton);
            this.viewGroupBox.Controls.Add(this.grainViewPropertiesRadioButton);
            this.viewGroupBox.Controls.Add(this.viewGridCheckBox);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBarLabel);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBar);
            this.viewGroupBox.Location = new System.Drawing.Point(4, 430);
            this.viewGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewGroupBox.Size = new System.Drawing.Size(232, 126);
            this.viewGroupBox.TabIndex = 1;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            // 
            // energyNeighborhoodRadioButton
            // 
            this.energyNeighborhoodRadioButton.AutoSize = true;
            this.energyNeighborhoodRadioButton.Enabled = false;
            this.energyNeighborhoodRadioButton.Location = new System.Drawing.Point(8, 80);
            this.energyNeighborhoodRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.energyNeighborhoodRadioButton.Name = "energyNeighborhoodRadioButton";
            this.energyNeighborhoodRadioButton.Size = new System.Drawing.Size(151, 38);
            this.energyNeighborhoodRadioButton.TabIndex = 5;
            this.energyNeighborhoodRadioButton.TabStop = true;
            this.energyNeighborhoodRadioButton.Text = "Show Energy \r\nWith Neighborhood";
            this.energyNeighborhoodRadioButton.UseVisualStyleBackColor = true;
            this.energyNeighborhoodRadioButton.Visible = false;
            this.energyNeighborhoodRadioButton.CheckedChanged += new System.EventHandler(this.energyViewPropertiesRadioButton_CheckedChanged);
            // 
            // energyViewPropertiesRadioButton
            // 
            this.energyViewPropertiesRadioButton.AutoSize = true;
            this.energyViewPropertiesRadioButton.Location = new System.Drawing.Point(8, 52);
            this.energyViewPropertiesRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.energyViewPropertiesRadioButton.Name = "energyViewPropertiesRadioButton";
            this.energyViewPropertiesRadioButton.Size = new System.Drawing.Size(112, 21);
            this.energyViewPropertiesRadioButton.TabIndex = 4;
            this.energyViewPropertiesRadioButton.TabStop = true;
            this.energyViewPropertiesRadioButton.Text = "Show Energy";
            this.energyViewPropertiesRadioButton.UseVisualStyleBackColor = true;
            this.energyViewPropertiesRadioButton.CheckedChanged += new System.EventHandler(this.energyViewPropertiesRadioButton_CheckedChanged);
            // 
            // grainViewPropertiesRadioButton
            // 
            this.grainViewPropertiesRadioButton.AutoSize = true;
            this.grainViewPropertiesRadioButton.Location = new System.Drawing.Point(8, 23);
            this.grainViewPropertiesRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grainViewPropertiesRadioButton.Name = "grainViewPropertiesRadioButton";
            this.grainViewPropertiesRadioButton.Size = new System.Drawing.Size(109, 21);
            this.grainViewPropertiesRadioButton.TabIndex = 3;
            this.grainViewPropertiesRadioButton.TabStop = true;
            this.grainViewPropertiesRadioButton.Text = "Show Grains";
            this.grainViewPropertiesRadioButton.UseVisualStyleBackColor = true;
            this.grainViewPropertiesRadioButton.CheckedChanged += new System.EventHandler(this.energyViewPropertiesRadioButton_CheckedChanged);
            // 
            // viewGridCheckBox
            // 
            this.viewGridCheckBox.AllowDrop = true;
            this.viewGridCheckBox.AutoSize = true;
            this.viewGridCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.viewGridCheckBox.Location = new System.Drawing.Point(25, 158);
            this.viewGridCheckBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewGridCheckBox.Name = "viewGridCheckBox";
            this.viewGridCheckBox.Size = new System.Drawing.Size(187, 21);
            this.viewGridCheckBox.TabIndex = 2;
            this.viewGridCheckBox.Text = "Show Grid Between Cells";
            this.viewGridCheckBox.UseVisualStyleBackColor = true;
            this.viewGridCheckBox.Visible = false;
            // 
            // viewZoomTrackBarLabel
            // 
            this.viewZoomTrackBarLabel.AutoSize = true;
            this.viewZoomTrackBarLabel.Location = new System.Drawing.Point(25, 96);
            this.viewZoomTrackBarLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewZoomTrackBarLabel.Name = "viewZoomTrackBarLabel";
            this.viewZoomTrackBarLabel.Size = new System.Drawing.Size(44, 17);
            this.viewZoomTrackBarLabel.TabIndex = 1;
            this.viewZoomTrackBarLabel.Text = "Zoom";
            this.viewZoomTrackBarLabel.Visible = false;
            // 
            // viewZoomTrackBar
            // 
            this.viewZoomTrackBar.Location = new System.Drawing.Point(80, 95);
            this.viewZoomTrackBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewZoomTrackBar.Minimum = 1;
            this.viewZoomTrackBar.Name = "viewZoomTrackBar";
            this.viewZoomTrackBar.Size = new System.Drawing.Size(139, 56);
            this.viewZoomTrackBar.TabIndex = 0;
            this.viewZoomTrackBar.Value = 1;
            this.viewZoomTrackBar.Visible = false;
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
            this.gridPropertiesGroupBox.Location = new System.Drawing.Point(5, 7);
            this.gridPropertiesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPropertiesGroupBox.Name = "gridPropertiesGroupBox";
            this.gridPropertiesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridPropertiesGroupBox.Size = new System.Drawing.Size(232, 144);
            this.gridPropertiesGroupBox.TabIndex = 2;
            this.gridPropertiesGroupBox.TabStop = false;
            this.gridPropertiesGroupBox.Text = "Grid Properties";
            // 
            // heightSizeGridPropertiesNumericUpDown
            // 
            this.heightSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(91, 74);
            this.heightSizeGridPropertiesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.heightSizeGridPropertiesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightSizeGridPropertiesNumericUpDown.Name = "heightSizeGridPropertiesNumericUpDown";
            this.heightSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.heightSizeGridPropertiesNumericUpDown.TabIndex = 10;
            this.heightSizeGridPropertiesNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // widthSizeGridPropertiesNumericUpDown
            // 
            this.widthSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(91, 47);
            this.widthSizeGridPropertiesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.widthSizeGridPropertiesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthSizeGridPropertiesNumericUpDown.Name = "widthSizeGridPropertiesNumericUpDown";
            this.widthSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.widthSizeGridPropertiesNumericUpDown.TabIndex = 9;
            this.widthSizeGridPropertiesNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // clearSizeGridPropertiesButton
            // 
            this.clearSizeGridPropertiesButton.Location = new System.Drawing.Point(124, 105);
            this.clearSizeGridPropertiesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearSizeGridPropertiesButton.Name = "clearSizeGridPropertiesButton";
            this.clearSizeGridPropertiesButton.Size = new System.Drawing.Size(100, 28);
            this.clearSizeGridPropertiesButton.TabIndex = 7;
            this.clearSizeGridPropertiesButton.Text = "Clear";
            this.clearSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            this.clearSizeGridPropertiesButton.Click += new System.EventHandler(this.ClearSizeGridPropertiesButton_Click);
            // 
            // resizeSizeGridPropertiesButton
            // 
            this.resizeSizeGridPropertiesButton.Location = new System.Drawing.Point(16, 105);
            this.resizeSizeGridPropertiesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.resizeSizeGridPropertiesButton.Name = "resizeSizeGridPropertiesButton";
            this.resizeSizeGridPropertiesButton.Size = new System.Drawing.Size(100, 28);
            this.resizeSizeGridPropertiesButton.TabIndex = 6;
            this.resizeSizeGridPropertiesButton.Text = "Resize";
            this.resizeSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            this.resizeSizeGridPropertiesButton.Click += new System.EventHandler(this.ResizeSizeGridPropertiesButton_Click);
            // 
            // heightSizeGridPropertiesLabel
            // 
            this.heightSizeGridPropertiesLabel.AutoSize = true;
            this.heightSizeGridPropertiesLabel.Location = new System.Drawing.Point(24, 76);
            this.heightSizeGridPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.heightSizeGridPropertiesLabel.Name = "heightSizeGridPropertiesLabel";
            this.heightSizeGridPropertiesLabel.Size = new System.Drawing.Size(58, 17);
            this.heightSizeGridPropertiesLabel.TabIndex = 3;
            this.heightSizeGridPropertiesLabel.Text = "• Height";
            // 
            // widthSizeGridPropertiesLabel
            // 
            this.widthSizeGridPropertiesLabel.AutoSize = true;
            this.widthSizeGridPropertiesLabel.Location = new System.Drawing.Point(24, 49);
            this.widthSizeGridPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthSizeGridPropertiesLabel.Name = "widthSizeGridPropertiesLabel";
            this.widthSizeGridPropertiesLabel.Size = new System.Drawing.Size(53, 17);
            this.widthSizeGridPropertiesLabel.TabIndex = 2;
            this.widthSizeGridPropertiesLabel.Text = "• Width";
            // 
            // sizegGridPropertiesSLabel
            // 
            this.sizegGridPropertiesSLabel.AutoSize = true;
            this.sizegGridPropertiesSLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sizegGridPropertiesSLabel.Location = new System.Drawing.Point(12, 20);
            this.sizegGridPropertiesSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizegGridPropertiesSLabel.Name = "sizegGridPropertiesSLabel";
            this.sizegGridPropertiesSLabel.Size = new System.Drawing.Size(46, 18);
            this.sizegGridPropertiesSLabel.TabIndex = 0;
            this.sizegGridPropertiesSLabel.Text = "Size:";
            // 
            // caGroupBox
            // 
            this.caGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.caGroupBox.Controls.Add(this.probabilityCAPropertiesNumericUpDown);
            this.caGroupBox.Controls.Add(this.probabilityCAPropertiesLabel);
            this.caGroupBox.Controls.Add(this.nucleonAmoutCAPropertiesNumericUpDown);
            this.caGroupBox.Controls.Add(this.randomPlacementButton);
            this.caGroupBox.Controls.Add(this.label1);
            this.caGroupBox.Controls.Add(this.boundaryConditionPropertiesComboBoxLabel);
            this.caGroupBox.Controls.Add(this.boundaryConditionCAPropertiesComboBox);
            this.caGroupBox.Controls.Add(this.neighbourhoodCAPropertiesComboBoxLabel);
            this.caGroupBox.Controls.Add(this.neighbourhoodCAPropertiesComboBox);
            this.caGroupBox.Location = new System.Drawing.Point(5, 159);
            this.caGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caGroupBox.Size = new System.Drawing.Size(232, 263);
            this.caGroupBox.TabIndex = 3;
            this.caGroupBox.TabStop = false;
            this.caGroupBox.Text = "Cellural Automata Properties";
            // 
            // probabilityCAPropertiesNumericUpDown
            // 
            this.probabilityCAPropertiesNumericUpDown.Location = new System.Drawing.Point(91, 229);
            this.probabilityCAPropertiesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.probabilityCAPropertiesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.probabilityCAPropertiesNumericUpDown.Name = "probabilityCAPropertiesNumericUpDown";
            this.probabilityCAPropertiesNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.probabilityCAPropertiesNumericUpDown.TabIndex = 10;
            this.probabilityCAPropertiesNumericUpDown.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.probabilityCAPropertiesNumericUpDown.ValueChanged += new System.EventHandler(this.ProbabilityCAPropertiesNumericUpDown_ValueChanged);
            // 
            // probabilityCAPropertiesLabel
            // 
            this.probabilityCAPropertiesLabel.AutoSize = true;
            this.probabilityCAPropertiesLabel.Location = new System.Drawing.Point(8, 209);
            this.probabilityCAPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.probabilityCAPropertiesLabel.Name = "probabilityCAPropertiesLabel";
            this.probabilityCAPropertiesLabel.Size = new System.Drawing.Size(159, 17);
            this.probabilityCAPropertiesLabel.TabIndex = 9;
            this.probabilityCAPropertiesLabel.Text = "Probality of cell change:";
            // 
            // nucleonAmoutCAPropertiesNumericUpDown
            // 
            this.nucleonAmoutCAPropertiesNumericUpDown.Location = new System.Drawing.Point(91, 145);
            this.nucleonAmoutCAPropertiesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nucleonAmoutCAPropertiesNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nucleonAmoutCAPropertiesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nucleonAmoutCAPropertiesNumericUpDown.Name = "nucleonAmoutCAPropertiesNumericUpDown";
            this.nucleonAmoutCAPropertiesNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.nucleonAmoutCAPropertiesNumericUpDown.TabIndex = 8;
            this.nucleonAmoutCAPropertiesNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nucleonAmoutCAPropertiesNumericUpDown.ValueChanged += new System.EventHandler(this.NucleonAmoutCAPropertiesNumericUpDown_ValueChanged);
            // 
            // randomPlacementButton
            // 
            this.randomPlacementButton.Location = new System.Drawing.Point(12, 177);
            this.randomPlacementButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomPlacementButton.Name = "randomPlacementButton";
            this.randomPlacementButton.Size = new System.Drawing.Size(212, 28);
            this.randomPlacementButton.TabIndex = 7;
            this.randomPlacementButton.Text = "Random nucleon placement";
            this.randomPlacementButton.UseVisualStyleBackColor = true;
            this.randomPlacementButton.Click += new System.EventHandler(this.RandomPlacementButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 126);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nucleon Amout:";
            // 
            // boundaryConditionPropertiesComboBoxLabel
            // 
            this.boundaryConditionPropertiesComboBoxLabel.AutoSize = true;
            this.boundaryConditionPropertiesComboBoxLabel.Location = new System.Drawing.Point(8, 27);
            this.boundaryConditionPropertiesComboBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.boundaryConditionPropertiesComboBoxLabel.Name = "boundaryConditionPropertiesComboBoxLabel";
            this.boundaryConditionPropertiesComboBoxLabel.Size = new System.Drawing.Size(136, 17);
            this.boundaryConditionPropertiesComboBoxLabel.TabIndex = 3;
            this.boundaryConditionPropertiesComboBoxLabel.Text = "Boundary Condition:";
            // 
            // boundaryConditionCAPropertiesComboBox
            // 
            this.boundaryConditionCAPropertiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boundaryConditionCAPropertiesComboBox.FormattingEnabled = true;
            this.boundaryConditionCAPropertiesComboBox.Items.AddRange(new object[] {
            "Periodic"});
            this.boundaryConditionCAPropertiesComboBox.Location = new System.Drawing.Point(91, 47);
            this.boundaryConditionCAPropertiesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boundaryConditionCAPropertiesComboBox.Name = "boundaryConditionCAPropertiesComboBox";
            this.boundaryConditionCAPropertiesComboBox.Size = new System.Drawing.Size(132, 24);
            this.boundaryConditionCAPropertiesComboBox.TabIndex = 2;
            // 
            // neighbourhoodCAPropertiesComboBoxLabel
            // 
            this.neighbourhoodCAPropertiesComboBoxLabel.AutoSize = true;
            this.neighbourhoodCAPropertiesComboBoxLabel.Location = new System.Drawing.Point(8, 76);
            this.neighbourhoodCAPropertiesComboBoxLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.neighbourhoodCAPropertiesComboBoxLabel.Name = "neighbourhoodCAPropertiesComboBoxLabel";
            this.neighbourhoodCAPropertiesComboBoxLabel.Size = new System.Drawing.Size(110, 17);
            this.neighbourhoodCAPropertiesComboBoxLabel.TabIndex = 1;
            this.neighbourhoodCAPropertiesComboBoxLabel.Text = "Neighbourhood:";
            // 
            // neighbourhoodCAPropertiesComboBox
            // 
            this.neighbourhoodCAPropertiesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.neighbourhoodCAPropertiesComboBox.FormattingEnabled = true;
            this.neighbourhoodCAPropertiesComboBox.Items.AddRange(new object[] {
            "Simple Moore",
            "Moore 4 rules"});
            this.neighbourhoodCAPropertiesComboBox.Location = new System.Drawing.Point(91, 96);
            this.neighbourhoodCAPropertiesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.neighbourhoodCAPropertiesComboBox.Name = "neighbourhoodCAPropertiesComboBox";
            this.neighbourhoodCAPropertiesComboBox.Size = new System.Drawing.Size(132, 24);
            this.neighbourhoodCAPropertiesComboBox.TabIndex = 0;
            // 
            // runCAExecutionButton
            // 
            this.runCAExecutionButton.Location = new System.Drawing.Point(8, 42);
            this.runCAExecutionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runCAExecutionButton.Name = "runCAExecutionButton";
            this.runCAExecutionButton.Size = new System.Drawing.Size(107, 28);
            this.runCAExecutionButton.TabIndex = 9;
            this.runCAExecutionButton.Text = "Run";
            this.runCAExecutionButton.UseVisualStyleBackColor = true;
            this.runCAExecutionButton.Click += new System.EventHandler(this.RunCAExecutionButton_Click);
            // 
            // stopCAExecutionButton
            // 
            this.stopCAExecutionButton.Location = new System.Drawing.Point(117, 42);
            this.stopCAExecutionButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopCAExecutionButton.Name = "stopCAExecutionButton";
            this.stopCAExecutionButton.Size = new System.Drawing.Size(107, 28);
            this.stopCAExecutionButton.TabIndex = 10;
            this.stopCAExecutionButton.Text = "Stop";
            this.stopCAExecutionButton.UseVisualStyleBackColor = true;
            this.stopCAExecutionButton.Click += new System.EventHandler(this.StopCAExecutionButton_Click);
            // 
            // caSimulationCAPropertiesLabel
            // 
            this.caSimulationCAPropertiesLabel.AutoSize = true;
            this.caSimulationCAPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caSimulationCAPropertiesLabel.Location = new System.Drawing.Point(12, 20);
            this.caSimulationCAPropertiesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.caSimulationCAPropertiesLabel.Name = "caSimulationCAPropertiesLabel";
            this.caSimulationCAPropertiesLabel.Size = new System.Drawing.Size(124, 18);
            this.caSimulationCAPropertiesLabel.TabIndex = 11;
            this.caSimulationCAPropertiesLabel.Text = "CA Simulation: ";
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.Controls.Add(this.caExecutionProgressBar);
            this.executionGroupBox.Controls.Add(this.caSimulationCAPropertiesLabel);
            this.executionGroupBox.Controls.Add(this.runCAExecutionButton);
            this.executionGroupBox.Controls.Add(this.stopCAExecutionButton);
            this.executionGroupBox.Location = new System.Drawing.Point(8, 172);
            this.executionGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionGroupBox.Size = new System.Drawing.Size(232, 123);
            this.executionGroupBox.TabIndex = 14;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Execution";
            // 
            // caExecutionProgressBar
            // 
            this.caExecutionProgressBar.Location = new System.Drawing.Point(8, 79);
            this.caExecutionProgressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.caExecutionProgressBar.Name = "caExecutionProgressBar";
            this.caExecutionProgressBar.Size = new System.Drawing.Size(216, 28);
            this.caExecutionProgressBar.TabIndex = 12;
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openFileMenuItem,
            this.saveFileMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // openFileMenuItem
            // 
            this.openFileMenuItem.Index = 0;
            this.openFileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.jsonOpenFileMenuItem,
            this.bitmapOpenFileMenuItem});
            this.openFileMenuItem.Text = "Open...";
            // 
            // jsonOpenFileMenuItem
            // 
            this.jsonOpenFileMenuItem.Index = 0;
            this.jsonOpenFileMenuItem.Text = "... from JSON";
            this.jsonOpenFileMenuItem.Click += new System.EventHandler(this.JsonOpenFileMenuItem_Click);
            // 
            // bitmapOpenFileMenuItem
            // 
            this.bitmapOpenFileMenuItem.Index = 1;
            this.bitmapOpenFileMenuItem.Text = "... from BITMAP";
            this.bitmapOpenFileMenuItem.Click += new System.EventHandler(this.bitmapOpenFileMenuItem_Click);
            // 
            // saveFileMenuItem
            // 
            this.saveFileMenuItem.Index = 1;
            this.saveFileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.jsonSaveFileMenuItem,
            this.bitmapSaveFileMenuItem});
            this.saveFileMenuItem.Text = "Save...";
            // 
            // jsonSaveFileMenuItem
            // 
            this.jsonSaveFileMenuItem.Index = 0;
            this.jsonSaveFileMenuItem.Text = "... to JSON";
            this.jsonSaveFileMenuItem.Click += new System.EventHandler(this.jsonSaveFileMenuItem_Click);
            // 
            // bitmapSaveFileMenuItem
            // 
            this.bitmapSaveFileMenuItem.Index = 1;
            this.bitmapSaveFileMenuItem.Text = "... to BITMAP";
            this.bitmapSaveFileMenuItem.Click += new System.EventHandler(this.BitmapSaveFileMenuItem_Click);
            // 
            // menuTabControl
            // 
            this.menuTabControl.Controls.Add(this.propertiesTabPage);
            this.menuTabControl.Controls.Add(this.executionTabPage);
            this.menuTabControl.Controls.Add(this.substructureTabPage);
            this.menuTabControl.Controls.Add(this.monteCarloTabPage);
            this.menuTabControl.Controls.Add(this.RectystallizationTabPage);
            this.menuTabControl.Location = new System.Drawing.Point(687, 15);
            this.menuTabControl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(256, 594);
            this.menuTabControl.TabIndex = 15;
            // 
            // propertiesTabPage
            // 
            this.propertiesTabPage.Controls.Add(this.gridPropertiesGroupBox);
            this.propertiesTabPage.Controls.Add(this.caGroupBox);
            this.propertiesTabPage.Controls.Add(this.viewGroupBox);
            this.propertiesTabPage.Location = new System.Drawing.Point(4, 25);
            this.propertiesTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertiesTabPage.Name = "propertiesTabPage";
            this.propertiesTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertiesTabPage.Size = new System.Drawing.Size(248, 565);
            this.propertiesTabPage.TabIndex = 0;
            this.propertiesTabPage.Text = "Properties";
            this.propertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // executionTabPage
            // 
            this.executionTabPage.Controls.Add(this.groupBox1);
            this.executionTabPage.Controls.Add(this.executionGroupBox);
            this.executionTabPage.Location = new System.Drawing.Point(4, 25);
            this.executionTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionTabPage.Name = "executionTabPage";
            this.executionTabPage.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionTabPage.Size = new System.Drawing.Size(248, 565);
            this.executionTabPage.TabIndex = 1;
            this.executionTabPage.Text = "Execution";
            this.executionTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.amountInsclusionsNumericUpDown);
            this.groupBox1.Controls.Add(this.amountInclusionsLabel);
            this.groupBox1.Controls.Add(this.valueInclusionsNumericUpDown);
            this.groupBox1.Controls.Add(this.valueInclusionsLabel);
            this.groupBox1.Controls.Add(this.typeInclusionsComboBox);
            this.groupBox1.Controls.Add(this.tyoeInclusionsLabel);
            this.groupBox1.Controls.Add(this.generateInclusionsButton);
            this.groupBox1.Location = new System.Drawing.Point(8, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(232, 158);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inclusions";
            // 
            // amountInsclusionsNumericUpDown
            // 
            this.amountInsclusionsNumericUpDown.Location = new System.Drawing.Point(85, 89);
            this.amountInsclusionsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.amountInsclusionsNumericUpDown.Name = "amountInsclusionsNumericUpDown";
            this.amountInsclusionsNumericUpDown.Size = new System.Drawing.Size(139, 22);
            this.amountInsclusionsNumericUpDown.TabIndex = 16;
            // 
            // amountInclusionsLabel
            // 
            this.amountInclusionsLabel.AutoSize = true;
            this.amountInclusionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountInclusionsLabel.Location = new System.Drawing.Point(20, 91);
            this.amountInclusionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.amountInclusionsLabel.Name = "amountInclusionsLabel";
            this.amountInclusionsLabel.Size = new System.Drawing.Size(60, 17);
            this.amountInclusionsLabel.TabIndex = 15;
            this.amountInclusionsLabel.Text = "Amount:";
            // 
            // valueInclusionsNumericUpDown
            // 
            this.valueInclusionsNumericUpDown.Location = new System.Drawing.Point(85, 57);
            this.valueInclusionsNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.valueInclusionsNumericUpDown.Name = "valueInclusionsNumericUpDown";
            this.valueInclusionsNumericUpDown.Size = new System.Drawing.Size(139, 22);
            this.valueInclusionsNumericUpDown.TabIndex = 14;
            // 
            // valueInclusionsLabel
            // 
            this.valueInclusionsLabel.AutoSize = true;
            this.valueInclusionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInclusionsLabel.Location = new System.Drawing.Point(20, 59);
            this.valueInclusionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.valueInclusionsLabel.Name = "valueInclusionsLabel";
            this.valueInclusionsLabel.Size = new System.Drawing.Size(56, 17);
            this.valueInclusionsLabel.TabIndex = 13;
            this.valueInclusionsLabel.Text = "Length:";
            // 
            // typeInclusionsComboBox
            // 
            this.typeInclusionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeInclusionsComboBox.FormattingEnabled = true;
            this.typeInclusionsComboBox.Items.AddRange(new object[] {
            "Square",
            "Circle"});
            this.typeInclusionsComboBox.Location = new System.Drawing.Point(85, 23);
            this.typeInclusionsComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.typeInclusionsComboBox.Name = "typeInclusionsComboBox";
            this.typeInclusionsComboBox.Size = new System.Drawing.Size(137, 24);
            this.typeInclusionsComboBox.TabIndex = 12;
            this.typeInclusionsComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeInclusionsComboBox_SelectedIndexChanged);
            // 
            // tyoeInclusionsLabel
            // 
            this.tyoeInclusionsLabel.AutoSize = true;
            this.tyoeInclusionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyoeInclusionsLabel.Location = new System.Drawing.Point(32, 27);
            this.tyoeInclusionsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tyoeInclusionsLabel.Name = "tyoeInclusionsLabel";
            this.tyoeInclusionsLabel.Size = new System.Drawing.Size(44, 17);
            this.tyoeInclusionsLabel.TabIndex = 11;
            this.tyoeInclusionsLabel.Text = "Type:";
            // 
            // generateInclusionsButton
            // 
            this.generateInclusionsButton.Location = new System.Drawing.Point(117, 121);
            this.generateInclusionsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generateInclusionsButton.Name = "generateInclusionsButton";
            this.generateInclusionsButton.Size = new System.Drawing.Size(107, 28);
            this.generateInclusionsButton.TabIndex = 9;
            this.generateInclusionsButton.Text = "Generate";
            this.generateInclusionsButton.UseVisualStyleBackColor = true;
            this.generateInclusionsButton.Click += new System.EventHandler(this.GenerateInclusionsButton_Click);
            // 
            // substructureTabPage
            // 
            this.substructureTabPage.Controls.Add(this.grainBoundariesGroupBox);
            this.substructureTabPage.Controls.Add(this.substructureGroupBox);
            this.substructureTabPage.Controls.Add(this.clearSubstructureButton);
            this.substructureTabPage.Location = new System.Drawing.Point(4, 25);
            this.substructureTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.substructureTabPage.Name = "substructureTabPage";
            this.substructureTabPage.Size = new System.Drawing.Size(248, 565);
            this.substructureTabPage.TabIndex = 2;
            this.substructureTabPage.Text = "Post processing";
            this.substructureTabPage.UseVisualStyleBackColor = true;
            // 
            // grainBoundariesGroupBox
            // 
            this.grainBoundariesGroupBox.Controls.Add(this.gbPercentTextBox);
            this.grainBoundariesGroupBox.Controls.Add(this.sizePropertiesGrainBoundariesLabel);
            this.grainBoundariesGroupBox.Controls.Add(this.selectionModePropertiesGrainBoundariesLabel);
            this.grainBoundariesGroupBox.Controls.Add(this.gbPercentPropertiesGrainBoundariesLabel);
            this.grainBoundariesGroupBox.Controls.Add(this.generatePropertiesGrainBoundariesButtonButton);
            this.grainBoundariesGroupBox.Controls.Add(this.sizePropertiesGrainBoundariesNumericUpDown);
            this.grainBoundariesGroupBox.Controls.Add(this.selectionModePropertiesGrainBoundariesComboBox);
            this.grainBoundariesGroupBox.Location = new System.Drawing.Point(8, 105);
            this.grainBoundariesGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grainBoundariesGroupBox.Name = "grainBoundariesGroupBox";
            this.grainBoundariesGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grainBoundariesGroupBox.Size = new System.Drawing.Size(232, 188);
            this.grainBoundariesGroupBox.TabIndex = 4;
            this.grainBoundariesGroupBox.TabStop = false;
            this.grainBoundariesGroupBox.Text = "Grain Boundaries";
            // 
            // gbPercentTextBox
            // 
            this.gbPercentTextBox.Enabled = false;
            this.gbPercentTextBox.Location = new System.Drawing.Point(64, 118);
            this.gbPercentTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPercentTextBox.Name = "gbPercentTextBox";
            this.gbPercentTextBox.Size = new System.Drawing.Size(159, 22);
            this.gbPercentTextBox.TabIndex = 6;
            // 
            // sizePropertiesGrainBoundariesLabel
            // 
            this.sizePropertiesGrainBoundariesLabel.AutoSize = true;
            this.sizePropertiesGrainBoundariesLabel.Location = new System.Drawing.Point(9, 89);
            this.sizePropertiesGrainBoundariesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizePropertiesGrainBoundariesLabel.Name = "sizePropertiesGrainBoundariesLabel";
            this.sizePropertiesGrainBoundariesLabel.Size = new System.Drawing.Size(39, 17);
            this.sizePropertiesGrainBoundariesLabel.TabIndex = 5;
            this.sizePropertiesGrainBoundariesLabel.Text = "Size:";
            // 
            // selectionModePropertiesGrainBoundariesLabel
            // 
            this.selectionModePropertiesGrainBoundariesLabel.AutoSize = true;
            this.selectionModePropertiesGrainBoundariesLabel.Location = new System.Drawing.Point(11, 33);
            this.selectionModePropertiesGrainBoundariesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionModePropertiesGrainBoundariesLabel.Name = "selectionModePropertiesGrainBoundariesLabel";
            this.selectionModePropertiesGrainBoundariesLabel.Size = new System.Drawing.Size(109, 17);
            this.selectionModePropertiesGrainBoundariesLabel.TabIndex = 4;
            this.selectionModePropertiesGrainBoundariesLabel.Text = "Selection mode:";
            // 
            // gbPercentPropertiesGrainBoundariesLabel
            // 
            this.gbPercentPropertiesGrainBoundariesLabel.AutoSize = true;
            this.gbPercentPropertiesGrainBoundariesLabel.Location = new System.Drawing.Point(9, 121);
            this.gbPercentPropertiesGrainBoundariesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gbPercentPropertiesGrainBoundariesLabel.Name = "gbPercentPropertiesGrainBoundariesLabel";
            this.gbPercentPropertiesGrainBoundariesLabel.Size = new System.Drawing.Size(48, 17);
            this.gbPercentPropertiesGrainBoundariesLabel.TabIndex = 3;
            this.gbPercentPropertiesGrainBoundariesLabel.Text = "GB %:";
            // 
            // generatePropertiesGrainBoundariesButtonButton
            // 
            this.generatePropertiesGrainBoundariesButtonButton.Location = new System.Drawing.Point(61, 150);
            this.generatePropertiesGrainBoundariesButtonButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.generatePropertiesGrainBoundariesButtonButton.Name = "generatePropertiesGrainBoundariesButtonButton";
            this.generatePropertiesGrainBoundariesButtonButton.Size = new System.Drawing.Size(161, 28);
            this.generatePropertiesGrainBoundariesButtonButton.TabIndex = 2;
            this.generatePropertiesGrainBoundariesButtonButton.Text = "Generate";
            this.generatePropertiesGrainBoundariesButtonButton.UseVisualStyleBackColor = true;
            this.generatePropertiesGrainBoundariesButtonButton.Click += new System.EventHandler(this.GeneratePropertiesGrainBoundariesButtonButton_Click);
            // 
            // sizePropertiesGrainBoundariesNumericUpDown
            // 
            this.sizePropertiesGrainBoundariesNumericUpDown.Location = new System.Drawing.Point(64, 86);
            this.sizePropertiesGrainBoundariesNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sizePropertiesGrainBoundariesNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.sizePropertiesGrainBoundariesNumericUpDown.Name = "sizePropertiesGrainBoundariesNumericUpDown";
            this.sizePropertiesGrainBoundariesNumericUpDown.Size = new System.Drawing.Size(160, 22);
            this.sizePropertiesGrainBoundariesNumericUpDown.TabIndex = 1;
            this.sizePropertiesGrainBoundariesNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // selectionModePropertiesGrainBoundariesComboBox
            // 
            this.selectionModePropertiesGrainBoundariesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionModePropertiesGrainBoundariesComboBox.FormattingEnabled = true;
            this.selectionModePropertiesGrainBoundariesComboBox.Items.AddRange(new object[] {
            "All grains",
            "Point and click"});
            this.selectionModePropertiesGrainBoundariesComboBox.Location = new System.Drawing.Point(64, 54);
            this.selectionModePropertiesGrainBoundariesComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectionModePropertiesGrainBoundariesComboBox.Name = "selectionModePropertiesGrainBoundariesComboBox";
            this.selectionModePropertiesGrainBoundariesComboBox.Size = new System.Drawing.Size(160, 24);
            this.selectionModePropertiesGrainBoundariesComboBox.TabIndex = 0;
            this.selectionModePropertiesGrainBoundariesComboBox.SelectedIndexChanged += new System.EventHandler(this.SelectionModePropertiesGrainBoundariesComboBox_SelectedIndexChanged);
            // 
            // substructureGroupBox
            // 
            this.substructureGroupBox.Controls.Add(this.selectionTypeSubstructureLabel);
            this.substructureGroupBox.Controls.Add(this.selectionTypeSubstructureComboBox);
            this.substructureGroupBox.Location = new System.Drawing.Point(8, 2);
            this.substructureGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.substructureGroupBox.Name = "substructureGroupBox";
            this.substructureGroupBox.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.substructureGroupBox.Size = new System.Drawing.Size(232, 95);
            this.substructureGroupBox.TabIndex = 3;
            this.substructureGroupBox.TabStop = false;
            this.substructureGroupBox.Text = "Substructure";
            // 
            // selectionTypeSubstructureLabel
            // 
            this.selectionTypeSubstructureLabel.AutoSize = true;
            this.selectionTypeSubstructureLabel.Location = new System.Drawing.Point(7, 27);
            this.selectionTypeSubstructureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.selectionTypeSubstructureLabel.Name = "selectionTypeSubstructureLabel";
            this.selectionTypeSubstructureLabel.Size = new System.Drawing.Size(109, 17);
            this.selectionTypeSubstructureLabel.TabIndex = 2;
            this.selectionTypeSubstructureLabel.Text = "Selection mode:";
            // 
            // selectionTypeSubstructureComboBox
            // 
            this.selectionTypeSubstructureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectionTypeSubstructureComboBox.FormattingEnabled = true;
            this.selectionTypeSubstructureComboBox.Items.AddRange(new object[] {
            "Substructure",
            "Dualphase"});
            this.selectionTypeSubstructureComboBox.Location = new System.Drawing.Point(72, 48);
            this.selectionTypeSubstructureComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.selectionTypeSubstructureComboBox.Name = "selectionTypeSubstructureComboBox";
            this.selectionTypeSubstructureComboBox.Size = new System.Drawing.Size(159, 24);
            this.selectionTypeSubstructureComboBox.TabIndex = 1;
            this.selectionTypeSubstructureComboBox.SelectedIndexChanged += new System.EventHandler(this.selectionTypeSubstructureComboBox_SelectedIndexChanged);
            // 
            // clearSubstructureButton
            // 
            this.clearSubstructureButton.Location = new System.Drawing.Point(8, 302);
            this.clearSubstructureButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clearSubstructureButton.Name = "clearSubstructureButton";
            this.clearSubstructureButton.Size = new System.Drawing.Size(232, 28);
            this.clearSubstructureButton.TabIndex = 0;
            this.clearSubstructureButton.Text = "Clear and leave selected grains";
            this.clearSubstructureButton.UseVisualStyleBackColor = true;
            this.clearSubstructureButton.Click += new System.EventHandler(this.ClearSubstructureButton_Click);
            // 
            // monteCarloTabPage
            // 
            this.monteCarloTabPage.Controls.Add(this.groupBox2);
            this.monteCarloTabPage.Controls.Add(this.executionMonteCarloGroupBox);
            this.monteCarloTabPage.Controls.Add(this.propertiesMonteCarloGroupBox);
            this.monteCarloTabPage.Location = new System.Drawing.Point(4, 25);
            this.monteCarloTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monteCarloTabPage.Name = "monteCarloTabPage";
            this.monteCarloTabPage.Size = new System.Drawing.Size(248, 565);
            this.monteCarloTabPage.TabIndex = 3;
            this.monteCarloTabPage.Text = "Monte Carlo";
            this.monteCarloTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.gbSizePropertiesMonteCarloNumericUpDown);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.setEnergyModePropertiesMonteCarloComboBox);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.setEnergyValueButton);
            this.groupBox2.Controls.Add(this.energyValuePropertiesMonteCarloNumericUpDown);
            this.groupBox2.Location = new System.Drawing.Point(5, 300);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(233, 182);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Properties";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "GB Size:";
            // 
            // gbSizePropertiesMonteCarloNumericUpDown
            // 
            this.gbSizePropertiesMonteCarloNumericUpDown.Location = new System.Drawing.Point(92, 112);
            this.gbSizePropertiesMonteCarloNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSizePropertiesMonteCarloNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gbSizePropertiesMonteCarloNumericUpDown.Name = "gbSizePropertiesMonteCarloNumericUpDown";
            this.gbSizePropertiesMonteCarloNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.gbSizePropertiesMonteCarloNumericUpDown.TabIndex = 14;
            this.gbSizePropertiesMonteCarloNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Set energy mode:";
            // 
            // setEnergyModePropertiesMonteCarloComboBox
            // 
            this.setEnergyModePropertiesMonteCarloComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.setEnergyModePropertiesMonteCarloComboBox.FormattingEnabled = true;
            this.setEnergyModePropertiesMonteCarloComboBox.Items.AddRange(new object[] {
            "Homogenius",
            "Grains",
            "Boundries"});
            this.setEnergyModePropertiesMonteCarloComboBox.Location = new System.Drawing.Point(61, 41);
            this.setEnergyModePropertiesMonteCarloComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setEnergyModePropertiesMonteCarloComboBox.Name = "setEnergyModePropertiesMonteCarloComboBox";
            this.setEnergyModePropertiesMonteCarloComboBox.Size = new System.Drawing.Size(160, 24);
            this.setEnergyModePropertiesMonteCarloComboBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Energy value:";
            // 
            // setEnergyValueButton
            // 
            this.setEnergyValueButton.Location = new System.Drawing.Point(8, 144);
            this.setEnergyValueButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setEnergyValueButton.Name = "setEnergyValueButton";
            this.setEnergyValueButton.Size = new System.Drawing.Size(216, 28);
            this.setEnergyValueButton.TabIndex = 10;
            this.setEnergyValueButton.Text = "Set Energy Values";
            this.setEnergyValueButton.UseVisualStyleBackColor = true;
            this.setEnergyValueButton.Click += new System.EventHandler(this.setEnergyValueButton_Click);
            // 
            // energyValuePropertiesMonteCarloNumericUpDown
            // 
            this.energyValuePropertiesMonteCarloNumericUpDown.Location = new System.Drawing.Point(123, 80);
            this.energyValuePropertiesMonteCarloNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.energyValuePropertiesMonteCarloNumericUpDown.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.energyValuePropertiesMonteCarloNumericUpDown.Name = "energyValuePropertiesMonteCarloNumericUpDown";
            this.energyValuePropertiesMonteCarloNumericUpDown.Size = new System.Drawing.Size(103, 22);
            this.energyValuePropertiesMonteCarloNumericUpDown.TabIndex = 11;
            this.energyValuePropertiesMonteCarloNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // executionMonteCarloGroupBox
            // 
            this.executionMonteCarloGroupBox.Controls.Add(this.currentIterationNumberMonteCarloTextBox);
            this.executionMonteCarloGroupBox.Controls.Add(this.currentIterationMonteCarloLabel);
            this.executionMonteCarloGroupBox.Controls.Add(this.iterationsMonteCarloLabel);
            this.executionMonteCarloGroupBox.Controls.Add(this.iterationsNumberNumericUpDown);
            this.executionMonteCarloGroupBox.Controls.Add(this.stopMonteCarloButton);
            this.executionMonteCarloGroupBox.Controls.Add(this.runIterationsMonteCarloButton);
            this.executionMonteCarloGroupBox.Controls.Add(this.runMonteCarloButton);
            this.executionMonteCarloGroupBox.Location = new System.Drawing.Point(5, 128);
            this.executionMonteCarloGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionMonteCarloGroupBox.Name = "executionMonteCarloGroupBox";
            this.executionMonteCarloGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.executionMonteCarloGroupBox.Size = new System.Drawing.Size(236, 165);
            this.executionMonteCarloGroupBox.TabIndex = 23;
            this.executionMonteCarloGroupBox.TabStop = false;
            this.executionMonteCarloGroupBox.Text = "Execution";
            // 
            // currentIterationNumberMonteCarloTextBox
            // 
            this.currentIterationNumberMonteCarloTextBox.Enabled = false;
            this.currentIterationNumberMonteCarloTextBox.Location = new System.Drawing.Point(127, 130);
            this.currentIterationNumberMonteCarloTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentIterationNumberMonteCarloTextBox.Name = "currentIterationNumberMonteCarloTextBox";
            this.currentIterationNumberMonteCarloTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentIterationNumberMonteCarloTextBox.TabIndex = 23;
            // 
            // currentIterationMonteCarloLabel
            // 
            this.currentIterationMonteCarloLabel.AutoSize = true;
            this.currentIterationMonteCarloLabel.Location = new System.Drawing.Point(4, 134);
            this.currentIterationMonteCarloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.currentIterationMonteCarloLabel.Name = "currentIterationMonteCarloLabel";
            this.currentIterationMonteCarloLabel.Size = new System.Drawing.Size(118, 17);
            this.currentIterationMonteCarloLabel.TabIndex = 22;
            this.currentIterationMonteCarloLabel.Text = "Current Iteration: ";
            // 
            // iterationsMonteCarloLabel
            // 
            this.iterationsMonteCarloLabel.AutoSize = true;
            this.iterationsMonteCarloLabel.Location = new System.Drawing.Point(11, 22);
            this.iterationsMonteCarloLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterationsMonteCarloLabel.Name = "iterationsMonteCarloLabel";
            this.iterationsMonteCarloLabel.Size = new System.Drawing.Size(70, 17);
            this.iterationsMonteCarloLabel.TabIndex = 19;
            this.iterationsMonteCarloLabel.Text = "Iterations:";
            // 
            // iterationsNumberNumericUpDown
            // 
            this.iterationsNumberNumericUpDown.Location = new System.Drawing.Point(95, 20);
            this.iterationsNumberNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iterationsNumberNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.iterationsNumberNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsNumberNumericUpDown.Name = "iterationsNumberNumericUpDown";
            this.iterationsNumberNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.iterationsNumberNumericUpDown.TabIndex = 20;
            this.iterationsNumberNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stopMonteCarloButton
            // 
            this.stopMonteCarloButton.Location = new System.Drawing.Point(124, 87);
            this.stopMonteCarloButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopMonteCarloButton.Name = "stopMonteCarloButton";
            this.stopMonteCarloButton.Size = new System.Drawing.Size(104, 28);
            this.stopMonteCarloButton.TabIndex = 18;
            this.stopMonteCarloButton.Text = "Stop";
            this.stopMonteCarloButton.UseVisualStyleBackColor = true;
            this.stopMonteCarloButton.Click += new System.EventHandler(this.StopMonteCarloButton_Click);
            // 
            // runIterationsMonteCarloButton
            // 
            this.runIterationsMonteCarloButton.Location = new System.Drawing.Point(8, 52);
            this.runIterationsMonteCarloButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runIterationsMonteCarloButton.Name = "runIterationsMonteCarloButton";
            this.runIterationsMonteCarloButton.Size = new System.Drawing.Size(220, 28);
            this.runIterationsMonteCarloButton.TabIndex = 21;
            this.runIterationsMonteCarloButton.Text = "Run Iterations";
            this.runIterationsMonteCarloButton.UseVisualStyleBackColor = true;
            this.runIterationsMonteCarloButton.Click += new System.EventHandler(this.RunIterationsMonteCarloButton_Click);
            // 
            // runMonteCarloButton
            // 
            this.runMonteCarloButton.Location = new System.Drawing.Point(8, 87);
            this.runMonteCarloButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runMonteCarloButton.Name = "runMonteCarloButton";
            this.runMonteCarloButton.Size = new System.Drawing.Size(108, 28);
            this.runMonteCarloButton.TabIndex = 17;
            this.runMonteCarloButton.Text = "Run";
            this.runMonteCarloButton.UseVisualStyleBackColor = true;
            this.runMonteCarloButton.Click += new System.EventHandler(this.RunMonteCarloButton_Click);
            // 
            // propertiesMonteCarloGroupBox
            // 
            this.propertiesMonteCarloGroupBox.Controls.Add(this.stateAmountMonteCarloLlabel);
            this.propertiesMonteCarloGroupBox.Controls.Add(this.randomStatesMonteCarloButton);
            this.propertiesMonteCarloGroupBox.Controls.Add(this.stateMonteCarloNumericUpDown);
            this.propertiesMonteCarloGroupBox.Location = new System.Drawing.Point(8, 9);
            this.propertiesMonteCarloGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertiesMonteCarloGroupBox.Name = "propertiesMonteCarloGroupBox";
            this.propertiesMonteCarloGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.propertiesMonteCarloGroupBox.Size = new System.Drawing.Size(233, 112);
            this.propertiesMonteCarloGroupBox.TabIndex = 22;
            this.propertiesMonteCarloGroupBox.TabStop = false;
            this.propertiesMonteCarloGroupBox.Text = "Properties";
            // 
            // stateAmountMonteCarloLlabel
            // 
            this.stateAmountMonteCarloLlabel.AutoSize = true;
            this.stateAmountMonteCarloLlabel.Location = new System.Drawing.Point(8, 20);
            this.stateAmountMonteCarloLlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stateAmountMonteCarloLlabel.Name = "stateAmountMonteCarloLlabel";
            this.stateAmountMonteCarloLlabel.Size = new System.Drawing.Size(104, 17);
            this.stateAmountMonteCarloLlabel.TabIndex = 9;
            this.stateAmountMonteCarloLlabel.Text = "States Amount:";
            // 
            // randomStatesMonteCarloButton
            // 
            this.randomStatesMonteCarloButton.Location = new System.Drawing.Point(8, 71);
            this.randomStatesMonteCarloButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomStatesMonteCarloButton.Name = "randomStatesMonteCarloButton";
            this.randomStatesMonteCarloButton.Size = new System.Drawing.Size(216, 28);
            this.randomStatesMonteCarloButton.TabIndex = 10;
            this.randomStatesMonteCarloButton.Text = "Random states placement";
            this.randomStatesMonteCarloButton.UseVisualStyleBackColor = true;
            this.randomStatesMonteCarloButton.Click += new System.EventHandler(this.RandomStatesMonteCarloButton_Click);
            // 
            // stateMonteCarloNumericUpDown
            // 
            this.stateMonteCarloNumericUpDown.Location = new System.Drawing.Point(91, 39);
            this.stateMonteCarloNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stateMonteCarloNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.stateMonteCarloNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.stateMonteCarloNumericUpDown.Name = "stateMonteCarloNumericUpDown";
            this.stateMonteCarloNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.stateMonteCarloNumericUpDown.TabIndex = 11;
            this.stateMonteCarloNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // RectystallizationTabPage
            // 
            this.RectystallizationTabPage.Controls.Add(this.removeRecrystallizationStatusButton);
            this.RectystallizationTabPage.Controls.Add(this.groupBox3);
            this.RectystallizationTabPage.Controls.Add(this.groupBox4);
            this.RectystallizationTabPage.Location = new System.Drawing.Point(4, 25);
            this.RectystallizationTabPage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RectystallizationTabPage.Name = "RectystallizationTabPage";
            this.RectystallizationTabPage.Size = new System.Drawing.Size(248, 565);
            this.RectystallizationTabPage.TabIndex = 4;
            this.RectystallizationTabPage.Text = "Recrystallization";
            this.RectystallizationTabPage.UseVisualStyleBackColor = true;
            // 
            // removeRecrystallizationStatusButton
            // 
            this.removeRecrystallizationStatusButton.Location = new System.Drawing.Point(4, 439);
            this.removeRecrystallizationStatusButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.removeRecrystallizationStatusButton.Name = "removeRecrystallizationStatusButton";
            this.removeRecrystallizationStatusButton.Size = new System.Drawing.Size(237, 28);
            this.removeRecrystallizationStatusButton.TabIndex = 26;
            this.removeRecrystallizationStatusButton.Text = "Remove Recrystallization Status";
            this.removeRecrystallizationStatusButton.UseVisualStyleBackColor = true;
            this.removeRecrystallizationStatusButton.Click += new System.EventHandler(this.removeRecrystallizationStatusButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.currentIterationExecutionRecrystallizationTextBox);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.iterationsExecutionRecrystallizationNumericUpDown);
            this.groupBox3.Controls.Add(this.stopExecutionRecrystallizationButton);
            this.groupBox3.Controls.Add(this.runIterationsExecutionRecrystallizationButton);
            this.groupBox3.Controls.Add(this.runExecutionRecrystallizationButton);
            this.groupBox3.Location = new System.Drawing.Point(4, 267);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(236, 165);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Execution";
            // 
            // currentIterationExecutionRecrystallizationTextBox
            // 
            this.currentIterationExecutionRecrystallizationTextBox.Enabled = false;
            this.currentIterationExecutionRecrystallizationTextBox.Location = new System.Drawing.Point(127, 130);
            this.currentIterationExecutionRecrystallizationTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.currentIterationExecutionRecrystallizationTextBox.Name = "currentIterationExecutionRecrystallizationTextBox";
            this.currentIterationExecutionRecrystallizationTextBox.Size = new System.Drawing.Size(100, 22);
            this.currentIterationExecutionRecrystallizationTextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 134);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Current Iteration: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 22);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "Iterations:";
            // 
            // iterationsExecutionRecrystallizationNumericUpDown
            // 
            this.iterationsExecutionRecrystallizationNumericUpDown.Location = new System.Drawing.Point(95, 20);
            this.iterationsExecutionRecrystallizationNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.iterationsExecutionRecrystallizationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.iterationsExecutionRecrystallizationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.iterationsExecutionRecrystallizationNumericUpDown.Name = "iterationsExecutionRecrystallizationNumericUpDown";
            this.iterationsExecutionRecrystallizationNumericUpDown.Size = new System.Drawing.Size(133, 22);
            this.iterationsExecutionRecrystallizationNumericUpDown.TabIndex = 20;
            this.iterationsExecutionRecrystallizationNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // stopExecutionRecrystallizationButton
            // 
            this.stopExecutionRecrystallizationButton.Location = new System.Drawing.Point(124, 87);
            this.stopExecutionRecrystallizationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.stopExecutionRecrystallizationButton.Name = "stopExecutionRecrystallizationButton";
            this.stopExecutionRecrystallizationButton.Size = new System.Drawing.Size(104, 28);
            this.stopExecutionRecrystallizationButton.TabIndex = 18;
            this.stopExecutionRecrystallizationButton.Text = "Stop";
            this.stopExecutionRecrystallizationButton.UseVisualStyleBackColor = true;
            this.stopExecutionRecrystallizationButton.Click += new System.EventHandler(this.stopExecutionRecrystallizationButton_Click);
            // 
            // runIterationsExecutionRecrystallizationButton
            // 
            this.runIterationsExecutionRecrystallizationButton.Location = new System.Drawing.Point(8, 52);
            this.runIterationsExecutionRecrystallizationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runIterationsExecutionRecrystallizationButton.Name = "runIterationsExecutionRecrystallizationButton";
            this.runIterationsExecutionRecrystallizationButton.Size = new System.Drawing.Size(220, 28);
            this.runIterationsExecutionRecrystallizationButton.TabIndex = 21;
            this.runIterationsExecutionRecrystallizationButton.Text = "Run Iterations";
            this.runIterationsExecutionRecrystallizationButton.UseVisualStyleBackColor = true;
            this.runIterationsExecutionRecrystallizationButton.Click += new System.EventHandler(this.runIterationsExecutionRecrystallizationButton_Click);
            // 
            // runExecutionRecrystallizationButton
            // 
            this.runExecutionRecrystallizationButton.Location = new System.Drawing.Point(8, 87);
            this.runExecutionRecrystallizationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.runExecutionRecrystallizationButton.Name = "runExecutionRecrystallizationButton";
            this.runExecutionRecrystallizationButton.Size = new System.Drawing.Size(108, 28);
            this.runExecutionRecrystallizationButton.TabIndex = 17;
            this.runExecutionRecrystallizationButton.Text = "Run";
            this.runExecutionRecrystallizationButton.UseVisualStyleBackColor = true;
            this.runExecutionRecrystallizationButton.Click += new System.EventHandler(this.runExecutionRecrystallizationButton_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.gbSizePropertiesRecrystallizationumericUpDown);
            this.groupBox4.Controls.Add(this.applayPlacePropertiesRecrystallizationComboBox);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.applayModeRecrystallizationComboBox);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.randomPlacementPropertiesRecrystallizationButton);
            this.groupBox4.Controls.Add(this.statesAmountPropertiesRecrystallizationNumericUpDown);
            this.groupBox4.Location = new System.Drawing.Point(4, 4);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(233, 256);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Properties";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 166);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 16;
            this.label10.Text = "GB Size:";
            // 
            // gbSizePropertiesRecrystallizationumericUpDown
            // 
            this.gbSizePropertiesRecrystallizationumericUpDown.Location = new System.Drawing.Point(63, 186);
            this.gbSizePropertiesRecrystallizationumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbSizePropertiesRecrystallizationumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.gbSizePropertiesRecrystallizationumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gbSizePropertiesRecrystallizationumericUpDown.Name = "gbSizePropertiesRecrystallizationumericUpDown";
            this.gbSizePropertiesRecrystallizationumericUpDown.Size = new System.Drawing.Size(161, 22);
            this.gbSizePropertiesRecrystallizationumericUpDown.TabIndex = 17;
            this.gbSizePropertiesRecrystallizationumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // applayPlacePropertiesRecrystallizationComboBox
            // 
            this.applayPlacePropertiesRecrystallizationComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Anywhere",
            "Grain Boundaries"});
            this.applayPlacePropertiesRecrystallizationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.applayPlacePropertiesRecrystallizationComboBox.FormattingEnabled = true;
            this.applayPlacePropertiesRecrystallizationComboBox.Items.AddRange(new object[] {
            "Anywhere",
            "Grain Boundaries"});
            this.applayPlacePropertiesRecrystallizationComboBox.Location = new System.Drawing.Point(63, 137);
            this.applayPlacePropertiesRecrystallizationComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applayPlacePropertiesRecrystallizationComboBox.Name = "applayPlacePropertiesRecrystallizationComboBox";
            this.applayPlacePropertiesRecrystallizationComboBox.Size = new System.Drawing.Size(160, 24);
            this.applayPlacePropertiesRecrystallizationComboBox.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 117);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = "Apply Place:";
            // 
            // applayModeRecrystallizationComboBox
            // 
            this.applayModeRecrystallizationComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.applayModeRecrystallizationComboBox.FormattingEnabled = true;
            this.applayModeRecrystallizationComboBox.Items.AddRange(new object[] {
            "Constant",
            "Increasing",
            "Manually"});
            this.applayModeRecrystallizationComboBox.Location = new System.Drawing.Point(63, 87);
            this.applayModeRecrystallizationComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.applayModeRecrystallizationComboBox.Name = "applayModeRecrystallizationComboBox";
            this.applayModeRecrystallizationComboBox.Size = new System.Drawing.Size(160, 24);
            this.applayModeRecrystallizationComboBox.TabIndex = 13;
            this.applayModeRecrystallizationComboBox.SelectedIndexChanged += new System.EventHandler(this.applayModeRecrystallizationComboBox_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 68);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Applay Mode:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "States Amount:";
            // 
            // randomPlacementPropertiesRecrystallizationButton
            // 
            this.randomPlacementPropertiesRecrystallizationButton.Location = new System.Drawing.Point(9, 218);
            this.randomPlacementPropertiesRecrystallizationButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.randomPlacementPropertiesRecrystallizationButton.Name = "randomPlacementPropertiesRecrystallizationButton";
            this.randomPlacementPropertiesRecrystallizationButton.Size = new System.Drawing.Size(216, 28);
            this.randomPlacementPropertiesRecrystallizationButton.TabIndex = 10;
            this.randomPlacementPropertiesRecrystallizationButton.Text = "Place Nucleons";
            this.randomPlacementPropertiesRecrystallizationButton.UseVisualStyleBackColor = true;
            this.randomPlacementPropertiesRecrystallizationButton.Click += new System.EventHandler(this.randomPlacementPropertiesRecrystallizationButton_Click);
            // 
            // statesAmountPropertiesRecrystallizationNumericUpDown
            // 
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Location = new System.Drawing.Point(63, 39);
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Name = "statesAmountPropertiesRecrystallizationNumericUpDown";
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Size = new System.Drawing.Size(161, 22);
            this.statesAmountPropertiesRecrystallizationNumericUpDown.TabIndex = 11;
            this.statesAmountPropertiesRecrystallizationNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // mouseModeLabel
            // 
            this.mouseModeLabel.Location = new System.Drawing.Point(688, 613);
            this.mouseModeLabel.Name = "mouseModeLabel";
            this.mouseModeLabel.Size = new System.Drawing.Size(255, 20);
            this.mouseModeLabel.TabIndex = 16;
            this.mouseModeLabel.Text = "Mouse mode:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 642);
            this.Controls.Add(this.mouseModeLabel);
            this.Controls.Add(this.menuTabControl);
            this.Controls.Add(this.viewPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Menu = this.mainMenu1;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MultiscaleModeling";
            this.viewPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).EndInit();
            this.viewGroupBox.ResumeLayout(false);
            this.viewGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).EndInit();
            this.gridPropertiesGroupBox.ResumeLayout(false);
            this.gridPropertiesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightSizeGridPropertiesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSizeGridPropertiesNumericUpDown)).EndInit();
            this.caGroupBox.ResumeLayout(false);
            this.caGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.probabilityCAPropertiesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).EndInit();
            this.executionGroupBox.ResumeLayout(false);
            this.executionGroupBox.PerformLayout();
            this.menuTabControl.ResumeLayout(false);
            this.propertiesTabPage.ResumeLayout(false);
            this.executionTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amountInsclusionsNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueInclusionsNumericUpDown)).EndInit();
            this.substructureTabPage.ResumeLayout(false);
            this.grainBoundariesGroupBox.ResumeLayout(false);
            this.grainBoundariesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizePropertiesGrainBoundariesNumericUpDown)).EndInit();
            this.substructureGroupBox.ResumeLayout(false);
            this.substructureGroupBox.PerformLayout();
            this.monteCarloTabPage.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSizePropertiesMonteCarloNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.energyValuePropertiesMonteCarloNumericUpDown)).EndInit();
            this.executionMonteCarloGroupBox.ResumeLayout(false);
            this.executionMonteCarloGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsNumberNumericUpDown)).EndInit();
            this.propertiesMonteCarloGroupBox.ResumeLayout(false);
            this.propertiesMonteCarloGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stateMonteCarloNumericUpDown)).EndInit();
            this.RectystallizationTabPage.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iterationsExecutionRecrystallizationNumericUpDown)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gbSizePropertiesRecrystallizationumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statesAmountPropertiesRecrystallizationNumericUpDown)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label caSimulationCAPropertiesLabel;
        private System.Windows.Forms.Button stopCAExecutionButton;
        private System.Windows.Forms.Button runCAExecutionButton;
        private System.Windows.Forms.GroupBox executionGroupBox;
        private System.Windows.Forms.ProgressBar caExecutionProgressBar;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem openFileMenuItem;
        private System.Windows.Forms.MenuItem jsonOpenFileMenuItem;
        private System.Windows.Forms.MenuItem bitmapOpenFileMenuItem;
        private System.Windows.Forms.MenuItem saveFileMenuItem;
        private System.Windows.Forms.MenuItem jsonSaveFileMenuItem;
        private System.Windows.Forms.MenuItem bitmapSaveFileMenuItem;
        private System.Windows.Forms.TabControl menuTabControl;
        private System.Windows.Forms.TabPage propertiesTabPage;
        private System.Windows.Forms.TabPage executionTabPage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown valueInclusionsNumericUpDown;
        private System.Windows.Forms.Label valueInclusionsLabel;
        private System.Windows.Forms.ComboBox typeInclusionsComboBox;
        private System.Windows.Forms.Label tyoeInclusionsLabel;
        private System.Windows.Forms.Button generateInclusionsButton;
        private System.Windows.Forms.NumericUpDown amountInsclusionsNumericUpDown;
        private System.Windows.Forms.Label amountInclusionsLabel;
        private System.Windows.Forms.NumericUpDown probabilityCAPropertiesNumericUpDown;
        private System.Windows.Forms.Label probabilityCAPropertiesLabel;
        private System.Windows.Forms.TabPage substructureTabPage;
        private System.Windows.Forms.Button clearSubstructureButton;
        private System.Windows.Forms.ComboBox selectionTypeSubstructureComboBox;
        private System.Windows.Forms.Label selectionTypeSubstructureLabel;
        private System.Windows.Forms.GroupBox grainBoundariesGroupBox;
        private System.Windows.Forms.TextBox gbPercentTextBox;
        private System.Windows.Forms.Label sizePropertiesGrainBoundariesLabel;
        private System.Windows.Forms.Label selectionModePropertiesGrainBoundariesLabel;
        private System.Windows.Forms.Label gbPercentPropertiesGrainBoundariesLabel;
        private System.Windows.Forms.Button generatePropertiesGrainBoundariesButtonButton;
        private System.Windows.Forms.NumericUpDown sizePropertiesGrainBoundariesNumericUpDown;
        private System.Windows.Forms.ComboBox selectionModePropertiesGrainBoundariesComboBox;
        private System.Windows.Forms.GroupBox substructureGroupBox;
        private System.Windows.Forms.Label mouseModeLabel;
        private System.Windows.Forms.TabPage monteCarloTabPage;
        private System.Windows.Forms.NumericUpDown stateMonteCarloNumericUpDown;
        private System.Windows.Forms.Button randomStatesMonteCarloButton;
        private System.Windows.Forms.Label stateAmountMonteCarloLlabel;
        private System.Windows.Forms.GroupBox executionMonteCarloGroupBox;
        private System.Windows.Forms.TextBox currentIterationNumberMonteCarloTextBox;
        private System.Windows.Forms.Label currentIterationMonteCarloLabel;
        private System.Windows.Forms.Label iterationsMonteCarloLabel;
        private System.Windows.Forms.NumericUpDown iterationsNumberNumericUpDown;
        private System.Windows.Forms.Button stopMonteCarloButton;
        private System.Windows.Forms.Button runIterationsMonteCarloButton;
        private System.Windows.Forms.Button runMonteCarloButton;
        private System.Windows.Forms.GroupBox propertiesMonteCarloGroupBox;
        private System.Windows.Forms.RadioButton energyViewPropertiesRadioButton;
        private System.Windows.Forms.RadioButton grainViewPropertiesRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox setEnergyModePropertiesMonteCarloComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button setEnergyValueButton;
        private System.Windows.Forms.NumericUpDown energyValuePropertiesMonteCarloNumericUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown gbSizePropertiesMonteCarloNumericUpDown;
        private System.Windows.Forms.RadioButton energyNeighborhoodRadioButton;
        private System.Windows.Forms.TabPage RectystallizationTabPage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox currentIterationExecutionRecrystallizationTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown iterationsExecutionRecrystallizationNumericUpDown;
        private System.Windows.Forms.Button stopExecutionRecrystallizationButton;
        private System.Windows.Forms.Button runIterationsExecutionRecrystallizationButton;
        private System.Windows.Forms.Button runExecutionRecrystallizationButton;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown gbSizePropertiesRecrystallizationumericUpDown;
        private System.Windows.Forms.ComboBox applayPlacePropertiesRecrystallizationComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox applayModeRecrystallizationComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button randomPlacementPropertiesRecrystallizationButton;
        private System.Windows.Forms.NumericUpDown statesAmountPropertiesRecrystallizationNumericUpDown;
        private System.Windows.Forms.Button removeRecrystallizationStatusButton;
    }
}

