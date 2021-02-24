using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class File
    {
        public string FileName { get; set; }
        public int Size { get; set; }
        protected DateTime CreatedOn { get; set; }
    }
}
