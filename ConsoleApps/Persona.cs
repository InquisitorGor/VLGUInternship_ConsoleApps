using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApps
{

    abstract class Persona
    {
        private const String PATH = "..\\..\\..\\listOfPersons.txt";

        private String name;
        private String dateOfBirth;

        public Persona(String name, String dateOfBirth)
        {
            this.name = name;
            this.dateOfBirth = dateOfBirth;
        }
        public Persona() {}

        public int getAge()
        {
            return 2020 - Convert.ToInt32(dateOfBirth);
        }
        public virtual void Show()
        {
            Console.WriteLine("Имя: " + name);
            Console.WriteLine("День рождения: " + dateOfBirth.ToString());
            Console.WriteLine("Возраст: " + getAge());
        }
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream(PATH, FileMode.OpenOrCreate);
            StreamReader sR = new StreamReader(fileStream);
            LinkedList<Persona> personas = new LinkedList<Persona>();
            String str1 = String.Empty;
            while ((str1 = sR.ReadLine()) != null && str1 != String.Empty)
            {
                String[] str = str1.Split(';');
                switch (str[0])
                {
                    case "А":
                        {
                            personas.AddLast(new Enrollee(str[1],str[2],str[3]));
                            break;
                        }
                    case "С":
                        {
                            personas.AddLast(new Student(str[1], str[2], str[3], str[4]));
                            break;
                        }
                    case "У":
                        {
                            personas.AddLast(new Teacher(str[1], str[2], str[3], str[4]));
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Произошла ошибка!!!");
                            Console.WriteLine("Я прям в недоумении че делать");
                            Console.WriteLine("Рили озадачен");
                            break;
                        }
                }
            }
            sR.Close();
            fileStream.Close();
            foreach (var item in personas) { 
                item.Show();
                Console.WriteLine();
            }
        }



    }
    class Enrollee : Persona
    {
        private String faculty;
        public Enrollee(String name, String dateOfBirth, String faculty) : base(name,dateOfBirth)
        {
            this.faculty = faculty;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Факультет: " + faculty);
        }
    }
    class Student : Enrollee
    {
        private String course;

        public Student(String name, String dateOfBirth, String faculty,String course):base(name, dateOfBirth, faculty)
        {
            this.course = course;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Курс: " + course);
        }

    }
    class Teacher : Persona
    {
        private String position;
        private String experience;

        public Teacher(String name, String dateOfBirth, String position, String experience) : base (name,dateOfBirth)
        {
            this.position = position;
            this.experience = experience;
        }
        public override void Show()
        {
            base.Show();
            Console.WriteLine("Должность: " + position);
            Console.WriteLine("Стаж: " + experience);
        }
    }

}
