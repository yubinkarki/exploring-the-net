namespace ExploringTheNet.src.SessionOne.AppBasic;

using System;

public static class RandomBoolean {
    public static void Run() {
        bool isChecked = false;
        int randomNumber = new Random().Next(0, 100);

        bool isLess = randomNumber < 50;

        Console.WriteLine($"Random number: {randomNumber}");

        if (isChecked) {
            Console.WriteLine("This is inside isChecked");
        }

        if (isLess) {
            Console.WriteLine($"Random number is less");
        }
    }
}
