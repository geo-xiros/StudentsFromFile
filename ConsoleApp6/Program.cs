using System;
using System.IO;
using System.Collections.Generic;

/*
Create a simple program that reads students from the file Lab3.txt file and stores them in a list.
Students will have a name, surname, age, height, tuition, date that started the school and phone.
Every student will also have a conduct (Poor, Good, Excellent).
Then create a method that sorts the list by the student surname or student age or student phone.
The first line of the file has headers. 
The actual data start from the second line, 

e.g.First Name, Last Name, Age, Height, Tuition, Date, PhoneLuana, Rayos,22,1.61,2500,01/01/2018,1234567
*/

namespace StudentsFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StudentsList students = StudentsList.StudentsListFactory(new StreamReader(@"C:\Users\George\Documents\cs-projects\StudentsFromFile\test.txt"));

                PrintStudentsSortedBy(students, "Surname", StudentsList.ShortByName);
                PrintStudentsSortedBy(students, "Age", StudentsList.ShortByAge);
                PrintStudentsSortedBy(students, "Phone", StudentsList.ShortByPhone);

            }
            catch (DirectoryNotFoundException e) { Console.WriteLine(e.Message); }
            catch (FileNotFoundException e) { Console.WriteLine(e.Message); }
            catch (FieldAccessException e) { Console.WriteLine(e.Message); }
            catch (Exception e) { Console.WriteLine(e.Message); }

            Console.ReadKey();
        }

        static void PrintStudentsSortedBy(StudentsList students, string compareField, Comparison<Student> comparison)
        {
            students.Sort(comparison); PrintStudents(students, compareField);
        }

        static void PrintStudents(StudentsList students, string compareField)
        {
            Console.WriteLine("Sort by " + compareField);
            foreach (Student student in students)
                Console.WriteLine(student);
        }
    }
}
