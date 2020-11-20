using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Student
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Id { get; set; }

        private double CGPA { get; set; }

        private Department department { get; set; }

        public Student(string name, int id, double cgpa, Department dept)
        {
            this.Name = name;
            this.Id = id;
            this.CGPA = cgpa;
            this.department = dept;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Student name       : " + this.Name);
            Console.WriteLine(" Student id         : " + this.Id);
            Console.WriteLine(" Student CGPA       : " + this.CGPA);
            Console.WriteLine(" Student Department : " + this.department.Name);
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
