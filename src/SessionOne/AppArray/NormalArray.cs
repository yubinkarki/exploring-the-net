namespace ExploringTheNet.SessionOne.AppArray;

using System;

public static class NormalArray {
    public static void Run() {
        int[] numbers = new int[5];
        char[] letters = ['a', 'e', 'i', 'o', 'u'];

        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        Console.WriteLine("Elements in numbers list:");
        for (int i = 0; i < numbers.Length; i++) {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nElements in letters list:");
        foreach (char letter in letters) {
            Console.Write(letter + " ");
        }

        // Add all elements in the 'numbers' array
    }
}
