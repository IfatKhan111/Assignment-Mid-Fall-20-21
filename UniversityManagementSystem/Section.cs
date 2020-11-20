using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Section
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        Faculty tec;

        public Section(string name)
        {
            this.Name = name;
        }
        public Section(string name , Faculty tcr)
        {
            this.Name = name;
            this.tec = tcr;
        }

        Student[] studentlist = new Student[40];
        private int numOfStudents = 0;

        public void addStudents(Student std)
        {
            if(numOfStudents <= 40)
            {
                studentlist[numOfStudents] = std;
                numOfStudents++;
            }
            else
            {
                Console.WriteLine(" The section has crossed the limit of students");
                Console.WriteLine(" No students can be added!!");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Section name      : " + this.Name);
            Console.WriteLine(" Section Teacher   : " + this.tec);
            Console.WriteLine(" Show Student list : ");
            for(int i = 0; i < numOfStudents; i++)
            {
                Console.WriteLine(studentlist[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine();
        }


    }
}
