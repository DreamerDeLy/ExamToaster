using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamToasterVisual
{
	public partial class Form1 : Form
	{
		static Toaster toaster = new Toaster();

		List<RadioButton> rbs = new List<RadioButton> { };
		List<CheckBox> cbs = new List<CheckBox> { };

		public Form1()
		{
			InitializeComponent();
			pnlCheckbox.Visible = false;
			pnlRadiobutton.Visible = false;

			btnStart.Visible = true;

			btnNext.Visible = false;
			btnPrevious.Visible = false;

			lblCaption.Text = "ExamToaster by DeLy";

			rbs = new List<RadioButton>
			{
				rbVariant1,
				rbVariant2,
				rbVariant3,
				rbVariant4,
				rbVariant5,
				rbVariant6
			};

			cbs = new List<CheckBox> 
			{ 
				cbVariant1,
				cbVariant2,
				cbVariant3,
				cbVariant4,
				cbVariant5,
				cbVariant6
			};
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string path = openFileDialog.FileName;
				toaster.OpenFile(path);
			}
		}
	}
}
