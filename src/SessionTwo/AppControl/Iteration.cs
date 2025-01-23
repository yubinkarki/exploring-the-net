// Iteration statements enable program execution to repeat: for, foreach, while, do

namespace ExploringTheNet.src.SessionTwo.AppControl;

using System;

// for and foreach loops already covered
public static class Iteration {
    public static void Run() {
        int number;
        int counter = 1;
        string userInput;
        bool isValidInput;

        while (counter <= 5) {
            Console.WriteLine($"Counter - {counter}");
            counter++;
        }

        Console.WriteLine("\nEnter your name:");
        while ((userInput = Console.ReadLine() ?? "") != "exit") {
            Console.WriteLine($"\nYou entered: {userInput}");
        }

        // Do something while condition is true
        do {
            Console.Write("\nPlease enter a valid integer: ");
            isValidInput = int.TryParse(Console.ReadLine(), out number);
            if (!isValidInput) {
                Console.WriteLine("Please try again");
            }
        } while (!isValidInput);

        Console.WriteLine($"You entered a valid number: {number}");

        // Fix the printed pattern
        for (int i = 1; i < 5; i++) {
            for (int j = 1; j < 5; j++) {
                Console.Write("*\t");
            }

            Console.WriteLine();
        }
    }
}
