using OOP_Task_1;
using OOP_Task_1.Company;
using System;
using System.Globalization;

namespace Assignment01_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Question 1:
            Console.WriteLine("Question 1:Create an enum called \"WeekDays\" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.\r\n");
            foreach (var day in Enum.GetNames(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region Question 2:
            Console.WriteLine("Question 2: Define a struct \"Person\" with properties \"Name\" and \"Age\". Create an array of three \"Person\" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.");
            Person[] people = new Person[3]
            {
                new Person("Ali", 22),
                new Person("Sara", 25),
                new Person("Mohamed", 20)
            };
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine("----------------------------------");
            #endregion

            #region Question 3:
            Console.WriteLine("Question 3: Create an enum called \"Season\" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)\r\n");
            Season season;
            bool validSeason;
            do
            {
                Console.Write("Enter a season (Spring, Summer, Autumn, Winter): ");
                string inputSeason = Console.ReadLine();
                validSeason = Enum.TryParse(inputSeason, true, out season);
                if (!validSeason)
                    Console.WriteLine("Invalid input. Please try again.");
            } while (!validSeason);
            Console.WriteLine(SeasonHandler.GetSeasonRange(season));
            Console.WriteLine("----------------------------------");
            #endregion


            #region Question 4:
            Console.WriteLine("Question 4: Permissions manipulation");
            Permissions perms = Permissions.Read | Permissions.Write;
            Console.WriteLine($"Initial: {perms}");
            perms |= Permissions.Execute;
            Console.WriteLine($"After adding Execute: {perms}");
            perms &= ~Permissions.Write;
            Console.WriteLine($"After removing Write: {perms}");
            Console.WriteLine($"Has Delete? {(perms.HasFlag(Permissions.Delete) ? "Yes" : "No")}");
            Console.WriteLine("----------------------------------");
            #endregion

            #region Question 5:
            Console.WriteLine("Question 5: Create an enum called \"Colors\" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.\r\n");
            Console.Write("Enter a color: ");
            string inputColor = Console.ReadLine();
            Console.WriteLine(ColorChecker.IsPrimary(inputColor));

            Console.WriteLine("Point distance");
            Point p1 = new Point(0, 0);
            Point p2 = new Point(3, 4);
            Console.WriteLine($"Distance: {p1.DistanceTo(p2)}");
            Console.WriteLine("----------------------------------");
            #endregion

            #region Question 6:
            Console.WriteLine("Question 6:Create a struct called \"Point\" to represent a 2D point with properties \"X\" and \"Y\". Write a C# program that takes two points as input from the user and calculates the distance between them.\r\n");
            Person[] persons = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter name of person {i + 1}: ");
                string name;
                int age;
                bool validAge;
                do
                {
                    Console.Write($"Enter name of person {i + 1}: ");
                    name = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(name) || !name.All(char.IsLetter))
                    {
                        Console.WriteLine("Invalid name. Please enter a valid name (letters only).");
                        name = null;
                    }
                } while (string.IsNullOrWhiteSpace(name));
                do
                {
                    Console.Write($"Enter age of person {i + 1}: ");
                    validAge = int.TryParse(Console.ReadLine(), out age);
                    if (!validAge || age < 0)
                        Console.WriteLine("Invalid age. Please enter a valid positive number.");
                } while (!validAge || age < 0);
                persons[i] = new Person(name, age);
            }
            Person oldest = persons[0];
            foreach (var p in persons)
                if (p.Age > oldest.Age) oldest = p;
            Console.WriteLine($"Oldest: {oldest.Name}, Age: {oldest.Age}");
            Console.WriteLine("----------------------------------");
            #endregion

            #region Question 7:
            Console.WriteLine("Question 7: Create a struct called \"Person\" with properties \"Name\" and \"Age\". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.\r\n\r\n");
            Employee[] employees = new Employee[3]
            {
                new Employee(1, "Abdo", SecurityLevel.DBA, 15000, new HireDate(1,1,2002), Gender.M),
                new Employee(2, "Mohamed", SecurityLevel.Guest, 6000, new HireDate(2,2,2001), Gender.M),
                new Employee(3, "Nada", SecurityLevel.SecurityOfficer, 20000, new HireDate(3,3,1995), Gender.F)
            };
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("----------------------------------");
            #endregion
        }
    }

    enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
    enum Season { Spring, Summer, Autumn, Winter }
    enum Permissions { None = 0, Read = 1, Write = 2, Delete = 4, Execute = 8 }
    enum Colors { Red, Green, Blue }
    enum Gender { M, F }
    enum SecurityLevel { Guest, Developer, Secretary, DBA, SecurityOfficer }

}
