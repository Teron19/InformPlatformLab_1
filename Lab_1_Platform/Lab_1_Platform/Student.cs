using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Platform
{
    public class Student
    {
        private Person Info { get => Info; set => Info = value; }  // данні студента
        private Education Educations { get => Educations; set => Educations = value; }  // форма навчання 
        private int GroupNamber { get => GroupNamber; set => GroupNamber = value; }  // номер групи
        private Exam[] infoExam { get => infoExam; set => infoExam = value; }  // список іспитів

        public Person Info { get => Info; set => Info = value; }
        public Education Educations { get => Educations; set => Educations = value; }
        public int GroupNamber { get => GroupNamber; set => GroupNamber = value; }
        public Exam[] InfoExam { get => infoExam; set => infoExam = value; }

        double middleValueExam;
        
    }
    /*
    public PersonInfo(Person _info)
    {
        this.info = _info;
    }

    public _Education(Education _education)
    {
        this.education = _education;
    }
    public _groupNamber(int _infoExam)
    {
        this.infoExam = _infoExam;
    }
    /*
    public Persone info
    {
        get => info;
        set => info = value;
    }
    */
    public Student(Person newInfo, Education newEducation, int newGroupName)
    {
        Info = newInfo;
        Educations = newEducation;
        GroupNamber = newGroupName;

    }
}
