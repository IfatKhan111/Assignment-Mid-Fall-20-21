using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Department
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Id { get; set; }

        Course[] courseList = new Course[50];
        private int numOfCourses = 0;

        public Department(string name,int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public void AddCourse(Course cname)
        {
            this.courseList[numOfCourses] = cname;
            numOfCourses++;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Department Name : " + this.Name);
            Console.WriteLine(" Department Id   : " + this.Id);
            Console.WriteLine(" Course List : ");
            for(int i = 0; i < numOfCourses; i++)
            {
                Console.WriteLine(courseList[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
