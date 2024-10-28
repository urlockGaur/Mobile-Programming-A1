using System;
using System.IO;

namespace Assignment_1
{
    public class FileOutput
    {
        private readonly string _fileName;

        public FileOutput(string fileName)
        {
            _fileName = fileName;
        }

        public void WriteFile(string line)
        {
            try
            {
                using (var writer = new StreamWriter(_fileName, true))
                {
                    writer.WriteLine(line);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine($"File Write Error: {_fileName} {e.Message}");
            }
        }
    }
}