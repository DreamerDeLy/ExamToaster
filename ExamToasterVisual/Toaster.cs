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

        public Toaster()
        {
            //
        }

        public bool OpenFile(string path)
        {
            this.file_path = path;

            if (Directory.Exists(extract_path)) Directory.Delete(extract_path, true);

            ZipFile.ExtractToDirectory(file_path, extract_path);

            string jsonString = File.ReadAllText(extract_path + "test.json");

            test = JsonSerializer.Deserialize<Test>(jsonString);

            return true;
        }

        public void StartTest()
        {
            //
        }

        public void Question(int n)
        {
            //
        }
    }
}
