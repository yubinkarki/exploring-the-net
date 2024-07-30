// Definite assignment policy
namespace ExploringTheNet.SessionTwo.AppDefault;

using System;

public static class Definite {
    // Fields are initialized with default values
    private static int age;
    private static bool isOn;
    private static string? name;

    public static void Run() {
        // Local variable must be assigned a value
        int point = 10;

        // Arrays are initialized with default values
        int[] numbers = new int[5];
        string[] sports = new string[2];

        Console.WriteLine($"Is on? = {isOn}");
        Console.WriteLine($"Name = {name}\tAge = {age}");
        Console.WriteLine($"This first value of sports = {sports[0]}");
        Console.WriteLine($"This first value of numbers = {numbers[0]}");

        // Argument must be supplied when a method is called
        AddTwoNumbers(1, 2);
        IncrementByOne(point);
        Console.WriteLine($"Old number is {point}");
    }

    private static void AddTwoNumbers(int a, int? b = 1) {
        Console.WriteLine("Sum is " + a + b);
    }

    private static void IncrementByOne(int num) {
        num += 1;
        Console.WriteLine($"New number is {num}");
    }
}