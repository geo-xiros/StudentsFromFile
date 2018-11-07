using System;
using System.Collections.Generic;
using System.IO;

namespace StudentsFromFile
{
    class StudentsList : List<Student>
    {
        static public StudentsList StudentsListFactory(StreamReader file)
        {
            StudentsList studentList = new StudentsList();

            string line;
            string headers = file.ReadLine();
           
            // Read From File And Create Student Object Then Add The Object To List
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');

                // TODO:
                // Error Handle in Field Parsing
                studentList.Add(new Student()
                {
                    Name = fields[0].Trim(),
                    Surname = fields[1].Trim(),
                    Age = byte.Parse(fields[2]),
                    Height = float.Parse(fields[3]),
                    Tuition = decimal.Parse(fields[4]),
                    Date = DateTime.Parse(fields[5]),
                    Phone = fields[6].Trim()
                });
            }

            file.Close();

            return studentList;
        }
        static public int ShortByName(Student s1, Student s2)
        {
            return s1.Name.CompareTo(s2.Name);
        }
        static public int ShortByAge(Student s1, Student s2)
        {
            return s1.Age.CompareTo(s2.Age);
        }
        static public int ShortByPhone(Student s1, Student s2)
        {
            return s1.Phone.CompareTo(s2.Phone);
        }

    }
}
