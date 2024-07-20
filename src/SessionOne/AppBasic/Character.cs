namespace ExploringTheNet.SessionOne.AppBasic;

using System;

public static class Character {
    public static void Run() {
        char copyright = '\u00A9';
        char trademark = '\u2122';
        string lastName = "Karki";
        string firstName = "Yubin";
        string directoryPath = @"src\SessionOne\AppBasic\Character.cs";

        string fullName = firstName + lastName;
        bool resultName = firstName == lastName;

        Console.WriteLine(firstName.CompareTo(lastName));

        if (firstName.CompareTo(lastName) == 0) {
            Console.WriteLine("First name is equal to last name");
        }

        Console.WriteLine($"Full name {copyright} is {fullName} {trademark}");
        Console.WriteLine("Current directory is " + directoryPath);
        Console.WriteLine($"Comparison result is {resultName}");
    }
}
