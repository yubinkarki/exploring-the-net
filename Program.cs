namespace ExploringTheNet;

using System;

using ExploringTheNet.Constant;
using ExploringTheNet.SessionOne.AppBasic;
using ExploringTheNet.SessionOne.AppArray;
using ExploringTheNet.SessionTwo.AppClass;
using ExploringTheNet.SessionTwo.AppStack;
using ExploringTheNet.SessionTwo.AppDefault;
using ExploringTheNet.SessionTwo.AppControl;
using ExploringTheNet.SessionOne.AppOperator;
using ExploringTheNet.SessionTwo.AppInterface;

internal static class Program {
    private static void Main(string[] args) {
        if (args.Length > 0) {
            string combinedArgs = string.Join(", ", args);
            Console.WriteLine("Here are the args: " + combinedArgs);
        } else {
            const string message = AppString.RunWithoutArgument;
            Console.WriteLine($"{message}\n");
            RunAppControl.RunIteration();
        }
    }
}
