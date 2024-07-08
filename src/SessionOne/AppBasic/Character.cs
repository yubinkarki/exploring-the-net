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
        int result = firstName.CompareTo(lastName);

        Console.WriteLine($"{trademark} {copyright} Full name is {fullName}");
        Console.WriteLine("Current directory is " + directoryPath);
        Console.WriteLine($"Comparison result is {result}");
    }
}