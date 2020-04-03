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

			string file_path = @"D:\TOSTER_test.zip";
			Toaster toast = new Toaster(file_path);
			
			Console.WriteLine("\n OPEN \n===============================================================");
			toast.OpenFile();
			toast.Print();

			Console.WriteLine("\n TEST \n===============================================================");
			toast.StartTest();

			Console.ReadKey();
		}
	}
}
