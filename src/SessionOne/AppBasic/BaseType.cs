namespace ExploringTheNet.src.SessionOne.AppBasic;

using System;

public static class BaseType {
    public static void Run() {
        int numOne = 10; // Assigning the literal value 10 into numOne variable
        int numTwo = 20;
        int sum = numOne + numTwo;

        DateTime currentTime = DateTime.Now;

        const string firstName = "Yubin";

        Console.WriteLine("The sum is " + sum);
        Console.WriteLine("The name is " + firstName.ToUpper() + " " + numOne);
        Console.WriteLine($"Time: {currentTime}"); // String interpolation
        Console.WriteLine("\nTypes:");
        Console.WriteLine($"numOne >> {numOne.GetType()}");
    }
}
