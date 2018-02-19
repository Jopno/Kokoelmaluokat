using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniAsioApplication
{
    class Program
    {
        static void ShowMenu(Dictionary<string, Student> students)
        {
            int number;

            do
            {
                Console.WriteLine("Add a student 0");
                Console.WriteLine("Remove a student 1");
                Console.WriteLine("Search for a student 2");
                Console.WriteLine("Quit 3");
                bool result = int.TryParse(Console.ReadLine(), out number);
                if (result)
                {
                    switch (number)
                    {
                        case 0:
                            {
                                AddStudent(students);
                                break;
                            }

                        case 1:
                            {
                                RemoveStudent(students);
                                break;
                            }

                        case 2:
                            {
                                SearchStudent(students);
                                break;
                            }
                    }
                }
            } while (number != 3);
        }

        static void AddStudent(Dictionary<string, Student> students)
        {
            string firstName, lastName, asioid, group;
            Console.WriteLine("Student first name: ");
            firstName = Console.ReadLine();
            Console.WriteLine("Student last name: ");
            lastName = Console.ReadLine();
            Console.WriteLine("Student Asio ID: ");
            asioid = Console.ReadLine();
            Console.WriteLine("Student group: ");
            group = Console.ReadLine();

            students.Add(asioid, new Student { FirstName = firstName, LastName = lastName, AsioID = asioid, Group = group });
        }

        static void RemoveStudent(Dictionary<string, Student> students)
        {
            string asioid;
            Console.WriteLine("Write the AsioId of a student you want to remove: ");
            asioid = Console.ReadLine();

            if (students.ContainsKey(asioid))
            {
                students.Remove(asioid);
                Console.WriteLine("Student with ID {0} removed", asioid);
            }
        }

        static void SearchStudent(Dictionary<string, Student> students)
        {
            string asioid;
            Student found;
            Console.WriteLine("Write the AsioId of a student you want to search: ");
            asioid = Console.ReadLine();

            if (students.TryGetValue(asioid, out found))
            {
                Console.WriteLine("Student name: {0} {1}, AsioID: {2}, Group: {3}", found.FirstName, found.LastName, asioid, found.Group);
            }

            else
            {
                Console.WriteLine("No student with such ID");
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();

            try
            {
                ShowMenu(students);
            }

            catch (ArgumentException)
            {
                Console.WriteLine("Student with the same ID already exists");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
