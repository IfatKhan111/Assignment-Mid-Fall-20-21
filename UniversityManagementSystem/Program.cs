using System;

namespace UniversityManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Department cse = new Department("Computer Science and Engineering", 101);
            Department bba = new Department("Bachelor of Business Administration", 102);
            Department law = new Department("Department of LAW", 103);

            Course oop2 = new Course("Object Oriented Programming 2", 232);
            Course ai = new Course("Atrificial intelligence", 202);
            Course ds = new Course("Data Structure", 117);

            Course bls = new Course("Basic Law Studies", 305);

            Course ba1 = new Course("Business Administration 1", 513);

            cse.AddCourse(oop2);
            cse.AddCourse(ai);
            cse.AddCourse(ds);

            bba.AddCourse(ba1);

            law.AddCourse(bls);

            Section a = new Section("A");
            Section k = new Section("K");
            Section m = new Section("M");

            ai.AddSection(a);
            bls.AddSection(k);
            ba1.AddSection(m);

            Faculty TanvirAhmed = new Faculty("Tanvir Ahmed", 19879, 0, cse);

            Section l = new Section("L", TanvirAhmed);

            oop2.AddSection(l);

            Student std1 = new Student("Ifat Khan", 19412012, 3.52, cse);
            Student std2 = new Student("Shovon Ali", 14542012, 4.00, bba);
            Student std3 = new Student("John Kabir", 18522012, 2.40, law);

            l.addStudents(std1);
            m.addStudents(std2);
            k.addStudents(std3);

            cse.ShowInfo();
            oop2.ShowInfo();
            l.ShowInfo();
            std1.ShowInfo();

        }
    }
}
