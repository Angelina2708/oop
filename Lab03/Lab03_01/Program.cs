using System.IO;
using System.Text;
using System;

class Person
{
    public void Greet()
    {
        Console.WriteLine("Hello!");
    }

    public void SetAge(int age)
    {
        this.Age = age;
    }

    public int Age { get; private set; }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("I'm studying");
    }

    public void ShowAge()
    {
        Console.WriteLine("My age is: {0} years old", this.Age);
    }
}

class Professor : Person
{
    public void Explain()
    {
        Console.WriteLine("I'm explaining");
    }
}

class StudentProfessorTest
{
    static void Main(string[] args)
    {
        Person person = new Person();
        person.Greet();

        Student student = new Student();
        student.SetAge(20);
        student.Greet();
        student.ShowAge();

        Professor professor = new Professor();
        professor.SetAge(40);
        professor.Greet();
        professor.Explain();
    }
}

