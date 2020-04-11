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

					if (toaster.test.randomize > 0)
					{
						MyExtentions.Shuffle(rbs);
						MyExtentions.Shuffle(cbs);
					}

					LoadQuestion(toaster.QuestionNext());

					btnNext.Visible = true;
					btnPrevious.Visible = true;

					btnPrevious.Enabled = false;
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
					answer.a[i] = cbs[i].Checked;
				}
			}
			else
			{
				for (int i = 0; i < rbs.Count; i++)
				{
					answer.a[i] = rbs[i].Checked;
				}
			}

			toaster.AddAnswer(toaster.current_question, answer);

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

			int n = toaster.GetQuestionIndex(q);

			btnPrevious.Enabled = false;
			if (n > 0 && toaster.test.allow_back) btnPrevious.Enabled = true;

			// MessageBox.Show($" n:{n}, 0 - {toaster.answers[n].a[0]}, 1 - {toaster.answers[n].a[1]}");

			lblCaption.Text = title;
			rtbDescription.Text = text;
			pbImage.Image = Image.FromFile(image);

			btnStart.Visible = false;

			foreach (RadioButton r in rbs)
			{
				r.Visible = false;
				r.Checked = false;
			}

			foreach (CheckBox c in cbs)
			{
				c.Visible = false;
				c.Checked = false;
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
					cbs[i].Checked = toaster.answers[n].a[i];
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
					rbs[i].Checked = toaster.answers[n].a[i];
				}
			}
		}

		private void LoadResult()
		{
			pnlCheckbox.Visible = false;
			pnlRadiobutton.Visible = false;

			toaster.CalculateAnswers();

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

	public static class MyExtentions
	{
		private static Random rng = new Random();

		public static void Shuffle<T>(this IList<T> list)
		{
			int n = list.Count;
			while (n > 1)
			{
				n--;
				int k = rng.Next(n + 1);
				T value = list[k];
				list[k] = list[n];
				list[n] = value;
			}
		}
	}
}
