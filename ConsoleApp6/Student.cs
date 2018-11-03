using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsFromFile
{
    enum Conduct { Poor, Good, Excellent };
    class Student:IComparable<Student>, IComparer<Student>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public float Height { get; set; }
        public decimal Tuition { get; set; }
        public DateTime Date { get; set; }
        public String Phone { get; set; }
        public Conduct Conduct { get; set; }

    public int Compare(Student x, Student y)
    {
      return x.CompareTo(y);
    }

    public int CompareTo(Student student)
        {
            // A null value means that this object is greater.
            if (student == null)
                return 1;

            else
                return this.Age.CompareTo(student.Age);
        }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Age}, {Height}, {Tuition}, {Date}, {Phone}, {Conduct}";
        }
    }
}
