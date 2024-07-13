namespace ExploringTheNet.SessionOne.AppOperator;

using System;

public static class Arithmetic {
    public static void Run() {
        int numTwo = 20;
        int numOne = 12;
        int numFour = 0;
        int numThree = 4;

        int sum = numOne + numTwo;
        int product = numOne * numTwo;
        int quotient = numTwo / numOne;
        int remainder = numTwo % numOne;
        int difference = numTwo - numOne;
        numOne++;
        numTwo--;

        Console.WriteLine(
            $"{numOne} + {numTwo} = {sum}\n" +
            $"{numOne} * {numTwo} = {product}\n" +
            $"{numTwo} / {numOne} = {quotient}\n" +
            $"{numTwo} % {numOne} = {remainder}\n" +
            $"{numTwo} - {numOne} = {difference}\n" +
            $"After increment numOne = {numOne}\n" +
            $"After decrement numTwo = {numTwo}\n"
        );

        numThree += 10; // numThree = numThree + 10
        numFour -= numThree;

        // Implement *= /= %= <<= >>= &= ^= |=

        Console.WriteLine("After re-assignment:");
        Console.WriteLine(
            $"numThree = {numThree}\n" +
            $"numFour = {numFour}\n"
        );
    }
}
