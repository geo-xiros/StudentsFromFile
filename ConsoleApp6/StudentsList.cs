using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace StudentsFromFile
{

    public class StudentsList : List<Student>
    {
        static public StudentsList StudentsListFactory(StreamReader file)
        {
            string line;
            string[] headers = file.ReadLine().Split(',');
            string xmlStudents;


            // Read From File And Create Student Object Then Add The Object To List
            xmlStudents = "<StudentsList>";
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');
                xmlStudents += "<Student>";
                xmlStudents += $"<{headers[0]}>{fields[0].Trim()}</{headers[0]}>";
                xmlStudents += $"<{headers[1]}>{fields[1].Trim()}</{headers[1]}>";
                xmlStudents += $"<{headers[2]}>{byte.Parse(fields[2])}</{headers[2]}>";
                xmlStudents += $"<{headers[3]}>{float.Parse(fields[3])}</{headers[3]}>";
                xmlStudents += $"<{headers[4]}>{decimal.Parse(fields[4])}</{headers[4]}>";
                xmlStudents += $"<{headers[5]}>{DateTime.Parse(fields[5]).ToString("s")}</{headers[5]}>";
                xmlStudents += $"<{headers[6]}>{fields[6].Trim()}</{headers[6]}>";
                xmlStudents += "</Student>";
            }
            xmlStudents += "</StudentsList>";

            return StudentsListFactory(xmlStudents);
        }
        static public StudentsList StudentsListFactory(string xmlStudents)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(StudentsList), new XmlRootAttribute("StudentsList"));
            using (TextReader reader = new StringReader(xmlStudents))
            {
                StudentsList students = (StudentsList)serializer.Deserialize(reader);
                return students;
            }
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
