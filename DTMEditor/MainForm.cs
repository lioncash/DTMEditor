using System;
using System.IO;
using System.Windows.Forms;
using DTMEditor.FileHandling;

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
		}

		private void frameListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string currentItem = frameListBox.SelectedItem.ToString();
			int index = frameListBox.FindString(currentItem);

			if (index == -1)
			{
				// TODO: Clear all controls.
				return;
			}

			DTMControllerDatum data = openedDtm.ControllerData[index];

			// Buttons
			aButtonCheckBox.Checked   = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.A);
			bButtonCheckBox.Checked   = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.B);
			xButtonCheckBox.Checked   = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.X);
			yButtonCheckBox.Checked   = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.Y);
			zButtonCheckBox.Checked   = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.Z);
			dpadUpCheckBox.Checked    = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.DPadUp);
			dpadDownCheckBox.Checked  = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.DPadDown);
			dpadLeftCheckBox.Checked  = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.DPadLeft);
			dpadRightCheckBox.Checked = data.IsButtonPressed(DTMControllerDatum.GameCubeButton.DPadRight);

			// Axes
			analoxXAxisUpDown.Value = data.GetAxisValue(DTMControllerDatum.GameCubeAxis.AnalogXAxis);
			analogYAxisUpDown.Value = data.GetAxisValue(DTMControllerDatum.GameCubeAxis.AnalogYAxis);
			cstickXAxisUpDown.Value = data.GetAxisValue(DTMControllerDatum.GameCubeAxis.CStickXAxis);
			cstickYAxisUpDown.Value = data.GetAxisValue(DTMControllerDatum.GameCubeAxis.CStickYAxis);

			// Triggers
			leftTriggerUpDown.Value  = data.GetTriggerValue(DTMControllerDatum.GameCubeTrigger.L);
			rightTriggerUpDown.Value = data.GetTriggerValue(DTMControllerDatum.GameCubeTrigger.R);
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
		}

		private void exitMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
	}
}
