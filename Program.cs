namespace ExploringTheNet;

using System;

using ExploringTheNet.src.Constant;

using ExploringTheNet.src.SessionOne.AppBasic;
using ExploringTheNet.src.SessionOne.AppArray;
using ExploringTheNet.src.SessionOne.AppOperator;

using ExploringTheNet.src.SessionTwo.AppStack;
using ExploringTheNet.src.SessionTwo.AppDefault;
using ExploringTheNet.src.SessionTwo.AppControl;

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
            // RunAppDelegate.RunFuncDelegate();
            // RunAppException.RunTryCatch();
            RunAppLinq.FilterEmployee();
            Console.WriteLine(AppString.Separator);
        }
    }
}
