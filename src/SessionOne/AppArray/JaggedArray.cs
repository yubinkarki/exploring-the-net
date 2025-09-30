namespace ExploringTheNet.SessionOne.AppArray;

using System;

public static class JaggedArray {
    public static void Run() {
        int[][] numbers = [
            [1, 2, 3],
            [4, 5],
            [7],
        ];

        char[][] letters = [
            ['a', 'e', 'i', 'o', 'u'],
            ['b', 'c'],
        ];

        Console.WriteLine("Elements in numbers list:");
        foreach (int[] rows in numbers) {
            foreach (int item in rows) Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
