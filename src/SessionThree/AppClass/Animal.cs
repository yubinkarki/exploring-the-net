namespace ExploringTheNet.SessionThree.AppClass;

using System;

public class Animal {
    // Fields
    private uint? age;
    private readonly string? name;
    private readonly string? species;

    // Properties
    public uint? Age {
        get { return this.age; }
        set {
            if (value < 18) throw new ArithmeticException("Invalid age");
            this.age = value;
        }
    }

    public string? Name { get; set; }
    public string? Species { get; set; }

    // Invoked once on the first instance
    static Animal() {
        Console.WriteLine("This is inside Animal static constructor");
    }

    public Animal(string name, uint age, string species) {
        this.age = age;
        this.name = name;
        this.species = species ?? "N/A";
    }

    public Animal() {
        Console.WriteLine("This is Animal constructor without parameters");
    }

    public void MakeSound() {
        Console.WriteLine($"{this.name} is making a sound!");
    }

    // Overloading method (same name but different signature)
    public void MakeSound(string animalName) {
        Console.WriteLine($"{animalName} is method overloaded!");
    }

    public void AnimalDetails() {
        Console.WriteLine("Animal Details:");
        Console.WriteLine($"Name >> {this.name}\nSpecies >> {this.species}\nAge >> {this.age}\n");
    }

    // Destructor
    ~Animal() {
        Console.WriteLine("Animal class destroyed");
    }
}
