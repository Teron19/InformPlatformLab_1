using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laba1
{
    class Student
    {
        private Person StudentInfo { get; set; }
        private Person.Education FormInfo { get; set; }
        private int GroupNumber { get; set; }
        private Exam[] ExamInfo { get; set; }

        public double MediumMark //обчислюється середнє значення оцінок
        {
            get
            {
                double Value = 0;

                if (ExamInfo == null) return 0;
                else
                {
                    for (int i = 0; i < ExamInfo.Length; i++)
                    {
                        Value += ExamInfo[i].Mark;
                    }
                    Value = Value / ExamInfo.Length;
                    return Value;
                }
            }
        }

        public bool this[Person.Education Check]
        {
            get
            {
                return Check == FormInfo;
            }
        }

        Student(Person student, Person.Education form, int group)
        {
            StudentInfo = student;
            FormInfo = form;
            GroupNumber = group;
        }

        Student()
        {
            StudentInfo = new Person();
            FormInfo = Person.Education.Bachelor;
            GroupNumber = 301;
            ExamInfo = new Exam[] { new Exam(), new Exam("Mathematics", 3, new DateTime()) };
        }

        public void AddExams(params Exam[] input)
        {
            Exam[] Temp;
            if (ExamInfo == null)
            {
                Temp = new Exam[input.Length];
            }
            else
            {
                Temp = new Exam[ExamInfo.Length + input.Length];
            }


            int j = 0;

            for (int i = 0; i < Temp.Length; i++)
            {
                if (ExamInfo == null)
                {
                    Temp[i] = input[j];
                    j++;
                }
                else if (i < ExamInfo.Length)
                {
                    Temp[i] = ExamInfo[i];
                }
                else if(i >= ExamInfo.Length)
                {
                    Temp[i] = input[j];
                }
            }

            ExamInfo = new Exam[Temp.Length];
            ExamInfo = Temp;
            
        }

        public override string ToString()
        {
            if (ExamInfo == null) return StudentInfo + " " + FormInfo + " " + GroupNumber + " ";
            else
            {
                for (int i = 0; i < ExamInfo.Length; i++)
                {
                    Console.WriteLine(ExamInfo[i]);
                }
                return StudentInfo + " " + FormInfo + " " + GroupNumber + " ";
            }
        }

        public string ToShortString()
        {
            return StudentInfo + " " + FormInfo + " " + GroupNumber + " " + "Середнiй бал: " + MediumMark;
        }

        static void Main(string[] args)
        {
            Student T = new Student();
            int col = 2;
            int row = 2;
            
            //Час
            long start = DateTime.UtcNow.Ticks;
            long duration;

            //Масиви
            Exam[] A = new Exam[col*row];
            Exam[,] B = new Exam[col, row];
            Exam[][] C = new Exam[2][];

            //Виконання
            Console.WriteLine(T.ToShortString());

            T = new Student(new Person("Vlad", "Mordasov", new DateTime(1998, 10, 19)), Person.Education.Bachelor, 301);

            Console.WriteLine(T.ToString());

            T.AddExams(new Exam[] { new Exam("C#", 5, new DateTime()), new Exam("JS", 4, new DateTime()) });
            
            Console.WriteLine(T.ToString());

            Console.WriteLine(T.ToShortString());

            //Одновимірний масив
            A[0] = new Exam("Mathematics", 5, new DateTime());
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = A[0];
            }
            duration = DateTime.UtcNow.Ticks - start;
            Console.WriteLine("Час одновимiрного масива: " + duration + Environment.NewLine);

            //Двовимірний масив            
            B[0, 0] = new Exam("Mathematics", 5, new DateTime());
            start = DateTime.UtcNow.Ticks;
            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    B[i, j] = B[0, 0];
                }
            }
            duration = DateTime.UtcNow.Ticks - start;
            Console.WriteLine("Час двовимiрного масива: " + duration + Environment.NewLine);

            //Зубчатий массив            
            C[0] = new Exam[800000];
            C[1] = new Exam[200000];
            C[0][0] = new Exam("Mathematics", 5, new DateTime());
            start = DateTime.UtcNow.Ticks;
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C[i].Length; j++)
                {
                    C[i][j] = C[0][0];
                }
            }
            duration = DateTime.UtcNow.Ticks - start;
            Console.WriteLine("Час зубчатого масива: " + duration + Environment.NewLine);

            Console.ReadKey();
        }

    }
}
