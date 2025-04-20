namespace ExploringTheNet.SessionThree.AppClass;

using System;

public static class RunAppClass {
    public static void RunAnimal() {
        Animal dog = new Animal(name: "Golden", age: 0, species: "Nice");
        // Animal cat = new Animal();
        // Animal bird = new();

        Console.WriteLine($"Dog was {dog.Age} years old");
        dog.Age = 10;
        Console.WriteLine($"Dog is {dog.Age} years old after update\n");
        dog.AnimalDetails();
        dog.MakeSound();
        dog.MakeSound(animalName: "Labrador");
    }

    public static void RunMusic() {
        Music nepali = new Music();
        Music english = new();

        nepali.Artist = "Nima Rumba";
        nepali.Genre = "Rock n Roll";
        nepali.Title = "Thik Cha Malai";

        nepali.ShowInfo();
        Console.WriteLine();
        english.ShowInfo();
    }

    public static void RunStudentIndexer() {
        StudentIndexer kct = new(5);

        kct[0] = "One";
        kct[1] = "Two";
        kct[2] = "Three";
        kct[3] = "Four";
        kct[4] = "Five";

        for (int i = 0; i < kct.NameList.Length; i++) {
            Console.WriteLine(kct[i]);
        }
    }

    public static void RunAccessibility() {
        Derived derivedClass = new();
        derivedClass.CheckInfo();

        Megatron starscream = new();
        starscream.CheckIsAuthenticated();
    }
}
