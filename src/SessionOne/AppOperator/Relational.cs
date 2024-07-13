namespace ExploringTheNet.SessionOne.AppOperator;

using System;

public static class Relational {
    public static void Run() {
        int primary = 10;
        int secondary = 20;

        bool isEqual = primary == secondary;
        bool isNotEqual = primary != secondary;
        bool isGreater = primary > secondary;
        bool isLess = primary < secondary;
        bool isGreaterOrEqual = primary >= secondary;
        bool isLessOrEqual = primary <= secondary;

        if (!isEqual) {
            Console.WriteLine("Inside NOT");
        }

        if ((isLess || isGreaterOrEqual) && (isEqual)) {
            Console.WriteLine("Inside OR");
        }

        Console.WriteLine(
            $"{primary} == {secondary} ? {isEqual}\n" +
            $"{primary} != {secondary} ? {isNotEqual}\n" +
            $"{primary} > {secondary} ? {isGreater}\n" +
            $"{primary} < {secondary} ? {isLess}\n" +
            $"{primary} >= {secondary} ? {isGreaterOrEqual}\n" +
            $"{primary} <= {secondary} ? {isLessOrEqual}\n"
        );
    }
}
