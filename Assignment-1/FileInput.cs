using System;
using System.IO;

namespace Assignment_1
{
    public class FileInput
    {
        private readonly string _fileName;

        public FileInput(string fileName)
        {
            _fileName = fileName;
        }

        public void ReadFile()
        {
            try
            {
                using (var reader = new StreamReader(_fileName))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e.Message}");
            }
        }

        public string? ReadLine()
        {
            try
            {
                using (var reader = new StreamReader(_fileName))
                {
                    return reader.ReadLine();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Read Error: {_fileName} {e.Message}");
                return null;
            }
        }
    }
}
