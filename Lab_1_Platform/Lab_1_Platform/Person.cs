using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;
// ctrl + shift + a - створити новий класс
namespace Lab_1_Platform
{
    //перераховую значення за допомогою enum 
    enum Education
    {
        Master,
        Bachelor,
        SocondEducation
    }


    class Person
    {
        private string name;
        private string surname;
        private System.DateTime date;

        public string Name
        {
            get => name; set => name = value;
        }
        public string Surname
        {
            get => surname;
            set => surname = value;
        }
        public DateTime Date
        {
            get => date;
            set => date = value;
        }
        //+ 
        public Person(string name, string surname, System.DateTime date)
        {
            this.Name = name;
            this.Surname = surname;
            this.Date = date;
        }
        //заповнюю поля данними 
        public Person()
        {
            this.Name = "Jack";
            this.Surname = "Grover";
            this.Date = new DateTime(1995, 03, 15);
        }
        //щоб змінити рік
        public int dateYear
        {
            get { return date.Year; }
            set { this.date = new DateTime(dateYear, date.Month, date.Day); }
        }
        public override string ToString()
        {
            return "Name: " + name + ", Surname: " + ", Date: " + date;
        }
        public virtual string ToShortString()
        {
            return "Name: " + name + ", Surname: " + surname;
        }

        static void Main(string[] args)
        {
            Person p = new Person();
            Console.Write(p.ToString());


            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*Exam exam1 = new Exam();
Console.Write(exam1);
Console.ReadKey();
*/

/*
DateTime now = DateTime.Now;
Console.WriteLine(now.ToString("hh:mm:ss")); //   вывод времени 
Console.WriteLine(now.ToString("dd.MM.yyyy")); //   вывод текущей дати 
Thread.Sleep(50000);  //   задержка екрана
*/

/*
            DateTime dt = new DateTime(2042, 12, 24);
            DateTime date = dt.Date;
            Console.WriteLine(date.ToString());
            Thread.Sleep(50000);
 */
/*   
}


}
}
*/













































/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Platform
{
    class Person
    {
        private string _name;
        private string _surname;
        private DateTime _birthdate;

        public Person(string name, string surname, DateTime birthdate)
        {
            _name = name;
            _surname = surname;
            _birthdate = birthdate;
        }

        public Person()
        {
            _name = "Default_Name";
            _surname = "Default_Surname";
            _birthdate = new DateTime(1998, 11, 23);
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Surname
        {
            get => _surname;
            set => _surname = value;
        }

        public DateTime Birthdate
        {
            get => _birthdate;
            set => _birthdate = value;
        }

        public int Year
        {
            get => _birthdate.Year;
            set => _birthdate = new DateTime(value, _birthdate.Month, _birthdate.Day);
        }

        public override string ToString() => Surname + " " + Name + " " + Birthdate.Day + "/" + Birthdate.Month + "/" + Birthdate.Year;

        public virtual string ToShortString()
        {
            return Surname + " " + Name;
        }
    }
}
*/
  