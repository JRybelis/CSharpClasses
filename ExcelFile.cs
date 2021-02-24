using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class ExcelFile : IFile
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        public DateTime CreatedOn{ get; set; }
        public void Compress() {
            Console.WriteLine("Compressing ExcelFile.");
            throw new NotImplementedException();
        }
        
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report.");
        }
    }
}
