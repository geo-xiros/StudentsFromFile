using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsFromFile
{
  class SortStudentsBySurname : IComparer<Student>
  {
    public int Compare(Student x, Student y)
    {
      return x.Surname.CompareTo(y.Surname);
    }
  }
}
