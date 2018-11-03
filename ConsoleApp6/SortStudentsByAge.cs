using System.Collections.Generic;

namespace StudentsFromFile
{
  class SortStudentsByAge : IComparer<Student>
  {
    public int Compare(Student s1, Student s2)
    {
      return s1.Age.CompareTo(s2.Age);
    }
  }
}
