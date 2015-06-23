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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
			this.startButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.aButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.bButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.xButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.yButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.zButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.lButtonCheckBox = new System.Windows.Forms.CheckBox();
			this.rButtonCheckBox = new System.Windows.Forms.CheckBox();
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
			resources.ApplyResources(this.frameListBox, "frameListBox");
			this.frameListBox.FormattingEnabled = true;
			this.frameListBox.Name = "frameListBox";
			this.frameListBox.SelectedIndexChanged += new System.EventHandler(this.frameListBox_SelectedIndexChanged);
			// 
			// mainMenuStrip
			// 
			this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			resources.ApplyResources(this.mainMenuStrip, "mainMenuStrip");
			this.mainMenuStrip.Name = "mainMenuStrip";
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
			resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
			// 
			// openDTMMenuItem
			// 
			this.openDTMMenuItem.Name = "openDTMMenuItem";
			resources.ApplyResources(this.openDTMMenuItem, "openDTMMenuItem");
			this.openDTMMenuItem.Click += new System.EventHandler(this.openDTMMenuItem_Click);
			// 
			// saveMenuItem
			// 
			this.saveMenuItem.Name = "saveMenuItem";
			resources.ApplyResources(this.saveMenuItem, "saveMenuItem");
			this.saveMenuItem.Click += new System.EventHandler(this.saveMenuItem_Click);
			// 
			// saveAsMenuItem
			// 
			this.saveAsMenuItem.Name = "saveAsMenuItem";
			resources.ApplyResources(this.saveAsMenuItem, "saveAsMenuItem");
			this.saveAsMenuItem.Click += new System.EventHandler(this.saveAsMenuItem_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
			// 
			// exitMenuItem
			// 
			this.exitMenuItem.Name = "exitMenuItem";
			resources.ApplyResources(this.exitMenuItem, "exitMenuItem");
			this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
			// 
			// buttonGroupBox
			// 
			resources.ApplyResources(this.buttonGroupBox, "buttonGroupBox");
			this.buttonGroupBox.Controls.Add(this.buttonFlowLayout);
			this.buttonGroupBox.Name = "buttonGroupBox";
			this.buttonGroupBox.TabStop = false;
			// 
			// buttonFlowLayout
			// 
			this.buttonFlowLayout.Controls.Add(this.startButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.aButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.bButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.xButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.yButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.zButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.lButtonCheckBox);
			this.buttonFlowLayout.Controls.Add(this.rButtonCheckBox);
			resources.ApplyResources(this.buttonFlowLayout, "buttonFlowLayout");
			this.buttonFlowLayout.Name = "buttonFlowLayout";
			// 
			// startButtonCheckBox
			// 
			resources.ApplyResources(this.startButtonCheckBox, "startButtonCheckBox");
			this.startButtonCheckBox.Name = "startButtonCheckBox";
			this.startButtonCheckBox.UseVisualStyleBackColor = true;
			this.startButtonCheckBox.Click += new System.EventHandler(this.startCheckBox_Click);
			// 
			// aButtonCheckBox
			// 
			resources.ApplyResources(this.aButtonCheckBox, "aButtonCheckBox");
			this.aButtonCheckBox.Name = "aButtonCheckBox";
			this.aButtonCheckBox.UseVisualStyleBackColor = true;
			this.aButtonCheckBox.Click += new System.EventHandler(this.aButtonCheckBox_Click);
			// 
			// bButtonCheckBox
			// 
			resources.ApplyResources(this.bButtonCheckBox, "bButtonCheckBox");
			this.bButtonCheckBox.Name = "bButtonCheckBox";
			this.bButtonCheckBox.UseVisualStyleBackColor = true;
			this.bButtonCheckBox.Click += new System.EventHandler(this.bButtonCheckBox_Click);
			// 
			// xButtonCheckBox
			// 
			resources.ApplyResources(this.xButtonCheckBox, "xButtonCheckBox");
			this.xButtonCheckBox.Name = "xButtonCheckBox";
			this.xButtonCheckBox.UseVisualStyleBackColor = true;
			this.xButtonCheckBox.Click += new System.EventHandler(this.xButtonCheckBox_Click);
			// 
			// yButtonCheckBox
			// 
			resources.ApplyResources(this.yButtonCheckBox, "yButtonCheckBox");
			this.yButtonCheckBox.Name = "yButtonCheckBox";
			this.yButtonCheckBox.UseVisualStyleBackColor = true;
			this.yButtonCheckBox.Click += new System.EventHandler(this.yButtonCheckBox_Click);
			// 
			// zButtonCheckBox
			// 
			resources.ApplyResources(this.zButtonCheckBox, "zButtonCheckBox");
			this.zButtonCheckBox.Name = "zButtonCheckBox";
			this.zButtonCheckBox.UseVisualStyleBackColor = true;
			this.zButtonCheckBox.Click += new System.EventHandler(this.zButtonCheckBox_Click);
			// 
			// lButtonCheckBox
			// 
			resources.ApplyResources(this.lButtonCheckBox, "lButtonCheckBox");
			this.lButtonCheckBox.Name = "lButtonCheckBox";
			this.lButtonCheckBox.UseVisualStyleBackColor = true;
			this.lButtonCheckBox.Click += new System.EventHandler(this.lButtonCheckBox_Click);
			// 
			// rButtonCheckBox
			// 
			resources.ApplyResources(this.rButtonCheckBox, "rButtonCheckBox");
			this.rButtonCheckBox.Name = "rButtonCheckBox";
			this.rButtonCheckBox.UseVisualStyleBackColor = true;
			this.rButtonCheckBox.Click += new System.EventHandler(this.rButtonCheckBox_Click);
			// 
			// dpadGroupBox
			// 
			resources.ApplyResources(this.dpadGroupBox, "dpadGroupBox");
			this.dpadGroupBox.Controls.Add(this.dpadFlowLayout);
			this.dpadGroupBox.Name = "dpadGroupBox";
			this.dpadGroupBox.TabStop = false;
			// 
			// dpadFlowLayout
			// 
			this.dpadFlowLayout.Controls.Add(this.dpadUpCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadDownCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadLeftCheckBox);
			this.dpadFlowLayout.Controls.Add(this.dpadRightCheckBox);
			resources.ApplyResources(this.dpadFlowLayout, "dpadFlowLayout");
			this.dpadFlowLayout.Name = "dpadFlowLayout";
			// 
			// dpadUpCheckBox
			// 
			resources.ApplyResources(this.dpadUpCheckBox, "dpadUpCheckBox");
			this.dpadUpCheckBox.Name = "dpadUpCheckBox";
			this.dpadUpCheckBox.UseVisualStyleBackColor = true;
			this.dpadUpCheckBox.Click += new System.EventHandler(this.dpadUpCheckBox_Click);
			// 
			// dpadDownCheckBox
			// 
			resources.ApplyResources(this.dpadDownCheckBox, "dpadDownCheckBox");
			this.dpadDownCheckBox.Name = "dpadDownCheckBox";
			this.dpadDownCheckBox.UseVisualStyleBackColor = true;
			this.dpadDownCheckBox.Click += new System.EventHandler(this.dpadDownCheckBox_Click);
			// 
			// dpadLeftCheckBox
			// 
			resources.ApplyResources(this.dpadLeftCheckBox, "dpadLeftCheckBox");
			this.dpadLeftCheckBox.Name = "dpadLeftCheckBox";
			this.dpadLeftCheckBox.UseVisualStyleBackColor = true;
			this.dpadLeftCheckBox.Click += new System.EventHandler(this.dpadLeftCheckBox_Click);
			// 
			// dpadRightCheckBox
			// 
			resources.ApplyResources(this.dpadRightCheckBox, "dpadRightCheckBox");
			this.dpadRightCheckBox.Name = "dpadRightCheckBox";
			this.dpadRightCheckBox.UseVisualStyleBackColor = true;
			this.dpadRightCheckBox.Click += new System.EventHandler(this.dpadRightCheckBox_Click);
			// 
			// mainStickGroupBox
			// 
			this.mainStickGroupBox.Controls.Add(this.mainStickTableLayout);
			resources.ApplyResources(this.mainStickGroupBox, "mainStickGroupBox");
			this.mainStickGroupBox.Name = "mainStickGroupBox";
			this.mainStickGroupBox.TabStop = false;
			// 
			// mainStickTableLayout
			// 
			resources.ApplyResources(this.mainStickTableLayout, "mainStickTableLayout");
			this.mainStickTableLayout.Controls.Add(this.mainStickYAxisLabel, 0, 1);
			this.mainStickTableLayout.Controls.Add(this.mainStickXAxisUpDown, 1, 0);
			this.mainStickTableLayout.Controls.Add(this.mainStickYAxisUpDown, 1, 1);
			this.mainStickTableLayout.Controls.Add(this.mainStickXAxisLabel, 0, 0);
			this.mainStickTableLayout.Name = "mainStickTableLayout";
			// 
			// mainStickYAxisLabel
			// 
			resources.ApplyResources(this.mainStickYAxisLabel, "mainStickYAxisLabel");
			this.mainStickYAxisLabel.Name = "mainStickYAxisLabel";
			// 
			// mainStickXAxisUpDown
			// 
			resources.ApplyResources(this.mainStickXAxisUpDown, "mainStickXAxisUpDown");
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
			this.mainStickXAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.mainStickXAxisUpDown.ValueChanged += new System.EventHandler(this.mainStickXAxisUpDown_ValueChanged);
			// 
			// mainStickYAxisUpDown
			// 
			resources.ApplyResources(this.mainStickYAxisUpDown, "mainStickYAxisUpDown");
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
			this.mainStickYAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.mainStickYAxisUpDown.ValueChanged += new System.EventHandler(this.mainStickYAxisUpDown_ValueChanged);
			// 
			// mainStickXAxisLabel
			// 
			resources.ApplyResources(this.mainStickXAxisLabel, "mainStickXAxisLabel");
			this.mainStickXAxisLabel.Name = "mainStickXAxisLabel";
			// 
			// cstickGroupBox
			// 
			this.cstickGroupBox.Controls.Add(this.cstickTableLayout);
			resources.ApplyResources(this.cstickGroupBox, "cstickGroupBox");
			this.cstickGroupBox.Name = "cstickGroupBox";
			this.cstickGroupBox.TabStop = false;
			// 
			// cstickTableLayout
			// 
			resources.ApplyResources(this.cstickTableLayout, "cstickTableLayout");
			this.cstickTableLayout.Controls.Add(this.cstickYAxisUpDown, 1, 1);
			this.cstickTableLayout.Controls.Add(this.cstickYAxisLabel, 0, 1);
			this.cstickTableLayout.Controls.Add(this.cstickXAxisUpDown, 1, 0);
			this.cstickTableLayout.Controls.Add(this.cstickXAxisLabel, 0, 0);
			this.cstickTableLayout.Name = "cstickTableLayout";
			// 
			// cstickYAxisUpDown
			// 
			resources.ApplyResources(this.cstickYAxisUpDown, "cstickYAxisUpDown");
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
			this.cstickYAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.cstickYAxisUpDown.ValueChanged += new System.EventHandler(this.cstickYAxisUpDown_ValueChanged);
			// 
			// cstickYAxisLabel
			// 
			resources.ApplyResources(this.cstickYAxisLabel, "cstickYAxisLabel");
			this.cstickYAxisLabel.Name = "cstickYAxisLabel";
			// 
			// cstickXAxisUpDown
			// 
			resources.ApplyResources(this.cstickXAxisUpDown, "cstickXAxisUpDown");
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
			this.cstickXAxisUpDown.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
			this.cstickXAxisUpDown.ValueChanged += new System.EventHandler(this.cstickXAxisUpDown_ValueChanged);
			// 
			// cstickXAxisLabel
			// 
			resources.ApplyResources(this.cstickXAxisLabel, "cstickXAxisLabel");
			this.cstickXAxisLabel.Name = "cstickXAxisLabel";
			// 
			// triggerGroupBox
			// 
			this.triggerGroupBox.Controls.Add(this.triggerTableLayout);
			resources.ApplyResources(this.triggerGroupBox, "triggerGroupBox");
			this.triggerGroupBox.Name = "triggerGroupBox";
			this.triggerGroupBox.TabStop = false;
			// 
			// triggerTableLayout
			// 
			resources.ApplyResources(this.triggerTableLayout, "triggerTableLayout");
			this.triggerTableLayout.Controls.Add(this.leftTriggerUpDown, 1, 0);
			this.triggerTableLayout.Controls.Add(this.rightTriggerLabel, 0, 1);
			this.triggerTableLayout.Controls.Add(this.rightTriggerUpDown, 1, 1);
			this.triggerTableLayout.Controls.Add(this.leftTriggerLabel, 0, 0);
			this.triggerTableLayout.Name = "triggerTableLayout";
			// 
			// leftTriggerUpDown
			// 
			resources.ApplyResources(this.leftTriggerUpDown, "leftTriggerUpDown");
			this.leftTriggerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.leftTriggerUpDown.Name = "leftTriggerUpDown";
			this.leftTriggerUpDown.ValueChanged += new System.EventHandler(this.leftTriggerUpDown_ValueChanged);
			// 
			// rightTriggerLabel
			// 
			resources.ApplyResources(this.rightTriggerLabel, "rightTriggerLabel");
			this.rightTriggerLabel.Name = "rightTriggerLabel";
			// 
			// rightTriggerUpDown
			// 
			resources.ApplyResources(this.rightTriggerUpDown, "rightTriggerUpDown");
			this.rightTriggerUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
			this.rightTriggerUpDown.Name = "rightTriggerUpDown";
			this.rightTriggerUpDown.ValueChanged += new System.EventHandler(this.rightTriggerUpDown_ValueChanged);
			// 
			// leftTriggerLabel
			// 
			resources.ApplyResources(this.leftTriggerLabel, "leftTriggerLabel");
			this.leftTriggerLabel.Name = "leftTriggerLabel";
			// 
			// pairTableLayout
			// 
			resources.ApplyResources(this.pairTableLayout, "pairTableLayout");
			this.pairTableLayout.Controls.Add(this.mainStickGroupBox, 0, 0);
			this.pairTableLayout.Controls.Add(this.triggerGroupBox, 0, 1);
			this.pairTableLayout.Controls.Add(this.cstickGroupBox, 1, 0);
			this.pairTableLayout.Name = "pairTableLayout";
			// 
			// MainForm
			// 
			this.AllowDrop = true;
			resources.ApplyResources(this, "$this");
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.pairTableLayout);
			this.Controls.Add(this.dpadGroupBox);
			this.Controls.Add(this.buttonGroupBox);
			this.Controls.Add(this.frameListBox);
			this.Controls.Add(this.mainMenuStrip);
			this.MainMenuStrip = this.mainMenuStrip;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
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
		private System.Windows.Forms.CheckBox startButtonCheckBox;
		private System.Windows.Forms.CheckBox lButtonCheckBox;
		private System.Windows.Forms.CheckBox rButtonCheckBox;
	}
}

