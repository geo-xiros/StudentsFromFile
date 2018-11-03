using System;
using System.Collections.Generic;
using System.IO;

namespace StudentsFromFile
{
    class StudentsList : List<Student>
    {
        static public StudentsList CreateFromFile(StreamReader file)
        {
            StudentsList studentList = new StudentsList();

            string line;

            // Read From File And Create Student Object Then Add The Object To List
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                // TODO:
                // Trim fields from left right spaces

                studentList.Add(new Student()
                {
                    Name = fields[0],
                    Surname = fields[1],
                    Age = byte.Parse(fields[2]),
                    Height = float.Parse(fields[3]),
                    Tuition = decimal.Parse(fields[4]),
                    Date = DateTime.Parse(fields[5]),
                    Phone = fields[6]
                });
            }

            file.Close();

            return studentList;
        }

    }
}
