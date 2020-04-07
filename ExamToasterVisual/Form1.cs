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

				if (toaster.OpenFile(path))
				{
					toaster.StartTest();

					LoadQuestion(toaster.QuestionNext());

					btnNext.Visible = true;
					btnPrevious.Visible = true;

					if (toaster.test.allow_back) btnPrevious.Enabled = true;
				}
				else
				{
					MessageBox.Show("Error while opening file!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btnNext_Click(object sender, EventArgs e) 
		{
			ToasterAnswer answer = new ToasterAnswer();

			if (toaster.current_question.multiply)
			{
				for(int i = 0; i < cbs.Count; i++)
				{
					answer.a.Add(cbs[i].Checked);
				}
			}
			else
			{
				for (int i = 0; i < rbs.Count; i++)
				{
					answer.a.Add(rbs[i].Checked);
				}
			}

			toaster.ReadAnswer(toaster.current_question, answer);

			// MessageBox.Show($"rating:{toaster.rating}");

			if (toaster.question < toaster.question_count-1)
			{
				LoadQuestion(toaster.QuestionNext());
			}
			else 
			{
				LoadResult();
			}
		}
		private void btnPrevious_Click(object sender, EventArgs e) 
		{
			LoadQuestion(toaster.QuestionPrevious());
		}

		private void LoadQuestion(Question q)
		{
			string title = q.title;
			string text = q.text;

			string image = toaster.extract_path + q.image;

			lblCaption.Text = title;
			rtbDescription.Text = text;
			pbImage.Image = Image.FromFile(image);

			btnStart.Visible = false;

			foreach (RadioButton r in rbs)
			{
				r.Visible = false;
			}

			foreach (CheckBox c in cbs)
			{
				c.Visible = false;
			}

			if (q.multiply)
			{
				pnlCheckbox.Visible = true;
				pnlRadiobutton.Visible = false;

				int c = q.variants.Count;

				for (int i = 0; i < c; i++)
				{
					cbs[i].Visible = true;
					cbs[i].Text = q.variants[i].title;
				}
			}
			else
			{
				pnlCheckbox.Visible = false;
				pnlRadiobutton.Visible = true;

				int c = q.variants.Count;

				for (int i = 0; i < c; i++)
				{
					rbs[i].Visible = true;
					rbs[i].Text = q.variants[i].title;
				}
			}
		}

		private void LoadResult()
		{
			pnlCheckbox.Visible = false;
			pnlRadiobutton.Visible = false;

			Rating rt = new Rating();

			for (int i = 0; i < toaster.test.ratings.Count; i++)
			{
				Rating r = toaster.test.ratings[i];

				if (toaster.rating > r.rating && i < toaster.test.ratings.Count-1)
				{
					continue;
				}
				else
				{
					rt = r;
					break;
				}
			}

			// MessageBox.Show($"rating:{rt.rating}, title:{rt.title}");

			string title = "Your result is \"" + rt.title + "\"";
			string text = rt.description;

			string image = toaster.extract_path +rt.image;

			lblCaption.Text = title;
			rtbDescription.Text = text;
			pbImage.Image = Image.FromFile(image);
		}
	}
}
