namespace ExploringTheNet.SessionThree.AppClass;

using System;

public static class RunAppClass {
    public static void RunAnimal() {
        Animal dog = new Animal(name: "Golden", age: 0, species: "Nice");

        Console.WriteLine($"Dog was {dog.Age} years old");
        dog.Age = 10;
        Console.WriteLine($"Dog is {dog.Age} years old after update\n");
        dog.AnimalDetails();
        dog.MakeSound();
    }

    public static void RunMusic() {
        Music nepali = new();
        Music english = new();

        nepali.Artist = "Nima Rumba";
        nepali.Genre = "Rock n Roll";
        nepali.Title = "Thik Cha Malai";

        nepali.ShowInfo();
        Console.WriteLine();
        english.ShowInfo();
    }
}
