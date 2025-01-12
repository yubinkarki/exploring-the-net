namespace ExploringTheNet.src.SessionOne.AppArray;

using System;

public static class RectangularArray {
    public static void Run() {
        int[,] numbers = new int[3, 2]; // 3 rows, 2 columns

        int[,] digits = {
            { 1, 2, 3 },
            { 4, 5, 6 },
        };

        numbers[0, 0] = 10;
        numbers[0, 1] = 20;
        numbers[1, 0] = 30;
        numbers[1, 1] = 40;
        numbers[2, 0] = 50;
        numbers[2, 1] = 60;

        Console.WriteLine("Elements in numbers list:");
        for (int i = 0; i < numbers.GetLength(0); i++) {
            for (int j = 0; j < numbers.GetLength(1); j++) {
                Console.Write(numbers[i, j] + " ");
            }

            Console.WriteLine();
        }

        // Exercise 1.3
    }
}
