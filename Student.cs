using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace try2
{
    internal class Student
    {
        public string Name;
        public string LastName; 
        public string FatherName; 
        public string DateOfBirth;
        public string JoinDate;
        public string Nationality;

        public Student(string name,string lastname, string fathername, string date, string join, string nationality) 
        {
            Name = name;
            LastName = lastname;
            FatherName = fathername;
            DateOfBirth = date;
            JoinDate = join;
            Nationality = nationality;
        }

      
        
        
    }
}
