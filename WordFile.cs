using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class WordFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Printing WordFile.");
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine($"{FileName} printing.");
        }
    }
}
