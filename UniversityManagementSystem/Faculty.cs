using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityManagementSystem
{
    class Faculty
    {
        private string Name { get; set; }

        private int Id { get; set; }

        private double WorkingHour { get; set; }

        Department Dept;

        Section[] sectionlist = new Section[7];
        private int numOfSections = 0;



        public Faculty(string name , int id , double wh, Department dept )
        {
            this.Name = name;
            this.Id = id;
            this.WorkingHour = wh;
            this.Dept = dept;
        }

        public void AddToSection(Section sec)
        {
            if (WorkingHour < 21)
            {
                this.sectionlist[numOfSections] = sec;
                numOfSections++;
                WorkingHour += 3;
            }
            else
            {
                Console.WriteLine(" Faculty has already 21 hours of Worling time");
                Console.WriteLine(" Can't be added to a new section!");
            }
        }
        
        public void ShowInfo()
        {
            Console.WriteLine(" Faculty Name         : " + this.Name); ;
            Console.WriteLine(" Faculty ID           : " + this.Id);
            Console.WriteLine(" Faculty Department   : " + this.Dept);
            Console.WriteLine(" Faculty Working Hour : " + this.WorkingHour);
            Console.WriteLine(" Section List (" + this.numOfSections + ") : ");
            for(int i = 0; i < numOfSections; i++)
            {
                Console.WriteLine(sectionlist[i].Name);
            }
            Console.WriteLine();
            Console.WriteLine();
        }

    }
}
