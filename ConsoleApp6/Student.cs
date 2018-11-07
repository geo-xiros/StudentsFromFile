using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace StudentsFromFile
{
    public enum Conduct { Poor, Good, Excellent };

    public class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }
        public float Height { get; set; }
        public decimal Tuition { get; set; }
        public DateTime Date { get; set; }
        public String Phone { get; set; }
        public Conduct Conduct { get; set; }

        public override string ToString()
        {
            return $"{Name}, {Surname}, {Age}, {Height}, {Tuition}, {Date}, {Phone}, {Conduct}";
        }
    }
}
