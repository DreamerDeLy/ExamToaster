using System;
using System.IO;
using System.Text.Json;
using System.IO.Compression;

namespace ExamToasterConsole
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("ExamToasterConsole");

			string file_path = "D:\\TOSTER_test.json";

			string jsonString = File.ReadAllText(file_path);
			Test restoredTest = JsonSerializer.Deserialize<Test>(jsonString);

			Console.WriteLine($"Test title:\n {restoredTest.title} \nDescription:\n {restoredTest.description} \nAuthor:\n {restoredTest.author}\n");

			Console.WriteLine("Questions:");
			foreach (Question q in restoredTest.questions)
			{
				Console.WriteLine(q.title);
				Console.WriteLine(q.text);
				Console.WriteLine(q.image);
				Console.WriteLine("Variants:");
				foreach (Variant v in q.variants)
				{
					Console.WriteLine($"v: {v.title}, r: {v.rating}");
				}
				Console.WriteLine();
			}

			Console.WriteLine("Ratings");
			foreach (Rating r in restoredTest.ratings)
			{
				Console.WriteLine($"t: {r.title}, r: {r.rating}");
			}

			Console.ReadKey();
		}
	}
}
