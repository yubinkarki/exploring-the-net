namespace ExploringTheNet;

using System;

using ExploringTheNet.Constant;

using ExploringTheNet.SessionOne.AppBasic;
using ExploringTheNet.SessionOne.AppArray;
using ExploringTheNet.SessionOne.AppOperator;

using ExploringTheNet.SessionTwo.AppStack;
using ExploringTheNet.SessionTwo.AppDefault;
using ExploringTheNet.SessionTwo.AppControl;

using ExploringTheNet.SessionThree.AppPoly;
using ExploringTheNet.SessionThree.AppClass;
using ExploringTheNet.SessionThree.AppInterface;

using ExploringTheNet.SessionFour.AppLinq;
using ExploringTheNet.SessionFour.AppDelegate;
using ExploringTheNet.SessionFour.AppException;

internal static class Program {
    private static void Main(string[] args) {
        if (args.Length > 0) {
            string combinedArgs = string.Join(", ", args);
            Console.WriteLine("Here are the args: " + combinedArgs);
        } else {
            Console.WriteLine($"{AppString.RunWithoutArgument}");
            Console.WriteLine(AppString.Separator);
            // RunAppDelegate.RunTryCatch();
            // RunAppException.RunTryCatch();
            RunAppLinq.GetStats();
            Console.WriteLine(AppString.Separator);
        }
    }
}
