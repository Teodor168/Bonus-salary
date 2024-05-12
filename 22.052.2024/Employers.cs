using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._052._2024
{
    public class Employers
    {
        public Employers()
        {
            
        }

        private string name;
        private double salary;
        private string ocupation;
        private string department;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Occupation
        {
            get { return ocupation; }
            set { ocupation = value; }
        }
        public string Department
        {
            get { return department; }
            set { department = value; }
        }

        public void Print()
        {
            Console.WriteLine($"Name: {this.Name}; Salary: {Math.Round(this.Salary, 2)}; Occupation: {this.Occupation}; Department: {this.Department}");
        }
        public static void BonusSalary(List<Employers> people, double bonus)
        {
            for (int i = 0; i < people.Count; i++)
            {
                double bonusReal = (bonus / 100) * people[i].Salary;
                people[i].Salary += bonusReal;
            }
        }
    }
}
