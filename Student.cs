using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Student
    {
        public string FullName { get; set; }    
        private int _no;
        public int No { get;  }
        public Student()
        {
            _no++;
        }
    }
}
