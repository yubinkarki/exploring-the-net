namespace ExploringTheNet.SessionFour.AppDelegate;

using System;

// [modifier] delegate [return_type] [delegate_name] ([parameter_list])
public delegate int MathDelegate(int x, int y);

public static class MathOperations {
    // Expression lambda
    public static int Add(int x, int y) => x + y;

    public static int Subtract(int x, int y) => x - y;

    public static int Multiply(int x, int y) => x * y;
}

public static class BasicOperations {
    public static void GreetUser(string name) => Console.WriteLine($"Hello {name} :)");
}
