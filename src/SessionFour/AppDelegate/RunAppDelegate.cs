// A delegate is an object that represents references to methods

namespace ExploringTheNet.SessionFour.AppDelegate;

using System;

public class RunAppDelegate {
    // Creating anonymous function using delegate and statement lambda
    private static readonly MathDelegate AddNumbers = (a, b) => {
        Console.WriteLine($"Sum from anonymous function is {a + b}");
        return a + b;
    };

    public static void RunSimpleDelegate() {
        MathDelegate addNum = new(MathOperations.Add);

        int addResult = addNum(5, 10);
        Console.WriteLine($"Addition result = {addResult}");

        // Assigning multiple methods to the same delegate object
        MathDelegate multicast = new(MathOperations.Add);
        multicast += MathOperations.Subtract;
        multicast += MathOperations.Multiply;

        int multicastResult = multicast(2, 2);
        Console.WriteLine($"Multicast result = {multicastResult}");

        // Calling the below method with the callback argument
        RunFuncDelegate(AddNumbers);
    }

    // Accepting a callback parameter | Function and Action delegates
    public static void RunFuncDelegate(MathDelegate addCallback) {
        Func<int, int, int> addDelegate = MathOperations.Add;
        int addResult = addDelegate(5, 10);
        Console.WriteLine($"Addition result = {addResult}");

        // Action delegate can only be used with void return type
        Action<string> greet = BasicOperations.GreetUser;
        greet("Yubin");

        // Calling the anonymous function
        addCallback(10, 10);
    }
}
