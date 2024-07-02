using System;

using ExploringTheNet.Constant;
using ExploringTheNet.SessionOne.AppBasic;
using ExploringTheNet.SessionOne.AppClass;
using ExploringTheNet.SessionOne.AppInterface;

namespace ExploringTheNet;

internal static class Program {
    private static void Main(string[] args) {
        if (args.Length > 0) {
            string combinedArgs = string.Join(", ", args);
            Console.WriteLine("Here are the args: " + combinedArgs);
        } else {
            const string message = AppString.RunWithoutArgument;
            Console.WriteLine($"{message}\n");
            RunAppBasic.RunBaseType();
        }
    }
}
