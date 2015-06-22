using System;
using System.IO;
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
					frameListBox.DataSource = openedDtm.ControllerData;
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
			string currentItem = frameListBox.SelectedItem.ToString();
			int index = frameListBox.FindString(currentItem);

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
				analogXAxisUpDown.Value = 128;
				analogYAxisUpDown.Value = 128;
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
				analogXAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.AnalogXAxis);
				analogYAxisUpDown.Value = data.GetAxisValue(GameCubeAxis.AnalogYAxis);
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
	}
}
