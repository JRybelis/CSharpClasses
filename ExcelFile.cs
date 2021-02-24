using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class ExcelFile : File
    {
        
        public void GenerateReport()
        {
            Console.WriteLine($"{FileName} report.");
            DateTime dateMade = CreatedOn;
        }
    }
}
