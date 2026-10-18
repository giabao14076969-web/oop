using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp16
{
    class program
    {

        static person inputPersonInfo(string name, string address, string sSalary)
        {
            if (string.IsNullOrWhiteSpace(sSalary))
            {
                throw new Exception("You must input salary");

            }
            double salary;
            if (!double.TryParse(sSalary, out salary))
            {
                throw new Exception("Salary must input digit");
            }
            if (salary <= 0)
            {
                throw new Exception("Salary is greater than 0");
            }

            return new person(name, address, salary);

        }
        static void displayPersonInfo(person person)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Address: " + person.Address);
            Console.WriteLine("Salary: " + person.Salary);
            Console.WriteLine(new string('-', 30));
        }
        static person[] sortBySalary(person[] person)
        {
            if (person == null)
            {
                throw new Exception("Person is null");

            }
            person[] result = (person[])person.Clone();
            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = i + 1; j < result.Length - 1 - i; j++)
                {
                    if (result[j].Salary > result[j + 1].Salary)
                    {
                        person temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }

            return result;

        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            person[] people = new person[3];
            Console.WriteLine("===== Management Person Program =====");
            for (int i = 0; i < people.Length; i++)
            {
                Console.WriteLine("Input information person!");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Address: ");
                string address = Console.ReadLine();
                while (true)
                {
                    Console.Write("Salary: ");
                    string sSalary = Console.ReadLine();
                    try
                    {
                        people[i] = inputPersonInfo(name, address, sSalary);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

            }
            Console.WriteLine("Information you have entered:");
            foreach (person p in people)
            {
                displayPersonInfo(p);
            }
            Console.WriteLine("Person list sorted by salary:");
            person[] sortedPeople = sortBySalary(people);
            foreach (person p in sortedPeople)
            {
                displayPersonInfo(p);
            }
        }
    }
}
