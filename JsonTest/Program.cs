using System;
using System.IO;
using System.Text.Json;

namespace JsonTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("JSON TEST");

			string jsonString = File.ReadAllText("D:\\TOSTER_test.json");

			Console.WriteLine($"String: {jsonString}");

			Test restoredTest = JsonSerializer.Deserialize<Test>(jsonString);
			Console.WriteLine($"Test title: {restoredTest.title}, Description: {restoredTest.description}");

			foreach (Question q in restoredTest.questions)
			{
				Console.WriteLine(q.title);
				Console.WriteLine(q.text);
				foreach (Variant v in q.variants)
				{
					Console.WriteLine($"variant:{v.title}, rating:{v.rating}");
				}
			}

			Console.ReadKey();
		}
	}
}
