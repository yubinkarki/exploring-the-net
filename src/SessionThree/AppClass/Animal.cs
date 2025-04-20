namespace ExploringTheNet.SessionThree.AppClass;

using System;

public class Animal {
    // Fields
    private uint? _age;
    private readonly string? _name;
    private readonly string? _species;

    // Properties
    public string? Name { get; set; }
    public string? Species { get; set; }

    public uint? Age {
        get => this._age;
        set {
            if (value < 18) throw new ArithmeticException("Invalid age");
            this._age = value;
        }
    }

    // Invoked once on the first instance
    static Animal() {
        Console.WriteLine("This is inside Animal static constructor");
    }

    // Parameterized constructor
    public Animal(string name, uint age, string species) {
        _age = age;
        _name = name;
        _species = species ?? "N/A";
    }

    // Default constructor
    public Animal() {
        Console.WriteLine("This is Animal constructor without parameters");
    }

    public void MakeSound() {
        Console.WriteLine($"{_name} is making a sound!");
    }

    // Overloading method (same name but different signature)
    public void MakeSound(string animalName) {
        Console.WriteLine($"{animalName} is method overloaded!");
    }

    public void AnimalDetails() {
        Console.WriteLine("Animal Details:");
        Console.WriteLine($"Name >> {_name}\nSpecies >> {_species}\nAge >> {_age}\n");
    }

    // Destructor
    ~Animal() {
        Console.WriteLine("Animal class destroyed");
    }
}
