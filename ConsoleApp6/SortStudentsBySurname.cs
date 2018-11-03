using System.Collections.Generic;

namespace StudentsFromFile
{
  class SortStudentsBySurname : IComparer<Student>
  {
    public int Compare(Student s1, Student s2)
    {
      return s1.Surname.CompareTo(s2.Surname);
    }
  }
}
