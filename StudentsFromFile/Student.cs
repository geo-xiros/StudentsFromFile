using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace StudentsFromFile
{
    public enum Conduct { Poor, Good, Excellent };

    public class Student
    {
        public string Name;
        public string Surname;
        public byte Age;
        public float Height;
        public decimal Tuition;
        public DateTime Date;
        public String Phone;
        public Conduct Conduct;

        public void ParseName(string name) { Name = name; }
        public void ParseSurname(string surname) { Surname = surname; }
        public void ParseAge(string age) { byte.TryParse(age, out Age); }
        public void ParseHeight(string height) { float.TryParse(height, out Height); }
        public void ParseTuition(string tuition) { decimal.TryParse(tuition, out Tuition); }
        public void ParseDate(string date) { DateTime.TryParse(date, out Date); }
        public void ParsePhone(string phone) { Phone = phone; }

        public override string ToString()
        {
            return Name + ", " + Surname + ", " + Age + ", " + Height + ", " + Tuition + ", " + Date + ", " + Phone + ", " + Conduct;//"{Name+ ", " +Surname+ ", " +Age+ ", " +Height+ ", " +TuitionDate}, {Phone}, {Conduct}";
        }
    }
}
