using System;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Program
    {
        public static void Main()
        {
            Teacher treacher = new Teacher("Maria Skłodowska", 50);

            Student student1 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student2 = new Student("Jan Kowaslski", 21, "LAB-01");
            Student student3 = new Student("Jaś Fasola", 23, "LAB-02");

            /*student1.AddTask("Taks A", TaskStatus.Waiting);
            student1.AddTask("Taks B", TaskStatus.Waiting);
            student1.AddTask("Taks C", TaskStatus.Rejected);

            /*student2.AddTask("Taks A", TaskStatus.Waiting);
            student2.AddTask("Taks B", TaskStatus.Waiting);
            student2.AddTask("Taks C", TaskStatus.Rejected);

            student3.AddTask("Taks D", TaskStatus.Done);
            student3.AddTask("Taks E", TaskStatus.Waiting);
            student3.AddTask("Taks F", TaskStatus.Waiting);

            student3.UpdateTask(1, TaskStatus.Done);
            student3.UpdateTask(2, TaskStatus.Progress);
            */
            Person[] persons = { treacher, student1, student2, student3 };
            Classroom classroom = new Classroom("Sala Komputerowa", persons);
            
            Console.WriteLine(classroom);
            Console.WriteLine(treacher.ToString());
            Console.WriteLine("student1 == student2: " + student1.Equals(student2)); // Output: student1 == student2: true
            Console.WriteLine("student1 == student3: " + student1.Equals(student3)); // Output: student1 == student3: false
        }
        public class Person
        {
            private string name { get; set; }
            private int age { get; set; }
            public Person(string name, int age)
                {
                this.name = name;
                this.age = age;

                }
        }

        public class Teacher : Person
        {
            public Person treacher { get; set;}

            public Teacher(string name, int age) :  base(name, age)
            {
            }

        }

        
        public class Student : Person
        {
            public Person student1 { get; set; }
            public Person student2 { get; set; }
            public Person student3 { get; set; }

            public Student(string name, int age, string group) : base(name,age)
            {
            }

            internal void AddTask(string v, object rejected)
            {
               
            }
        }
        class Classroom
        {
            private string v;
            private Person[] persons;

            public Classroom(string v, Person[] persons)
            {
                this.v = v;
                this.persons = persons;
            }
            public override string ToString()
            {
                return ($"{v}{persons}");
            }
        }
    }
}