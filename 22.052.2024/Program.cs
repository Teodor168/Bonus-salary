using System;

namespace _22._052._2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employers> people = new List<Employers>();
            Console.WriteLine("Kolko pari: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Employers person = new Employers();

                Console.Write($"ime {i + 1}: ");
                person.Name = Console.ReadLine();

                Console.Write($"salary {i + 1}: ");
                person.Salary = double.Parse(Console.ReadLine());

                Console.Write($"occupation {i + 1}: ");
                person.Occupation = Console.ReadLine();

                Console.Write($"department {i + 1}: ");
                person.Department = Console.ReadLine();

                people.Add(person);
            }
            Console.WriteLine();
            Console.Write("Kolko pari dobavqme: ");
            double bonus = double.Parse(Console.ReadLine());
            Employers.BonusSalary(people, bonus);
            for (int i = 0; i < n; i++)
            {
                people[i].Print();
            }
        }
    }
}
