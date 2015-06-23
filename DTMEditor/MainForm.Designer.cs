namespace DTMEditor
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
			this.frameListBox = new System.Windows.Forms.ListBox();
			this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openDTMMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.buttonGroupBox = new System.Windows.Forms.GroupBox();
			this.buttonFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.aButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.bButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.xButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.yButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.zButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.dpadGroupBox = new System.Windows.Forms.GroupBox();
			this.dpadFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
			this.dpadUpCheckBox = new System.Windows.Forms.CheckBox();
			this.dpadDownCheckBox = new System.Windows.Forms.CheckBox();
			this.dpadLeftCheckBox = new System.Windows.Forms.CheckBox();
			this.dpadRightCheckBox = new System.Windows.Forms.CheckBox();
			this.mainStickGroupBox = new System.Windows.Forms.GroupBox();
			this.mainStickTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.mainStickYAxisLabel = new System.Windows.Forms.Label();
			this.mainStickXAxisUpDown = new System.Windows.Forms.NumericUpDown();
			this.mainStickYAxisUpDown = new System.Windows.Forms.NumericUpDown();
			this.mainStickXAxisLabel = new System.Windows.Forms.Label();
			this.cstickGroupBox = new System.Windows.Forms.GroupBox();
			this.cstickTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.cstickYAxisUpDown = new System.Windows.Forms.NumericUpDown();
			this.cstickYAxisLabel = new System.Windows.Forms.Label();
			this.cstickXAxisUpDown = new System.Windows.Forms.NumericUpDown();
			this.cstickXAxisLabel = new System.Windows.Forms.Label();
			this.triggerGroupBox = new System.Windows.Forms.GroupBox();
			this.triggerTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.leftTriggerUpDown = new System.Windows.Forms.NumericUpDown();
			this.rightTriggerLabel = new System.Windows.Forms.Label();
			this.rightTriggerUpDown = new System.Windows.Forms.NumericUpDown();
			this.leftTriggerLabel = new System.Windows.Forms.Label();
			this.pairTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.mainMenuStrip.SuspendLayout();
			this.buttonGroupBox.SuspendLayout();
			this.buttonFlowLayout.SuspendLayout();
			this.dpadGroupBox.SuspendLayout();
			this.dpadFlowLayout.SuspendLayout();
			this.mainStickGroupBox.SuspendLayout();
			this.mainStickTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainStickXAxisUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.mainStickYAxisUpDown)).BeginInit();
			this.cstickGroupBox.SuspendLayout();
			this.cstickTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cstickYAxisUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cstickXAxisUpDown)).BeginInit();
			this.triggerGroupBox.SuspendLayout();
			this.triggerTableLayout.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftTriggerUpDown)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rightTriggerUpDown)).BeginInit();
			this.pairTableLayout.SuspendLayout();
			this.SuspendLayout();
			// 
			// frameListBox
			// 
			this.frameListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.frameListBox.FormattingEnabled = true;
			this.frameListBox.Location = new System.Drawing.Point(12, 38);
			this.frameListBox.Name = "frameListBox";
			this.frameListBox.Size = new System.Drawing.Size(135, 355);
			this.frameListBox.TabIndex = 0;
			this.frameListBox.SelectedIndexChanged += new System.EventHandler(this.frameListBox_SelectedIndexChanged);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.mainMenuStrip.Name = "mainMenuStrip";
			this.mainMenuStrip.Size = new System.Drawing.Size(434, 24);
			this.mainMenuStrip.TabIndex = 1;
			this.mainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openDTMMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openDTMMenuItem
			// 
			this.openDTMMenuItem.Name = "openDTMMenuItem";
			this.openDTMMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
			this.openDTMMenuItem.Size = new System.Drawing.Size(195, 22);
			this.openDTMMenuItem.Text = "Open DTM";
			this.openDTMMenuItem.Click += new System.EventHandler(this.openDTMMenuItem_Click);
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Name = "saveMenuItem";
			this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
			this.saveMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveMenuItem.Text = "Save";
			this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
			// 
			// saveAsMenuItem
			// 
			this.saveAsMenuItem.Name = "saveAsMenuItem";
			this.saveAsMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
			this.saveAsMenuItem.Size = new System.Drawing.Size(195, 22);
			this.saveAsMenuItem.Text = "Save As...";
			this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			this.exitMenuItem.Size = new System.Drawing.Size(195, 22);
			this.exitMenuItem.Text = "Exit";
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// buttonGroupBox
			// 
			this.buttonGroupBox.Controls.Add(this.buttonFlowLayout);
			this.buttonGroupBox.Location = new System.Drawing.Point(153, 38);
			this.buttonGroupBox.Name = "buttonGroupBox";
			this.buttonGroupBox.Size = new System.Drawing.Size(268, 40);
			this.buttonGroupBox.TabIndex = 2;
			this.buttonGroupBox.TabStop = false;
			this.buttonGroupBox.Text = "Buttons";
			// 
			// buttonFlowLayout
			// 
			this.buttonFlowLayout.Controls.Add(this.aButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.bButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.xButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.yButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.zButtonCheckBox);
			this.buttonFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.buttonFlowLayout.Location = new System.Drawing.Point(3, 16);
			this.buttonFlowLayout.Name = "buttonFlowLayout";
			this.buttonFlowLayout.Size = new System.Drawing.Size(262, 21);
			this.buttonFlowLayout.TabIndex = 0;
			// 
			// aButtonCheckBox
			// 
			this.aButtonCheckBox.AutoSize = true;
			this.aButtonCheckBox.Location = new System.Drawing.Point(3, 3);
			this.aButtonCheckBox.Name = "aButtonCheckBox";
			this.aButtonCheckBox.Size = new System.Drawing.Size(33, 17);
			this.aButtonCheckBox.TabIndex = 0;
			this.aButtonCheckBox.Text = "A";
			this.aButtonCheckBox.UseVisualStyleBackColor = true;
			// 
			// bButtonCheckBox
			// 
			this.bButtonCheckBox.AutoSize = true;
			this.bButtonCheckBox.Location = new System.Drawing.Point(42, 3);
			this.bButtonCheckBox.Name = "bButtonCheckBox";
			this.bButtonCheckBox.Size = new System.Drawing.Size(33, 17);
			this.bButtonCheckBox.TabIndex = 1;
			this.bButtonCheckBox.Text = "B";
			this.bButtonCheckBox.UseVisualStyleBackColor = true;
			// 
			// xButtonCheckBox
			// 
			this.xButtonCheckBox.AutoSize = true;
			this.xButtonCheckBox.Location = new System.Drawing.Point(81, 3);
			this.xButtonCheckBox.Name = "xButtonCheckBox";
			this.xButtonCheckBox.Size = new System.Drawing.Size(33, 17);
			this.xButtonCheckBox.TabIndex = 2;
			this.xButtonCheckBox.Text = "X";
			this.xButtonCheckBox.UseVisualStyleBackColor = true;
			// 
			// yButtonCheckBox
			// 
			this.yButtonCheckBox.AutoSize = true;
			this.yButtonCheckBox.Location = new System.Drawing.Point(120, 3);
			this.yButtonCheckBox.Name = "yButtonCheckBox";
			this.yButtonCheckBox.Size = new System.Drawing.Size(33, 17);
			this.yButtonCheckBox.TabIndex = 3;
			this.yButtonCheckBox.Text = "Y";
			this.yButtonCheckBox.UseVisualStyleBackColor = true;
			// 
			// zButtonCheckBox
			// 
			this.zButtonCheckBox.AutoSize = true;
			this.zButtonCheckBox.Location = new System.Drawing.Point(159, 3);
			this.zButtonCheckBox.Name = "zButtonCheckBox";
			this.zButtonCheckBox.Size = new System.Drawing.Size(33, 17);
			this.zButtonCheckBox.TabIndex = 4;
			this.zButtonCheckBox.Text = "Z";
			this.zButtonCheckBox.UseVisualStyleBackColor = true;
			// 
			// dpadGroupBox
			// 
			this.dpadGroupBox.Controls.Add(this.dpadFlowLayout);
			this.dpadGroupBox.Location = new System.Drawing.Point(153, 85);
			this.dpadGroupBox.Name = "dpadGroupBox";
			this.dpadGroupBox.Size = new System.Drawing.Size(268, 40);
			this.dpadGroupBox.TabIndex = 3;
			this.dpadGroupBox.TabStop = false;
			this.dpadGroupBox.Text = "D-Pad";
			// 
			// dpadFlowLayout
			// 
			this.dpadFlowLayout.Controls.Add(this.dpadUpCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadDownCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadLeftCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadRightCheckBox);
			this.dpadFlowLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dpadFlowLayout.Location = new System.Drawing.Point(3, 16);
			this.dpadFlowLayout.Name = "dpadFlowLayout";
			this.dpadFlowLayout.Size = new System.Drawing.Size(262, 21);
			this.dpadFlowLayout.TabIndex = 0;
			// 
			// dpadUpCheckBox
			// 
			this.dpadUpCheckBox.AutoSize = true;
			this.dpadUpCheckBox.Location = new System.Drawing.Point(3, 3);
			this.dpadUpCheckBox.Name = "dpadUpCheckBox";
			this.dpadUpCheckBox.Size = new System.Drawing.Size(40, 17);
			this.dpadUpCheckBox.TabIndex = 0;
			this.dpadUpCheckBox.Text = "Up";
			this.dpadUpCheckBox.UseVisualStyleBackColor = true;
			// 
			// dpadDownCheckBox
			// 
			this.dpadDownCheckBox.AutoSize = true;
			this.dpadDownCheckBox.Location = new System.Drawing.Point(49, 3);
			this.dpadDownCheckBox.Name = "dpadDownCheckBox";
			this.dpadDownCheckBox.Size = new System.Drawing.Size(54, 17);
			this.dpadDownCheckBox.TabIndex = 1;
			this.dpadDownCheckBox.Text = "Down";
			this.dpadDownCheckBox.UseVisualStyleBackColor = true;
			// 
			// dpadLeftCheckBox
			// 
			this.dpadLeftCheckBox.AutoSize = true;
			this.dpadLeftCheckBox.Location = new System.Drawing.Point(109, 3);
			this.dpadLeftCheckBox.Name = "dpadLeftCheckBox";
			this.dpadLeftCheckBox.Size = new System.Drawing.Size(44, 17);
			this.dpadLeftCheckBox.TabIndex = 2;
			this.dpadLeftCheckBox.Text = "Left";
			this.dpadLeftCheckBox.UseVisualStyleBackColor = true;
			// 
			// dpadRightCheckBox
			// 
			this.dpadRightCheckBox.AutoSize = true;
			this.dpadRightCheckBox.Location = new System.Drawing.Point(159, 3);
			this.dpadRightCheckBox.Name = "dpadRightCheckBox";
			this.dpadRightCheckBox.Size = new System.Drawing.Size(51, 17);
			this.dpadRightCheckBox.TabIndex = 3;
			this.dpadRightCheckBox.Text = "Right";
			this.dpadRightCheckBox.UseVisualStyleBackColor = true;
			// 
			// mainStickGroupBox
			// 
			this.mainStickGroupBox.Controls.Add(this.mainStickTableLayout);
			this.mainStickGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainStickGroupBox.Location = new System.Drawing.Point(3, 3);
			this.mainStickGroupBox.Name = "mainStickGroupBox";
			this.mainStickGroupBox.Size = new System.Drawing.Size(133, 71);
			this.mainStickGroupBox.TabIndex = 4;
			this.mainStickGroupBox.TabStop = false;
			this.mainStickGroupBox.Text = "Main Stick";
			// 
			// mainStickTableLayout
			// 
			this.mainStickTableLayout.ColumnCount = 2;
			this.mainStickTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.mainStickTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.mainStickTableLayout.Controls.Add(this.mainStickYAxisLabel, 0, 1);
			this.mainStickTableLayout.Controls.Add(this.mainStickXAxisUpDown, 1, 0);
			this.mainStickTableLayout.Controls.Add(this.mainStickYAxisUpDown, 1, 1);
			this.mainStickTableLayout.Controls.Add(this.mainStickXAxisLabel, 0, 0);
			this.mainStickTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainStickTableLayout.Location = new System.Drawing.Point(3, 16);
			this.mainStickTableLayout.Name = "mainStickTableLayout";
			this.mainStickTableLayout.RowCount = 2;
			this.mainStickTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainStickTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.mainStickTableLayout.Size = new System.Drawing.Size(127, 52);
			this.mainStickTableLayout.TabIndex = 7;
			// 
			// mainStickYAxisLabel
			// 
			this.mainStickYAxisLabel.AutoSize = true;
			this.mainStickYAxisLabel.Location = new System.Drawing.Point(3, 29);
			this.mainStickYAxisLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.mainStickYAxisLabel.Name = "mainStickYAxisLabel";
			this.mainStickYAxisLabel.Size = new System.Drawing.Size(39, 13);
			this.mainStickYAxisLabel.TabIndex = 2;
			this.mainStickYAxisLabel.Text = "Y-Axis:";
			// 
			// mainStickXAxisUpDown
			// 
			this.mainStickXAxisUpDown.Location = new System.Drawing.Point(45, 3);
			this.mainStickXAxisUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.mainStickXAxisUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.mainStickXAxisUpDown.Name = "mainStickXAxisUpDown";
			this.mainStickXAxisUpDown.Size = new System.Drawing.Size(79, 20);
			this.mainStickXAxisUpDown.TabIndex = 6;
			this.mainStickXAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// mainStickYAxisUpDown
			// 
			this.mainStickYAxisUpDown.Location = new System.Drawing.Point(45, 29);
			this.mainStickYAxisUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.mainStickYAxisUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.mainStickYAxisUpDown.Name = "mainStickYAxisUpDown";
			this.mainStickYAxisUpDown.Size = new System.Drawing.Size(79, 20);
			this.mainStickYAxisUpDown.TabIndex = 7;
			this.mainStickYAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// mainStickXAxisLabel
			// 
			this.mainStickXAxisLabel.AutoSize = true;
			this.mainStickXAxisLabel.Location = new System.Drawing.Point(3, 3);
			this.mainStickXAxisLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.mainStickXAxisLabel.Name = "mainStickXAxisLabel";
			this.mainStickXAxisLabel.Size = new System.Drawing.Size(39, 13);
			this.mainStickXAxisLabel.TabIndex = 0;
			this.mainStickXAxisLabel.Text = "X-Axis:";
			// 
			// cstickGroupBox
			// 
			this.cstickGroupBox.Controls.Add(this.cstickTableLayout);
			this.cstickGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cstickGroupBox.Location = new System.Drawing.Point(142, 3);
			this.cstickGroupBox.Name = "cstickGroupBox";
			this.cstickGroupBox.Size = new System.Drawing.Size(129, 71);
			this.cstickGroupBox.TabIndex = 5;
			this.cstickGroupBox.TabStop = false;
			this.cstickGroupBox.Text = "C-Stick";
			// 
			// cstickTableLayout
			// 
			this.cstickTableLayout.ColumnCount = 2;
			this.cstickTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.cstickTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.cstickTableLayout.Controls.Add(this.cstickYAxisUpDown, 1, 1);
			this.cstickTableLayout.Controls.Add(this.cstickYAxisLabel, 0, 1);
			this.cstickTableLayout.Controls.Add(this.cstickXAxisUpDown, 1, 0);
			this.cstickTableLayout.Controls.Add(this.cstickXAxisLabel, 0, 0);
			this.cstickTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.cstickTableLayout.Location = new System.Drawing.Point(3, 16);
			this.cstickTableLayout.Name = "cstickTableLayout";
			this.cstickTableLayout.RowCount = 2;
			this.cstickTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.cstickTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.cstickTableLayout.Size = new System.Drawing.Size(123, 52);
			this.cstickTableLayout.TabIndex = 7;
			// 
			// cstickYAxisUpDown
			// 
			this.cstickYAxisUpDown.Location = new System.Drawing.Point(45, 29);
			this.cstickYAxisUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.cstickYAxisUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.cstickYAxisUpDown.Name = "cstickYAxisUpDown";
			this.cstickYAxisUpDown.Size = new System.Drawing.Size(75, 20);
			this.cstickYAxisUpDown.TabIndex = 9;
			this.cstickYAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// cstickYAxisLabel
			// 
			this.cstickYAxisLabel.AutoSize = true;
			this.cstickYAxisLabel.Location = new System.Drawing.Point(3, 29);
			this.cstickYAxisLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.cstickYAxisLabel.Name = "cstickYAxisLabel";
			this.cstickYAxisLabel.Size = new System.Drawing.Size(39, 13);
			this.cstickYAxisLabel.TabIndex = 2;
			this.cstickYAxisLabel.Text = "Y-Axis:";
			// 
			// cstickXAxisUpDown
			// 
			this.cstickXAxisUpDown.Location = new System.Drawing.Point(45, 3);
			this.cstickXAxisUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.cstickXAxisUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.cstickXAxisUpDown.Name = "cstickXAxisUpDown";
			this.cstickXAxisUpDown.Size = new System.Drawing.Size(75, 20);
			this.cstickXAxisUpDown.TabIndex = 8;
			this.cstickXAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			// 
			// cstickXAxisLabel
			// 
			this.cstickXAxisLabel.AutoSize = true;
			this.cstickXAxisLabel.Location = new System.Drawing.Point(3, 3);
			this.cstickXAxisLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.cstickXAxisLabel.Name = "cstickXAxisLabel";
			this.cstickXAxisLabel.Size = new System.Drawing.Size(39, 13);
			this.cstickXAxisLabel.TabIndex = 0;
			this.cstickXAxisLabel.Text = "X-Axis:";
			// 
			// triggerGroupBox
			// 
			this.triggerGroupBox.Controls.Add(this.triggerTableLayout);
			this.triggerGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.triggerGroupBox.Location = new System.Drawing.Point(3, 80);
			this.triggerGroupBox.Name = "triggerGroupBox";
			this.triggerGroupBox.Size = new System.Drawing.Size(133, 74);
			this.triggerGroupBox.TabIndex = 6;
			this.triggerGroupBox.TabStop = false;
			this.triggerGroupBox.Text = "Triggers";
			// 
			// triggerTableLayout
			// 
			this.triggerTableLayout.ColumnCount = 2;
			this.triggerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.triggerTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.triggerTableLayout.Controls.Add(this.leftTriggerUpDown, 1, 0);
			this.triggerTableLayout.Controls.Add(this.rightTriggerLabel, 0, 1);
			this.triggerTableLayout.Controls.Add(this.rightTriggerUpDown, 1, 1);
			this.triggerTableLayout.Controls.Add(this.leftTriggerLabel, 0, 0);
			this.triggerTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
			this.triggerTableLayout.Location = new System.Drawing.Point(3, 16);
			this.triggerTableLayout.Name = "triggerTableLayout";
			this.triggerTableLayout.RowCount = 2;
			this.triggerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.triggerTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.triggerTableLayout.Size = new System.Drawing.Size(127, 55);
			this.triggerTableLayout.TabIndex = 7;
			// 
			// leftTriggerUpDown
			// 
			this.leftTriggerUpDown.Location = new System.Drawing.Point(24, 3);
			this.leftTriggerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.leftTriggerUpDown.Name = "leftTriggerUpDown";
			this.leftTriggerUpDown.Size = new System.Drawing.Size(100, 20);
			this.leftTriggerUpDown.TabIndex = 2;
			// 
			// rightTriggerLabel
			// 
			this.rightTriggerLabel.AutoSize = true;
			this.rightTriggerLabel.Location = new System.Drawing.Point(3, 29);
			this.rightTriggerLabel.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
			this.rightTriggerLabel.Name = "rightTriggerLabel";
			this.rightTriggerLabel.Size = new System.Drawing.Size(18, 13);
			this.rightTriggerLabel.TabIndex = 1;
			this.rightTriggerLabel.Text = "R:";
			// 
			// rightTriggerUpDown
			// 
			this.rightTriggerUpDown.Location = new System.Drawing.Point(24, 29);
			this.rightTriggerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.rightTriggerUpDown.Name = "rightTriggerUpDown";
			this.rightTriggerUpDown.Size = new System.Drawing.Size(100, 20);
			this.rightTriggerUpDown.TabIndex = 3;
			// 
			// leftTriggerLabel
			// 
			this.leftTriggerLabel.AutoSize = true;
			this.leftTriggerLabel.Location = new System.Drawing.Point(3, 3);
			this.leftTriggerLabel.Margin = new System.Windows.Forms.Padding(3, 3, 1, 0);
			this.leftTriggerLabel.Name = "leftTriggerLabel";
			this.leftTriggerLabel.Size = new System.Drawing.Size(16, 13);
			this.leftTriggerLabel.TabIndex = 0;
			this.leftTriggerLabel.Text = "L:";
			// 
			// pairTableLayout
			// 
			this.pairTableLayout.AutoSize = true;
			this.pairTableLayout.ColumnCount = 2;
			this.pairTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.pairTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.pairTableLayout.Controls.Add(this.mainStickGroupBox, 0, 0);
			this.pairTableLayout.Controls.Add(this.triggerGroupBox, 0, 1);
			this.pairTableLayout.Controls.Add(this.cstickGroupBox, 1, 0);
			this.pairTableLayout.Location = new System.Drawing.Point(150, 128);
			this.pairTableLayout.Name = "pairTableLayout";
			this.pairTableLayout.RowCount = 2;
			this.pairTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.pairTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 80F));
			this.pairTableLayout.Size = new System.Drawing.Size(274, 157);
			this.pairTableLayout.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 404);
			this.Controls.Add(this.pairTableLayout);
			this.Controls.Add(this.dpadGroupBox);
			this.Controls.Add(this.buttonGroupBox);
			this.Controls.Add(this.frameListBox);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "DTM Editor";
			this.mainMenuStrip.ResumeLayout(false);
			this.mainMenuStrip.PerformLayout();
			this.buttonGroupBox.ResumeLayout(false);
			this.buttonFlowLayout.ResumeLayout(false);
			this.buttonFlowLayout.PerformLayout();
			this.dpadGroupBox.ResumeLayout(false);
			this.dpadFlowLayout.ResumeLayout(false);
			this.dpadFlowLayout.PerformLayout();
			this.mainStickGroupBox.ResumeLayout(false);
			this.mainStickTableLayout.ResumeLayout(false);
			this.mainStickTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.mainStickXAxisUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.mainStickYAxisUpDown)).EndInit();
			this.cstickGroupBox.ResumeLayout(false);
			this.cstickTableLayout.ResumeLayout(false);
			this.cstickTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.cstickYAxisUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cstickXAxisUpDown)).EndInit();
			this.triggerGroupBox.ResumeLayout(false);
			this.triggerTableLayout.ResumeLayout(false);
			this.triggerTableLayout.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.leftTriggerUpDown)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rightTriggerUpDown)).EndInit();
			this.pairTableLayout.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox frameListBox;
		private System.Windows.Forms.MenuStrip mainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openDTMMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
		private System.Windows.Forms.GroupBox buttonGroupBox;
		private System.Windows.Forms.FlowLayoutPanel buttonFlowLayout;
		private System.Windows.Forms.CheckBox aButtonCheckBox;
		private System.Windows.Forms.CheckBox bButtonCheckBox;
		private System.Windows.Forms.CheckBox xButtonCheckBox;
		private System.Windows.Forms.CheckBox yButtonCheckBox;
		private System.Windows.Forms.CheckBox zButtonCheckBox;
		private System.Windows.Forms.GroupBox dpadGroupBox;
		private System.Windows.Forms.FlowLayoutPanel dpadFlowLayout;
		private System.Windows.Forms.CheckBox dpadUpCheckBox;
		private System.Windows.Forms.CheckBox dpadDownCheckBox;
		private System.Windows.Forms.CheckBox dpadLeftCheckBox;
		private System.Windows.Forms.CheckBox dpadRightCheckBox;
		private System.Windows.Forms.GroupBox mainStickGroupBox;
		private System.Windows.Forms.Label mainStickXAxisLabel;
		private System.Windows.Forms.Label mainStickYAxisLabel;
		private System.Windows.Forms.GroupBox cstickGroupBox;
		private System.Windows.Forms.Label cstickYAxisLabel;
		private System.Windows.Forms.Label cstickXAxisLabel;
		private System.Windows.Forms.NumericUpDown mainStickYAxisUpDown;
		private System.Windows.Forms.NumericUpDown mainStickXAxisUpDown;
		private System.Windows.Forms.NumericUpDown cstickYAxisUpDown;
		private System.Windows.Forms.NumericUpDown cstickXAxisUpDown;
		private System.Windows.Forms.GroupBox triggerGroupBox;
		private System.Windows.Forms.Label leftTriggerLabel;
		private System.Windows.Forms.Label rightTriggerLabel;
		private System.Windows.Forms.NumericUpDown rightTriggerUpDown;
		private System.Windows.Forms.NumericUpDown leftTriggerUpDown;
		private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.TableLayoutPanel triggerTableLayout;
		private System.Windows.Forms.TableLayoutPanel mainStickTableLayout;
		private System.Windows.Forms.TableLayoutPanel cstickTableLayout;
		private System.Windows.Forms.TableLayoutPanel pairTableLayout;
	}
}

