namespace ExploringTheNet.src.SessionTwo.AppDefault;

using System;

public static class Param {
    public static void Run() {
        int mainNumber = 10;

        AddNumber(numOne: 1); // Named argument

        IncrementByOne(ref mainNumber);
        Console.WriteLine($"Old number is {mainNumber}");

        JumbleNumbers(a: 5, b: 6, out int numOne, out int numTwo);

        // Exercise 2.1

        Console.WriteLine($"Sum of params = {MajorSum(1, 1, 1, 1)}\n");

        // Exercise 2.2
        MajorMultiplication(1, 2, 3, 4, 5, 6);
    }

    // Pass by value
    private static void AddNumber(int numOne, int numTwo = 10) {
        int result = numOne + numTwo;
        Console.WriteLine("Sum = " + result);
    }

    // Pass by reference
    private static void IncrementByOne(ref int num) {
        num += 1;
        Console.WriteLine($"New number is {num}");
    }

    // Out param modifier
    private static bool JumbleNumbers(int a, int b, out int x, out int y) {
        x = b;
        y = a;
        return true;
    }

    // Params modifier
    private static int MajorSum(params int[] numbers) {
        int sum = 0;
        foreach (int num in numbers) sum += num;
        return sum;
    }

    private static void MajorMultiplication(params int[] numbers) {
        int[,] result = new int[numbers.Length, 5];

        // Calculating and saving the result
        for (int i = 0; i < numbers.Length; i++) {
            for (int j = 0; j < 5; j++) {
                result[i, j] = numbers[i] * (j + 1);
            }
        }

        // Formatting and displaying the result
        for (int i = 0; i < result.GetLength(0); i++) {
            Console.Write($"Multiplication of {numbers[i]} = ");
            for (int j = 0; j < result.GetLength(1); j++) {
                Console.Write(result[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
