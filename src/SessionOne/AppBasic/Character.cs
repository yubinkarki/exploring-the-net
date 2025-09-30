namespace ExploringTheNet.SessionOne.AppBasic;

using System;

public static class Character {
    public static void Run() {
        int numOne = 10;
        char copyright = '\u00A9';
        char trademark = '\u2122';
        string lastName = "Karki";
        string firstName = "Yubin";
        string directoryPath = @"src\SessionOne\AppBasic\Character.cs";

        string fullName = firstName + " " + lastName + " " + numOne;
        bool resultName = firstName == lastName;

        Console.WriteLine("Result of comparison " + string.Compare(firstName, lastName, StringComparison.Ordinal));

        // firstName is larger/smaller/equal => 1/-1/0
        if (string.Compare(firstName, lastName, StringComparison.Ordinal) == 0) {
            Console.WriteLine("First name is equal to last name");
        }

        Console.WriteLine($"Full name {copyright} is {fullName} {trademark}");
        Console.WriteLine("Current directory is " + directoryPath);
        Console.WriteLine($"Comparison result is {resultName}");
    }
}
