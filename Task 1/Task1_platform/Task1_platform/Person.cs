using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_platform
{
    class Person
    {
        public enum Education
        {
            Master,
            Bachelor,
            SecondEducation
        }

        private string Name { get; set; }
        private string Surname { get; set; }
        private DateTime DateBirth { get; set; }

        public Person()
        {
            Name = "None";
            Surname = "None";
            DateBirth = new DateTime(1998, 10, 19);
        }

        public Person(string newName, string newSurname, DateTime Date)
        {
            Name = newName;
            Surname = newSurname;
            DateBirth = Date;
        }


        int ChangeDateOfBirsday
        {
            get
            {
                return DateBirth.Year;
            }
            set
            {
                DateBirth = new DateTime(value, DateBirth.Month, DateBirth.Day);
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
                return (Name == p.Name) && (Surname == p.Surname) && (DateBirth == p.DateBirth);
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
            return Name + " " + Surname + " " + DateBirth;
        }


        public string ToShortString()
        {
            return Name + " " + Surname;
        }

    }
}

   
