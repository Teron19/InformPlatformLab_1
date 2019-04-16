using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Platform
{
    class Exam
    {
        public string Name { get; set; }   // назва предмету
        public int Rating { get; set; }   //для збереження оцінки  Person Rating
        public DateTime Date { get; set; }

        public Exam(string nameSub, int ratingValue, DateTime isputDate)
        {
            this.Name = nameSub;
            this.Rating = ratingValue;
            this.Date = isputDate;
            }

        public Exam()
        {
            Name = "Devid";
            Rating = 15;
            Date = new DateTime(1997, 2, 23);
        }

        public override string ToString() => Name + " " + Rating.ToShortString() + " " + Date.ToString();

        /*public override string ToString()
        {
            return "Exam: " + Name + ", " + Date + " (" + Rating+")";
        }*/

    }
}


using System;
namespace _1
{
    public class Paper
    {
        public string Topic { get; set; }
        public Person Author { get; set; }
        public DateTime PublicDate { get; set; }

        public Paper(string topic, Person author, DateTime publicdate)
        {
            Topic = topic;
            Author = author;
            PublicDate = publicdate;
        }

        public Paper()
        {
            Topic = "Default_Topic";
            Author = new Person();
            PublicDate = new DateTime(2019, 3, 18);
        }

        public override string ToString() => Topic + " " + Author.ToShortString() + " " + PublicDate.ToString();
    }
}

