using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.IO.Compression;

namespace ExamToasterVisual
{
	class ToasterAnswer
	{
		public List<bool> answers = new List<bool> { };
	}

	class Toaster
	{
		public Test test;

		public string file_path = @"D:\TOSTER_test.tst";
		public string extract_path = @".\extract\";

		public double rating = 0;
		public int question = 0;
		public int question_count = 0;

		public bool started = false; 

		public Question current_question;

		public Toaster()
		{
			//
		}

		public bool OpenFile(string path)
		{
			this.file_path = path;

			try
			{
				if (Directory.Exists(extract_path)) Directory.Delete(extract_path, true);

				ZipFile.ExtractToDirectory(file_path, extract_path);

				string jsonString = File.ReadAllText(extract_path + "test.json");

				var options = new JsonSerializerOptions
				{
					ReadCommentHandling = JsonCommentHandling.Skip,
					AllowTrailingCommas = true,
				};

				test = JsonSerializer.Deserialize<Test>(jsonString, options);

				return true;
			}
			catch
			{
				return false;
			}
		}

		public void StartTest()
		{
			started = true;
			question = 0;
			question_count = test.questions.Count;
		}

		public Question QuestionNext()
		{
			if (question < test.questions.Count)
			{
				return Question(question++);
			}
			else
			{
				return Question(question);
			}
		}

		public Question QuestionPrevious()
		{
			question--;

			if (question >= 0)
			{
				return Question(question);
			}
			else
			{
				return Question(question+1);
			}
		}

		private Question Question(int n = -1)
		{
			if (n < 0) n = question;

			Question q = test.questions[n];
			q.image = q.image;

			current_question = q;

			return q;
		}

		public void ReadAnswer(Question q, ToasterAnswer answer)
		{
			double rating_plus = 0;

			int c = q.variants.Count;

			for (int i = 0; i < c; i++)
			{
				if (answer.answers[i]) rating_plus += q.variants[i].rating;
			}

			rating += rating_plus;

		}
	}
}
