using System;

namespace Lab_10
{
    internal class Student
    {
        // Properties of the Student class
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }

        // Constructor to initialize Student object
        public Student(int id, string name, int age, string grade)
        {
            Id = id;
            Name = name;
            Age = age;
            Grade = grade;
        }
    }
}
