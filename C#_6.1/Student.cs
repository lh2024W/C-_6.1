using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace C__6._1
{
    class Student
    {
        private string? firstname;//имя
        private string? secondname;//отчество
        private string? lastname;//фамилия
        private string? birthday;//дата рождения
        private string? address;//домашний адрес
        private string? phone;//телефон
        List<Int32?> tests;//зачеты
        List<Int32?> termPapers;//курсовые работы
        List<Int32?> exams;//экзамены
        List<Student> group = new List<Student>();
        public Student() : this(10, 11, 11)
        {
            //Console.WriteLine("C-tor without params");
        }

        public Student(Int32? test, Int32? term, Int32? exam) : this("Иван", "Иванович", "Иванов", "12.01.2003", "г.Одесса ул.Пушкинская 10", "069635422", 12, 12, 12)
        {
            tests = new List<Int32?>();
            SetTests(test);
            termPapers = new List<Int32?>();
            SetTermPapers(term);
            exams = new List<Int32?>();
            SetExams(exam);

            //Console.WriteLine("C-tor with params");
        }

        public Student(string? firstname, string? secondname, string? lastname, string? birthday, string? address, string? phone, Int32? test, Int32? term, Int32? exam)//main c-tor
        {
            SetFirstname(firstname);
            SetSecondname(secondname);
            SetLastname(lastname);
            SetBirthday(birthday);
            SetAddress(address);
            SetPhone(phone);
            tests = new List<Int32?>();
            SetTests(test);
            termPapers = new List<Int32?>();
            SetTermPapers(term);
            exams = new List<Int32?>();
            SetExams(exam);

            //Console.WriteLine("Main c-tor");
        }

        public void SetFirstname(string? firstname)
        {
            this.firstname = firstname;
        }

        public void SetSecondname(string? secondname)
        {
            this.secondname = secondname;
        }

        public void SetLastname(string? lastname)
        {
            this.lastname = lastname;
        }

        public void SetBirthday(string? birthday)
        {
            this.birthday = birthday;
        }

        public void SetAddress(string? address)
        {
            this.address = address;
        }

        public void SetPhone(string? phone)
        {
            this.phone = phone;
        }

        public void SetTests(Int32? test)
        {
            tests.Add(test);
        }

        public void SetTermPapers(Int32? term)
        {
            termPapers.Add(term);
        }

        public void SetExams(Int32? exam)
        {
            exams.Add(exam);
        }

        public string? GetFirstname()
        {
            return firstname != null ? firstname : "Не задано";
        }

        public string? GetSecondname()
        {
            return secondname != null ? secondname : "Не задано";
        }

        public string? GetLastname()
        {
            return lastname != null ? lastname : "Не задано";
        }

        public string? GetBirthday()
        {
            return birthday != null ? birthday : "Не задано";
        }

        public string? GetAddress()
        {
            return address != null ? address : "Не задано";
        }

        public string? GetPhone()
        {
            return phone != null ? phone : "Не задано";
        }

        public List<Int32?> GetTests()
        {
            return tests;
        }

        public List<Int32?> GetTermPapers()
        {
            return termPapers;
        }

        public List<Int32?> GetExams()
        {
            return exams;
        }

        public void Print()
        {
            Console.WriteLine("Имя: " + firstname);
            Console.WriteLine("Отчество: " + secondname);
            Console.WriteLine("Фамилия: " + lastname);
            Console.WriteLine("Дата рождения: " + birthday);
            Console.WriteLine("Адрес проживания: " + address);
            Console.WriteLine("Телефон: " + phone);
            foreach (Int32? test in tests)
            {
                Console.WriteLine("Оценки за зачеты: " + test);
            }
            foreach (Int32? term in termPapers)
            {
                Console.WriteLine("Оценки за зачеты: " + term);
            }
            foreach (Int32? exam in exams)
            {
                Console.WriteLine("Оценки за зачеты: " + exam);
            }
            Console.WriteLine();
        }

        public override string ToString()
        {
            return firstname + " " + secondname + " " + lastname + " " + birthday + " " + address + " " + phone + " ";
        }

        public void AddStudent(Student student)
        {
            group.Add(student);
        }
    }
}
