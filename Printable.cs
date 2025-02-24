using System;
using System.IO;

namespace Printable
{
    public interface IPrintable
    {
        void Print();
    }

    public interface ISerializable
    {
        void SaveToFile(string filePath);
    }

    public class Report : IPrintable, ISerializable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public void Print()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Content: {Content}");
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine($"Title: {Title}");
                writer.WriteLine($"Content: {Content}");
            }
        }
    }
}
