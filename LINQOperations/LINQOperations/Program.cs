// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;
using System.Linq;

class LINQOperations
{
    static void Main(string[] args)
    {
        // Example 1: Working with an Array
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        // LINQ Query Syntax to filter even numbers and project their square values
        var evenSquares = from n in numbers
                          where n % 2 == 0
                          select n * n;

        Console.WriteLine("Even numbers squared:");
        foreach (var square in evenSquares)
        {
            Console.WriteLine(square);  // Output: 4, 16, 36, 64, 100
        }

        // Example 2: Working with a Collection of Objects (List of Students)
        var students = new List<Student>
        {
            new Student { Name = "Alice", Age = 20, Grade = 85 },
            new Student { Name = "Bob", Age = 22, Grade = 91 },
            new Student { Name = "Charlie", Age = 21, Grade = 70 },
            new Student { Name = "David", Age = 23, Grade = 60 },
            new Student { Name = "Eve", Age = 20, Grade = 95 }
        };

        // LINQ Query Syntax to filter students who have grade > 80 and order by age
        var topStudents = from student in students
                          where student.Grade > 80
                          orderby student.Age
                          select student;

        Console.WriteLine("\nTop students (Grade > 80), ordered by age:");
        foreach (var student in topStudents)
        {
            Console.WriteLine($"{student.Name}, Age: {student.Age}, Grade: {student.Grade}");
        }

        // Example 3: Grouping data (Group students by age)
        var groupedByAge = from student in students
                           group student by student.Age into studentGroup
                           select new
                           {
                               Age = studentGroup.Key,
                               Students = studentGroup
                           };

        Console.WriteLine("\nStudents grouped by age:");
        foreach (var group in groupedByAge)
        {
            Console.WriteLine($"Age: {group.Age}");
            foreach (var student in group.Students)
            {
                Console.WriteLine($"  {student.Name}, Grade: {student.Grade}");
            }
        }

        // Example 4: Advanced Collection Manipulation - Joining two collections
        var courses = new List<Course>
        {
            new Course { StudentName = "Alice", CourseName = "Math" },
            new Course { StudentName = "Bob", CourseName = "Science" },
            new Course { StudentName = "Charlie", CourseName = "Math" },
            new Course { StudentName = "David", CourseName = "English" }
        };

        // Joining students with their courses based on name
        var studentCourses = from student in students
                             join course in courses on student.Name equals course.StudentName
                             select new
                             {
                                 student.Name,
                                 student.Age,
                                 course.CourseName
                             };

        Console.WriteLine("\nStudent Course Enrollment:");
        foreach (var enrollment in studentCourses)
        {
            Console.WriteLine($"{enrollment.Name} (Age: {enrollment.Age}) is enrolled in {enrollment.CourseName}");
        }
    }

    // Student class
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Grade { get; set; }
    }

    // Course class
    class Course
    {
        public string StudentName { get; set; }
        public string CourseName { get; set; }
    }
}
