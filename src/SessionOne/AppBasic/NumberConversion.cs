namespace ExploringTheNet.SessionOne.AppBasic;

using System;

public static class NumberConversion {
    public static void Run() {
        int numOne = 10;
        short numFour = 0;
        decimal numTwo = 20.111m;

        long numThree = numOne;

        float numFive = (float)numTwo;

        int numSix = (int)numFive;

        Type intType = typeof(int);

        if (numTwo >= short.MinValue && numTwo <= short.MaxValue) {
            numFour = (short)numTwo;
            Console.WriteLine("numTwo type casting into short successful");
        }

        Console.WriteLine("\nResult:");
        Console.WriteLine(
            $"numOne > {numOne.GetType()} > {numOne}\n" +
            $"numTwo > {numTwo.GetType()} > {numTwo}\n" +
            $"numThree > {numThree.GetType()} > {numThree}\n" +
            $"numFour > {numFour.GetType()} > {numFour}\n" +
            $"numFive > {numFive.GetType()} > {numFive}\n" +
            $"numSix > {numSix.GetType()} > {numSix}\n" +
            $"Int type information >> {intType}"
        );
    }
}
