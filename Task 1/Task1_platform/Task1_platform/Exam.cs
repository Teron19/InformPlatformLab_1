using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_platform
{
    class Exam
    {
        public string Subject;
        public int Mark;
        public DateTime TimeOfExam;

        public Exam()
        {
            Subject = "Java";
            Mark = 5;
            TimeOfExam = new DateTime(2019, 03, 14);
        }

        public Exam(string subject, int mark, DateTime time)
        {
            Subject = subject;
            Mark = mark;
            TimeOfExam = time;
        }

        public override string ToString()
        {
            return Subject + " " + Mark + " " + TimeOfExam;
        }
    }
}
