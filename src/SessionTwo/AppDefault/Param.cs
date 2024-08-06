namespace ExploringTheNet.SessionTwo.AppDefault;

using System;

public static class Param {
    public static void Run() {
        int mainNumber = 10;

        AddNumber(1, 2);

        IncrementByOne(ref mainNumber);
        Console.WriteLine($"Old number is {mainNumber}");

        JumbleNumbers(5, 6, out int numOne, out int numTwo);
        // Exercise 2.1

        Console.WriteLine($"Sum of params = {MajorSum(1, 1, 1, 1)}");

        // Exercise 2.2
        // MajorMultiplication(1, 1, 2, 2, 5, 6, 6, 10);
    }

    // Pass by value
    private static void AddNumber(int numOne, int numTwo) {
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
        x = a; y = b;
        return true;
    }

    private static int MajorSum(params int[] numbers) {
        int sum = 0;
        foreach (int num in numbers) sum += num;
        return sum;
    }

    private static void MajorMultiplication(params int[] numbers) {
        int[,] result = new int[numbers.Length, 5];

        for (int i = 0; i < numbers.Length; i++) {
            for (int j = 0; j < 5; j++) {
                result[i, j] = numbers[i] * (j + 1);
            }
        }

        for (int i = 0; i < result.GetLength(0); i++) {
            Console.Write($"Multiplication of {numbers[i]} = ");
            for (int j = 0; j < result.GetLength(1); j++) {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
