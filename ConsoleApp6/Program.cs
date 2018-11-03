using System;
using System.IO;

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

            StudentsList students = StudentsList.CreateFromFile(new StreamReader(@"g:\test.txt"));

            PrintStudentsSortedBy(students, "Surname", (s1, s2) => s1.Surname.CompareTo(s2.Surname));

            PrintStudentsSortedBy(students, "Age", (s1, s2) => s1.Age.CompareTo(s2.Age));

            PrintStudentsSortedBy(students, "Phone",(s1, s2) => s1.Phone.CompareTo(s2.Phone));

            Console.ReadKey();
        }
        static void PrintStudentsSortedBy(StudentsList students, string compareField, Comparison<Student> comparable)
        {
            Console.WriteLine("Sort by " + compareField);

            students.Sort(comparable);

            foreach (Student student in students)
                Console.WriteLine(student);
        }
    }
}
