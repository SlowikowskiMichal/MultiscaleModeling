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
            this.heightSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.widthSizeGridPropertiesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.clearSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.resizeSizeGridPropertiesButton = new System.Windows.Forms.Button();
            this.heightSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.widthSizeGridPropertiesLabel = new System.Windows.Forms.Label();
            this.sizegGridPropertiesSLabel = new System.Windows.Forms.Label();
            this.caGroupBox = new System.Windows.Forms.GroupBox();
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
            this.tyoeInclusionsLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.typeInclusionsComboBox = new System.Windows.Forms.ComboBox();
            this.valueInclusionsLabel = new System.Windows.Forms.Label();
            this.valueInclusionsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.viewPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPictureBox)).BeginInit();
            this.viewGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewZoomTrackBar)).BeginInit();
            this.gridPropertiesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightSizeGridPropertiesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthSizeGridPropertiesNumericUpDown)).BeginInit();
            this.caGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).BeginInit();
            this.executionGroupBox.SuspendLayout();
            this.menuTabControl.SuspendLayout();
            this.propertiesTabPage.SuspendLayout();
            this.executionTabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueInclusionsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // viewPanel
            // 
            this.viewPanel.Controls.Add(this.viewPictureBox);
            this.viewPanel.Location = new System.Drawing.Point(9, 12);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(500, 500);
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
            this.viewPictureBox.Click += new System.EventHandler(this.ViewPictureBox_Click);
            this.viewPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.ViewPictureBox_Paint);
            // 
            // viewGroupBox
            // 
            this.viewGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.viewGroupBox.Controls.Add(this.viewGridCheckBox);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBarLabel);
            this.viewGroupBox.Controls.Add(this.viewZoomTrackBar);
            this.viewGroupBox.Location = new System.Drawing.Point(4, 309);
            this.viewGroupBox.Name = "viewGroupBox";
            this.viewGroupBox.Size = new System.Drawing.Size(174, 91);
            this.viewGroupBox.TabIndex = 1;
            this.viewGroupBox.TabStop = false;
            this.viewGroupBox.Text = "View";
            this.viewGroupBox.Visible = false;
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
            this.gridPropertiesGroupBox.Location = new System.Drawing.Point(4, 6);
            this.gridPropertiesGroupBox.Name = "gridPropertiesGroupBox";
            this.gridPropertiesGroupBox.Size = new System.Drawing.Size(174, 117);
            this.gridPropertiesGroupBox.TabIndex = 2;
            this.gridPropertiesGroupBox.TabStop = false;
            this.gridPropertiesGroupBox.Text = "Grid Properties";
            // 
            // heightSizeGridPropertiesNumericUpDown
            // 
            this.heightSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 60);
            this.heightSizeGridPropertiesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.heightSizeGridPropertiesNumericUpDown.Name = "heightSizeGridPropertiesNumericUpDown";
            this.heightSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.heightSizeGridPropertiesNumericUpDown.TabIndex = 10;
            this.heightSizeGridPropertiesNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // widthSizeGridPropertiesNumericUpDown
            // 
            this.widthSizeGridPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 38);
            this.widthSizeGridPropertiesNumericUpDown.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.widthSizeGridPropertiesNumericUpDown.Name = "widthSizeGridPropertiesNumericUpDown";
            this.widthSizeGridPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
            this.widthSizeGridPropertiesNumericUpDown.TabIndex = 9;
            this.widthSizeGridPropertiesNumericUpDown.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // clearSizeGridPropertiesButton
            // 
            this.clearSizeGridPropertiesButton.Location = new System.Drawing.Point(93, 85);
            this.clearSizeGridPropertiesButton.Name = "clearSizeGridPropertiesButton";
            this.clearSizeGridPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.clearSizeGridPropertiesButton.TabIndex = 7;
            this.clearSizeGridPropertiesButton.Text = "Clear";
            this.clearSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            this.clearSizeGridPropertiesButton.Click += new System.EventHandler(this.ClearSizeGridPropertiesButton_Click);
            // 
            // resizeSizeGridPropertiesButton
            // 
            this.resizeSizeGridPropertiesButton.Location = new System.Drawing.Point(12, 85);
            this.resizeSizeGridPropertiesButton.Name = "resizeSizeGridPropertiesButton";
            this.resizeSizeGridPropertiesButton.Size = new System.Drawing.Size(75, 23);
            this.resizeSizeGridPropertiesButton.TabIndex = 6;
            this.resizeSizeGridPropertiesButton.Text = "Resize";
            this.resizeSizeGridPropertiesButton.UseVisualStyleBackColor = true;
            this.resizeSizeGridPropertiesButton.Click += new System.EventHandler(this.ResizeSizeGridPropertiesButton_Click);
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
            this.caGroupBox.Location = new System.Drawing.Point(4, 129);
            this.caGroupBox.Name = "caGroupBox";
            this.caGroupBox.Size = new System.Drawing.Size(174, 174);
            this.caGroupBox.TabIndex = 3;
            this.caGroupBox.TabStop = false;
            this.caGroupBox.Text = "Cellural Automata Properties";
            // 
            // nucleonAmoutCAPropertiesNumericUpDown
            // 
            this.nucleonAmoutCAPropertiesNumericUpDown.Location = new System.Drawing.Point(68, 118);
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
            this.nucleonAmoutCAPropertiesNumericUpDown.Size = new System.Drawing.Size(100, 20);
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
            this.randomPlacementButton.Location = new System.Drawing.Point(9, 144);
            this.randomPlacementButton.Name = "randomPlacementButton";
            this.randomPlacementButton.Size = new System.Drawing.Size(159, 23);
            this.randomPlacementButton.TabIndex = 7;
            this.randomPlacementButton.Text = "Random nucleon placement";
            this.randomPlacementButton.UseVisualStyleBackColor = true;
            this.randomPlacementButton.Click += new System.EventHandler(this.RandomPlacementButton_Click);
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
            // boundaryConditionPropertiesComboBoxLabel
            // 
            this.boundaryConditionPropertiesComboBoxLabel.AutoSize = true;
            this.boundaryConditionPropertiesComboBoxLabel.Location = new System.Drawing.Point(6, 22);
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
            "Periodic"});
            this.boundaryConditionCAPropertiesComboBox.Location = new System.Drawing.Point(68, 38);
            this.boundaryConditionCAPropertiesComboBox.Name = "boundaryConditionCAPropertiesComboBox";
            this.boundaryConditionCAPropertiesComboBox.Size = new System.Drawing.Size(100, 21);
            this.boundaryConditionCAPropertiesComboBox.TabIndex = 2;
            // 
            // neighbourhoodCAPropertiesComboBoxLabel
            // 
            this.neighbourhoodCAPropertiesComboBoxLabel.AutoSize = true;
            this.neighbourhoodCAPropertiesComboBoxLabel.Location = new System.Drawing.Point(6, 62);
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
            "Moore"});
            this.neighbourhoodCAPropertiesComboBox.Location = new System.Drawing.Point(68, 78);
            this.neighbourhoodCAPropertiesComboBox.Name = "neighbourhoodCAPropertiesComboBox";
            this.neighbourhoodCAPropertiesComboBox.Size = new System.Drawing.Size(100, 21);
            this.neighbourhoodCAPropertiesComboBox.TabIndex = 0;
            // 
            // runCAExecutionButton
            // 
            this.runCAExecutionButton.Location = new System.Drawing.Point(6, 34);
            this.runCAExecutionButton.Name = "runCAExecutionButton";
            this.runCAExecutionButton.Size = new System.Drawing.Size(80, 23);
            this.runCAExecutionButton.TabIndex = 9;
            this.runCAExecutionButton.Text = "Run";
            this.runCAExecutionButton.UseVisualStyleBackColor = true;
            this.runCAExecutionButton.Click += new System.EventHandler(this.RunCAExecutionButton_Click);
            // 
            // stopCAExecutionButton
            // 
            this.stopCAExecutionButton.Location = new System.Drawing.Point(88, 34);
            this.stopCAExecutionButton.Name = "stopCAExecutionButton";
            this.stopCAExecutionButton.Size = new System.Drawing.Size(80, 23);
            this.stopCAExecutionButton.TabIndex = 10;
            this.stopCAExecutionButton.Text = "Stop";
            this.stopCAExecutionButton.UseVisualStyleBackColor = true;
            this.stopCAExecutionButton.Click += new System.EventHandler(this.StopCAExecutionButton_Click);
            // 
            // caSimulationCAPropertiesLabel
            // 
            this.caSimulationCAPropertiesLabel.AutoSize = true;
            this.caSimulationCAPropertiesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caSimulationCAPropertiesLabel.Location = new System.Drawing.Point(9, 16);
            this.caSimulationCAPropertiesLabel.Name = "caSimulationCAPropertiesLabel";
            this.caSimulationCAPropertiesLabel.Size = new System.Drawing.Size(105, 15);
            this.caSimulationCAPropertiesLabel.TabIndex = 11;
            this.caSimulationCAPropertiesLabel.Text = "CA Simulation: ";
            // 
            // executionGroupBox
            // 
            this.executionGroupBox.Controls.Add(this.caExecutionProgressBar);
            this.executionGroupBox.Controls.Add(this.caSimulationCAPropertiesLabel);
            this.executionGroupBox.Controls.Add(this.runCAExecutionButton);
            this.executionGroupBox.Controls.Add(this.stopCAExecutionButton);
            this.executionGroupBox.Location = new System.Drawing.Point(4, 6);
            this.executionGroupBox.Name = "executionGroupBox";
            this.executionGroupBox.Size = new System.Drawing.Size(174, 100);
            this.executionGroupBox.TabIndex = 14;
            this.executionGroupBox.TabStop = false;
            this.executionGroupBox.Text = "Execution";
            // 
            // caExecutionProgressBar
            // 
            this.caExecutionProgressBar.Location = new System.Drawing.Point(6, 64);
            this.caExecutionProgressBar.Name = "caExecutionProgressBar";
            this.caExecutionProgressBar.Size = new System.Drawing.Size(168, 23);
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
            this.menuTabControl.Location = new System.Drawing.Point(515, 12);
            this.menuTabControl.Name = "menuTabControl";
            this.menuTabControl.SelectedIndex = 0;
            this.menuTabControl.Size = new System.Drawing.Size(192, 500);
            this.menuTabControl.TabIndex = 15;
            // 
            // propertiesTabPage
            // 
            this.propertiesTabPage.Controls.Add(this.gridPropertiesGroupBox);
            this.propertiesTabPage.Controls.Add(this.caGroupBox);
            this.propertiesTabPage.Controls.Add(this.viewGroupBox);
            this.propertiesTabPage.Location = new System.Drawing.Point(4, 22);
            this.propertiesTabPage.Name = "propertiesTabPage";
            this.propertiesTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.propertiesTabPage.Size = new System.Drawing.Size(184, 474);
            this.propertiesTabPage.TabIndex = 0;
            this.propertiesTabPage.Text = "Properties";
            this.propertiesTabPage.UseVisualStyleBackColor = true;
            // 
            // executionTabPage
            // 
            this.executionTabPage.Controls.Add(this.groupBox1);
            this.executionTabPage.Controls.Add(this.executionGroupBox);
            this.executionTabPage.Location = new System.Drawing.Point(4, 22);
            this.executionTabPage.Name = "executionTabPage";
            this.executionTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.executionTabPage.Size = new System.Drawing.Size(184, 474);
            this.executionTabPage.TabIndex = 1;
            this.executionTabPage.Text = "Execution";
            this.executionTabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.valueInclusionsNumericUpDown);
            this.groupBox1.Controls.Add(this.valueInclusionsLabel);
            this.groupBox1.Controls.Add(this.typeInclusionsComboBox);
            this.groupBox1.Controls.Add(this.tyoeInclusionsLabel);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(4, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 115);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inclusions";
            // 
            // tyoeInclusionsLabel
            // 
            this.tyoeInclusionsLabel.AutoSize = true;
            this.tyoeInclusionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tyoeInclusionsLabel.Location = new System.Drawing.Point(24, 22);
            this.tyoeInclusionsLabel.Name = "tyoeInclusionsLabel";
            this.tyoeInclusionsLabel.Size = new System.Drawing.Size(34, 13);
            this.tyoeInclusionsLabel.TabIndex = 11;
            this.tyoeInclusionsLabel.Text = "Type:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // typeInclusionsComboBox
            // 
            this.typeInclusionsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeInclusionsComboBox.FormattingEnabled = true;
            this.typeInclusionsComboBox.Items.AddRange(new object[] {
            "Square",
            "Circle"});
            this.typeInclusionsComboBox.Location = new System.Drawing.Point(64, 19);
            this.typeInclusionsComboBox.Name = "typeInclusionsComboBox";
            this.typeInclusionsComboBox.Size = new System.Drawing.Size(104, 21);
            this.typeInclusionsComboBox.TabIndex = 12;
            // 
            // valueInclusionsLabel
            // 
            this.valueInclusionsLabel.AutoSize = true;
            this.valueInclusionsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueInclusionsLabel.Location = new System.Drawing.Point(15, 59);
            this.valueInclusionsLabel.Name = "valueInclusionsLabel";
            this.valueInclusionsLabel.Size = new System.Drawing.Size(43, 13);
            this.valueInclusionsLabel.TabIndex = 13;
            this.valueInclusionsLabel.Text = "Length:";
            // 
            // valueInclusionsNumericUpDown
            // 
            this.valueInclusionsNumericUpDown.Location = new System.Drawing.Point(64, 57);
            this.valueInclusionsNumericUpDown.Name = "valueInclusionsNumericUpDown";
            this.valueInclusionsNumericUpDown.Size = new System.Drawing.Size(104, 20);
            this.valueInclusionsNumericUpDown.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 522);
            this.Controls.Add(this.menuTabControl);
            this.Controls.Add(this.viewPanel);
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
            ((System.ComponentModel.ISupportInitialize)(this.nucleonAmoutCAPropertiesNumericUpDown)).EndInit();
            this.executionGroupBox.ResumeLayout(false);
            this.executionGroupBox.PerformLayout();
            this.menuTabControl.ResumeLayout(false);
            this.propertiesTabPage.ResumeLayout(false);
            this.executionTabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.valueInclusionsNumericUpDown)).EndInit();
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
        private System.Windows.Forms.Button button1;
    }
}

