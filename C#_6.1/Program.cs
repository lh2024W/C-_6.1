using C__6._1;
using System.Diagnostics.Metrics;

namespace C__6._1
{
    class Group
    {
        List<Student> group = new List<Student>();
        public string name;
        public string specialization;
        public int course;

        public Group() : this("ПВ312", "Программирование", 2)
        {
            //Console.WriteLine ("c-tor without params");
        }

        //main c-tor
        public Group(string name, string specialization, int course)
        {
            SetName(name);
            SetSpecialization(specialization);
            SetCourse(course);
            //Console.WriteLine("main c-tor");
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetSpecialization(string specialization)
        {
            this.specialization = specialization;
        }

        public void SetCourse(int number)
        {
            course = number;
        }

        public void AddStudent(Student student)
        {
            group.Add(student);
        }

        public override string ToString()
        {
            return name + " " + specialization + " " + course + " ";
        }

    }

    class Program
    {
        static void Main()
        {
            var g = new Group();
            Student s = new Student();
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());
            Console.WriteLine();
            s = new Student("Аврамов", "Федор", "Иванович", "10.05.1999", "г.Одесса", "04825546", 9, 9, 8);
            s.AddStudent(s);
            Console.WriteLine(g.ToString());
            Console.WriteLine(s.ToString());

        }
    }
}