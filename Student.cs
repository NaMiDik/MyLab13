using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLab12
{
    public abstract class StudentBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual double GeneralScholarship()
        {
            return 0;
        }
    }
    public class Student : StudentBase
    {
        public string University { get; set; }
        public int Age { get; set; }
        public double Semester { get; set; }
        public double Scholarship { get; set; }
        public bool HasHostel { get; set; }
        public bool HasScholarship { get; set; }
        public override double GeneralScholarship()
        {
            return Scholarship * Semester * 6;
        }
        public double GS
        { get
            {
                return GeneralScholarship();
            }
        }
        public Student()
        {
        }
        public Student(string name, string surname, string university, int age, double semester, double scholarship, bool hasHostel, bool hasScholarship)
        {
            Name = name;
            Surname = surname;
            University = university;
            Age = age;
            Semester = semester;
            Scholarship = scholarship;
            HasHostel = hasHostel;
            HasScholarship = hasScholarship;
        }
    }
}
