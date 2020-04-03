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

		public Form1()
		{
			InitializeComponent();
			pnlCheckbox.Visible = false;
			pnlRadiobutton.Visible = false;

			btnStart.Visible = true;
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
