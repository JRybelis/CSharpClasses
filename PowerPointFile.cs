using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class PowerPointFile : File
    {
        public void Present()
        {
            DateTime dateMade = CreatedOn;
            Console.WriteLine($"{FileName} presenting.");
        }
    }
}
