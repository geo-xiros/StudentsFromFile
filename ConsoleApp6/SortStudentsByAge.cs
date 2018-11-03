using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsFromFile
{
  class SortStudentsByAge : IComparer<Student>
  {
    public int Compare(Student x, Student y)
    {
      return x.Age.CompareTo(y.Age);
    }
  }
}
