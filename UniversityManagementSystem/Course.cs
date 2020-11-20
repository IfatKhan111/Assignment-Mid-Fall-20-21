using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Course
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private int Id { get; set; }

        Section[] sectionlist = new Section[30];
        private int numOfSections = 0;

        public Course(string Name,int Id)
        {
            this.Name = Name;
            this.Id = Id;
        }

        public void AddSection(Section name)
        {
            this.sectionlist[numOfSections] = name;
            numOfSections++;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" Course Name  : " + this.Name);
            Console.WriteLine(" Course Id    : " + this.Id);
            Console.WriteLine(" Section list : ");
            for(int i = 0; i < numOfSections; i++)
            {
                Console.WriteLine(sectionlist[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
