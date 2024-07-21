namespace ExploringTheNet.SessionTwo.AppClass;

using System;

public static class RunAppClass {
    public static void RunAnimal() {
        Animal dog = new(name: "Golden", age: 0, species: "Nice");
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
