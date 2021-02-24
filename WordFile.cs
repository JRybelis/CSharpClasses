using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class WordFile : File
    {
        
        public void Print()
        {
            Console.WriteLine($"{FileName} printing.");
            DateTime dateMade = CreatedOn;
        }
    }
}
