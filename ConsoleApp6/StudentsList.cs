using System;
using System.Collections.Generic;
using System.IO;

namespace StudentsFromFile
{
  class StudentsList : List<Student>
  {
    static public StudentsList StudentsListFactory(StreamReader file)
    {
      StudentsList StudentList = new StudentsList();

      string Line;

      // Read From File And Create Student Object Then Add The Object To List
      while ((Line = file.ReadLine()) != null)
      {
        string[] Fields = Line.Split(',');

        // TODO:
        // Error Handle in Field Parsing
        StudentList.Add(new Student()
        {
          Name = Fields[0].Trim(),
          Surname = Fields[1].Trim(),
          Age = byte.Parse(Fields[2]),
          Height = float.Parse(Fields[3]),
          Tuition = decimal.Parse(Fields[4]),
          Date = DateTime.Parse(Fields[5]),
          Phone = Fields[6].Trim()
        });
      }

      file.Close();

      return StudentList;
    }

  }
}
