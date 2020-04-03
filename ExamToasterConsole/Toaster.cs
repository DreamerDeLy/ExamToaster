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

        private string file_path = @"D:\TOSTER_test.tst";
        private string extract_path = @".\extract\";

        double rating = 0;
        int n_question = 0;

        public Toaster(string path)
        {
            this.file_path = path;
        }

        public bool OpenFile()
        {
            if (Directory.Exists(extract_path)) Directory.Delete(extract_path, true);

            ZipFile.ExtractToDirectory(file_path, extract_path);

            string jsonString = File.ReadAllText(extract_path + "test.json");
            Console.WriteLine($"json string: \n{jsonString}");

            test = JsonSerializer.Deserialize<Test>(jsonString);

            return true;
        }

        public void StartTest()
        {
            Console.WriteLine($"Test title:\n {test.title} \nDescription:\n {test.description} \nAuthor:\n {test.author}\n");
            rating = 0;
            n_question = 0;

            for (int n = 0; n < test.questions.Count; n++)
            {
                Question(n);
            }

            Console.Write($"Your rating {rating} is ");

            int r_n = 0;
            for (int i = -1; i < test.ratings.Count-1; i++)
            {
                if (test.ratings[i + 1].rating >= rating)
                {
                    r_n = i + 1;
                    break;
                }
            }

            Console.WriteLine(test.ratings[r_n].title);
        }

        public void Question(int n)
        {
            Question q = test.questions[n];
            Console.WriteLine($"Title:\n {q.title}");
            Console.WriteLine($"Text:\n {q.text}");

            Console.WriteLine("Choose answer:");
            int count = 1;
            foreach (Variant v in q.variants)
            {
                Console.WriteLine($" {count}\t{v.title}");
                count++;
            }

            int answer = Int32.Parse(Console.ReadLine())-1;
            rating += q.variants[answer].rating;
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
