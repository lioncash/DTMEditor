﻿using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DTMEditor.FileHandling;
using DTMEditor.FileHandling.ControllerData;

namespace DTMEditor
{
	public partial class MainForm : Form
	{
		private DTM openedDtm;

		public MainForm()
		{
			InitializeComponent();
		}

		private void openDTMMenuItem_Click(object sender, EventArgs e)
		{
			var ofd = new OpenFileDialog();
			ofd.Filter = "Dolphin Movie File (*.dtm)|*.dtm";

			if (ofd.ShowDialog() == DialogResult.OK)
			{
				// TODO: When C# 6 comes out, collapse these catch statements.
				//       (No, simply catching the base exception type is *not* a good alternative).
				try
				{
					openedDtm = new DTM(ofd.FileName);
					frameListBox.DataSource = Enumerable.Range(0, openedDtm.ControllerData.Count()).Select(x => string.Format("Frame {0}", x)).ToList();
				}
				catch (FileNotFoundException fnfe)
				{
					MessageBox.Show(fnfe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (InvalidDTMHeaderException idhe)
				{
					MessageBox.Show(idhe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				catch (IOException ioe)
				{
					// If we end up here, some other application is using the DTM file that is selected.
					MessageBox.Show(ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			ofd.Dispose();
		}

		private void frameListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			int index = frameListBox.SelectedIndex;

			// Invalid index
			if (index == -1)
			{
				aButtonCheckBox.Checked   = false;
				bButtonCheckBox.Checked   = false;
				xButtonCheckBox.Checked   = false;
				yButtonCheckBox.Checked   = false;
				zButtonCheckBox.Checked   = false;
				dpadUpCheckBox.Checked    = false;
				dpadDownCheckBox.Checked  = false;
				dpadLeftCheckBox.Checked  = false;
				dpadRightCheckBox.Checked = false;

				// Center the control sticks
				mainStickXAxisUpDown.Value = 128;
				mainStickYAxisUpDown.Value = 128;
				cstickXAxisUpDown.Value = 128;
				cstickYAxisUpDown.Value = 128;

				leftTriggerUpDown.Value  = leftTriggerUpDown.Minimum;
				rightTriggerUpDown.Value = rightTriggerUpDown.Minimum;
			}
			else
			{
				DTMControllerDatum data = openedDtm.ControllerData[index];

				// Buttons
				aButtonCheckBox.Checked   = data.IsButtonPressed(GameCubeButton.A);
				bButtonCheckBox.Checked   = data.IsButtonPressed(GameCubeButton.B);
				xButtonCheckBox.Checked   = data.IsButtonPressed(GameCubeButton.X);
				yButtonCheckBox.Checked   = data.IsButtonPressed(GameCubeButton.Y);
				zButtonCheckBox.Checked   = data.IsButtonPressed(GameCubeButton.Z);
				dpadUpCheckBox.Checked    = data.IsButtonPressed(GameCubeButton.DPadUp);
				dpadDownCheckBox.Checked  = data.IsButtonPressed(GameCubeButton.DPadDown);
				dpadLeftCheckBox.Checked  = data.IsButtonPressed(GameCubeButton.DPadLeft);
				dpadRightCheckBox.Checked = data.IsButtonPressed(GameCubeButton.DPadRight);

				// Axes
				mainStickXAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.AnalogXAxis);
				mainStickYAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.AnalogYAxis);
				cstickXAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.CStickXAxis);
				cstickYAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.CStickYAxis);

				// Triggers
				leftTriggerUpDown.Value  = data.GetTriggerValue(GameCubeTrigger.L);
				rightTriggerUpDown.Value = data.GetTriggerValue(GameCubeTrigger.R);
			}
		}

		private void saveMenuItem_Click(object sender, EventArgs e)
		{
			try
			{
				openedDtm.Save(openedDtm.FilePath);
			}
			catch (FileNotFoundException)
			{
				// If the original file cannot be found. Allow the user to save it manually.
				saveAsMenuItem_Click(sender, e);
			}
			catch (IOException ioe)
			{
				// Not much we can do in this case. Better than crashing and burning though.
				MessageBox.Show(ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void saveAsMenuItem_Click(object sender, EventArgs e)
		{
			var sfd = new SaveFileDialog();
			sfd.Filter = "Dolphin Movie File (*.dtm)|*.dtm";

			if (sfd.ShowDialog() == DialogResult.OK)
			{
				try
				{
					openedDtm.Save(sfd.FileName);
				}
				catch (IOException ioe)
				{
					// Not much else we can do in this case.
					MessageBox.Show(ioe.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}

			sfd.Dispose();
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		#region DTM Edition Functionality

		#region Button Handling

		private void startCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.Start, startButtonCheckBox);
		}

		private void aButtonCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.A, aButtonCheckBox);
		}

		private void bButtonCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.B, bButtonCheckBox);
		}

		private void xButtonCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.X, xButtonCheckBox);
		}

		private void yButtonCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.Y, yButtonCheckBox);
		}

		private void zButtonCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.Z, zButtonCheckBox);
		}

		private void dpadUpCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.DPadUp, dpadUpCheckBox);
		}

		private void dpadDownCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.DPadDown, dpadDownCheckBox);
		}

		private void dpadLeftCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.DPadLeft, dpadLeftCheckBox);
		}

		private void dpadRightCheckBox_Click(object sender, EventArgs e)
		{
			ValidateButton(GameCubeButton.DPadRight, dpadRightCheckBox);
		}

		#endregion

		#region Axis Handling

		private void mainStickXAxisUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateAxis(GameCubeAxis.AnalogXAxis, mainStickXAxisUpDown);
		}

		private void mainStickYAxisUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateAxis(GameCubeAxis.AnalogYAxis, mainStickYAxisUpDown);
		}

		private void cstickXAxisUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateAxis(GameCubeAxis.CStickXAxis, cstickXAxisUpDown);
		}

		private void cstickYAxisUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateAxis(GameCubeAxis.CStickYAxis, cstickYAxisUpDown);
		}

		#endregion

		#region Trigger Handling

		private void leftTriggerUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateTrigger(GameCubeTrigger.L, leftTriggerUpDown);
		}

		private void rightTriggerUpDown_ValueChanged(object sender, EventArgs e)
		{
			ValidateTrigger(GameCubeTrigger.R, rightTriggerUpDown);
		}

		#endregion

		#endregion

		#region Private Helpers

		private void ValidateButton(GameCubeButton button, CheckBox checkbox)
		{
			int index = frameListBox.SelectedIndex;

			if (index != -1)
				openedDtm.ControllerData[index].ModifyButton(button, checkbox.Checked);
		}

		private void ValidateAxis(GameCubeAxis axis, NumericUpDown axisUpDown)
		{
			int index = frameListBox.SelectedIndex;

			if (index != -1)
				openedDtm.ControllerData[index].ModifyAxis(axis, (int)axisUpDown.Value);
		}

		private void ValidateTrigger(GameCubeTrigger trigger, NumericUpDown axisUpDown)
		{
			int index = frameListBox.SelectedIndex;

			if (index != -1)
				openedDtm.ControllerData[index].ModifyTrigger(trigger, (int)axisUpDown.Value);
		}

		#endregion
	}
}
