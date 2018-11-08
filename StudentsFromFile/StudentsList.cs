using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace StudentsFromFile
{

    public class StudentsList : List<Student>
    {
        /// <summary>
        /// Creates a new list of students from text file
        /// </summary>
        /// <param name="file">Name and path of the file with students data</param>
        /// <returns>StudentsList</returns>
        static public StudentsList StudentsListFactory(StreamReader file)
        {
            string line;
            StudentsList studentsList = new StudentsList();
            line = file.ReadLine();

            if (!line.Contains("Name") || !line.Contains("Surname"))
            {
                throw new ArgumentOutOfRangeException("No Valid headers found in input file. Valid headers (\"Name,Surname,Age,Tuition,Height,Date,Phone\")");
            }

            string[] headers = line.Split(',');

            // Read From File And Create Student Object Then Add The Object To List
            while ((line = file.ReadLine()) != null)
            {
                string[] fields = line.Split(',');

                Student student = CreateStudent(headers, fields);

                studentsList.Add(student);

            }

            return studentsList;
        }
        static private Student CreateStudent(string[] headers, string[] fields)
        {
            Student student = new Student();

            for (int fieldIndex = 0; fieldIndex < headers.Length; fieldIndex++)
            {
                string field = fields[fieldIndex].Trim();

                switch (headers[fieldIndex])
                {
                    case "Name":
                        student.ParseName(field);
                        break;
                    case "Surname":
                        student.ParseSurname(field);
                        break;
                    case "Age":
                        student.ParseAge(field);
                        break;
                    case "Height":
                        student.ParseHeight(field);
                        break;
                    case "Tuition":
                        student.ParseTuition(field);
                        break;
                    case "Date":
                        student.ParseDate(field);
                        break;
                    case "Phone":
                        student.ParsePhone(field);
                        break;

                }
            }
            return student;
        }
        /// <summary>
        /// Creates a new list of students from xml string
        /// </summary>
        /// <param name="xmlStudents">xml with students data</param>
        /// <returns>StudentList</returns>
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
            if (s1 == null && s2 == null) return 0;
            if ((s1 == null) || (s1.Name == null)) return 1;
            if ((s2 == null) || (s2.Name == null)) return -1;

            return s1.Name.CompareTo(s2.Name);
        }
        static public int ShortByAge(Student s1, Student s2)
        {
            if (s1 == null && s2 == null) return 0;
            if ((s1 == null) || (s1.Age == 0)) return 1;
            if ((s2 == null) || (s2.Age == 0)) return -1;
            return s1.Age.CompareTo(s2.Age);
        }
        static public int ShortByPhone(Student s1, Student s2)
        {
            if (s1 == null && s2 == null) return 0;
            if ((s1 == null) || (s1.Phone == null)) return 1;
            if ((s2 == null) || (s2.Phone == null)) return -1;
            return s1.Phone.CompareTo(s2.Phone);
        }

    }
}
