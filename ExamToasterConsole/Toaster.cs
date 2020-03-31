using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.Json;
using System.IO.Compression;

namespace ExamToasterConsole
{
    class Toaster
	{
        public Test test;

        private string file_path = @"D:\TOSTER_test.zip";
        private string extract_path = @".\extract\";

        public Toaster(string path)
        {
            this.file_path = path;
        }

        public bool OpenFile()
        {
            if (Directory.Exists(extract_path)) Directory.Delete(extract_path, true);

            ZipFile.ExtractToDirectory(file_path, extract_path);

            string jsonString = File.ReadAllText(extract_path + "TOSTER_test.json");
            Console.WriteLine($"json string: \n{jsonString}");

            test = JsonSerializer.Deserialize<Test>(jsonString);

            return true;
        }

        public void Print()
        {
            Console.WriteLine($"Test title:\n {test.title} \nDescription:\n {test.description} \nAuthor:\n {test.author}\n");

            Console.WriteLine("Questions:");
            foreach (Question q in test.questions)
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
            foreach (Rating r in test.ratings)
            {
                Console.WriteLine($"t: {r.title}, r: {r.rating}");
            }
        }
    }
}
