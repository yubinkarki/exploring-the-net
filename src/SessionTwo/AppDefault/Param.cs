namespace ExploringTheNet.SessionTwo.AppDefault;

using System;

public static class Param {
    public static void Run() {
        AddNumber(1, 2);
    }

    private static void AddNumber(int numOne, int numTwo) {
        int result = numOne + numTwo;
        Console.WriteLine("Sum = " + result);
    }
}