using System;
using System.IO;

namespace ICT3101_Calculator
{
    public class FileReader : IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}