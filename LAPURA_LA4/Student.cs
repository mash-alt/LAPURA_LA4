using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAPURA_LA4
{
    internal class Student : Person
    {
        public string StudentID { get; set; }

        public Student(string name, int age, string address, string studentID)
            : base(name, age, address)
        {
            StudentID = studentID;
        }

        public string GetStudentDetails()
        {
            return $"{GetDetails()}, Student ID: {StudentID}";
        }
    }
}