namespace ExploringTheNet.SessionOne.AppArray;

using System;

public static class JaggedArray {
    public static void Run() {
        int[][] numbers = new int[3][] {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5 },
            new int[] { 7 },
        };

        char[][] letters = {
            new char[]{ 'a', 'e', 'i', 'o', 'u' },
            new char[]{ 'b', 'c' },
        };

        Console.WriteLine("Elements in numbers list:");
        foreach (int[] rows in numbers) {
            foreach (int item in rows) Console.Write(item + " ");
            Console.WriteLine();
        }
    }
}
