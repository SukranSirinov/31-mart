using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    internal class Group
    {
        private string _no ;
        private int _noNum = 100;
        public string No { get; }
        public Group(Type type)
        {
            Type = type;
            
            _noNum++;

            No = _no + _noNum;

        }
        Student[] students=new Student[5];
        public Type Type { get; set; }
        public Student FindStudentByNo (int no)
        {
            foreach (Student student in students)
            {
                if(student.No == no)
                {
                    return student;
                }    

            }
            return null;    
        }
    }
}
