namespace ExploringTheNet.src.SessionTwo.AppStack;

using System;
using System.Text;

public class Factorial {
    public static void Run() {
        int factorialNumber = 5;
        int result = GetFactorial(factorialNumber);

        Console.WriteLine($"\nFactorial of {factorialNumber} = {result}\n");

        BuildString();
    }

    private static int GetFactorial(int number) {
        if (number == 0) return 1;
        return number * GetFactorial(number - 1);
    }

    private static void BuildString() {
        StringBuilder name = new StringBuilder("John");
        Console.WriteLine(name);
        // name is now eligible for GC

        StringBuilder address = new StringBuilder("London");
        StringBuilder street = address;
        // address is not yet eligible for GC

        Console.WriteLine(street);
    }
}
