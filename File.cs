using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    //abstract class File // <= example
    //{
      //  public string FileName { get; set; }
        //public int Size { get; set; }
        //protected DateTime CreatedOn { get; set; }

//        public abstract void Compress();
  //  }

    interface IFile
    {
        string FileName { get; set; }
        int Size { get; set; }
        DateTime CreatedOn { get; set; }
        void Compress();
    }

}

