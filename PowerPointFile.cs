using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class PowerPointFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn { get; set; }
        public void Compress()
        {
            Console.WriteLine("Compressing PowerPointFile.");
            throw new NotImplementedException();
        }
        public void Present()
        {
            Console.WriteLine($"{FileName} presenting.");
        }
    }
}
