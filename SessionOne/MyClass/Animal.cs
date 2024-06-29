namespace ExploringTheNet.SessionOne.MyClass;

using System;

public class Animal {
    private readonly int _age;
    private readonly string _name;
    private readonly string _species;

    public Animal(string name, int age, string species) {
        _age = age;
        _name = name;
        _species = species;
    }

    public void MakeSound() {
        Console.WriteLine($"{_name} is making a sound!");
    }

    public void AnimalDetails() {
        Console.WriteLine("Animal Details:");
        Console.WriteLine($"Name >> {_name}\nSpecies >> {_species}\nAge >> {_age}\n");
    }
}
