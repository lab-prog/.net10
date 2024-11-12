using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic.Core;

namespace Lab_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sample data using constructor
            List<Student> students = new List<Student>
            {
                new Student(1, "Alice", 20, "A"),
                new Student(2, "Bob", 22, "B"),
                new Student(3, "Charlie", 21, "A"),
                new Student(4, "David", 23, "C")
            };

            Console.WriteLine("Enter a condition to filter students (e.g., Age > 20 or Grade == 'A'):");
            string condition = Console.ReadLine();

            // Dynamic LINQ query
            var filteredStudents = students.AsQueryable().Where(condition).ToList();

            // Display results
            Console.WriteLine("Filtered Students:");
            foreach (var student in filteredStudents)
            {
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}, Grade: {student.Grade}");
            }
            

        }
    }
}
