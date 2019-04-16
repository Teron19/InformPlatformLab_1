using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Laba1
{
    public class Person
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime DateOfBirth { get; set; }

        public Person()
        {
            Name = "None";
            Surname = "None";
            DateOfBirth = new DateTime(1998, 10, 19);
        }

        public Person(string newName, string newSurname, DateTime Date)
        {
            Name = newName;
            Surname = newSurname;
            DateOfBirth = Date;
        }


        int ChangeDateOfBirth
        {
            get
            {
                return DateOfBirth.Year;
            }
            set
            {
                DateOfBirth = new DateTime(value, DateOfBirth.Month, DateOfBirth.Day);
            }
        }

        //Equal визначає рівність об'єктів як рівність посилань на об'єкти
        public override bool Equals(Object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Person p = (Person)obj;
                return (Name == p.Name) && (Surname == p.Surname) && (DateOfBirth == p.DateOfBirth);
            }
        }

        //Перезагрузка оператора ==
        public static bool operator ==(Person obj1, Person obj2)
        {
            if (obj1 == obj2)
                return true;
            return false;
        }

        //Перезагрузка оператора !=
        public static bool operator !=(Person obj1, Person obj2)
        {
            if (obj1 != obj2)
                return true;
            return false;
        }



        public override string ToString()
        {
            return Name + " " + Surname + " " + DateOfBirth;
        }
        

        public string ToShortString()
        {
            return Name + " " + Surname;
        }

        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation
        }

    }
}
