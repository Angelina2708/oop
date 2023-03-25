using System;

class Animal
{
    public string Name { get; set; }

    public void Speak()
    {
        Console.WriteLine("Animal speaks");
    }

    public void Jump()
    {
        Console.WriteLine("Animal jumps");
    }

    public void Run()
    {
        Console.WriteLine("Animal runs");
    }
}

class Dog : Animal
{
    public void Bite()
    {
        Console.WriteLine("Dog bites");
    }
}

class Puppy : Dog
{
    public void Play()
    {
        Console.WriteLine("Puppy plays");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Puppy puppy = new Puppy();
        puppy.Name = "Archi";
        Console.WriteLine("Name: " + puppy.Name);
        puppy.Speak();
        puppy.Jump();
        puppy.Run();
        puppy.Bite();
        puppy.Play();
    }
}
