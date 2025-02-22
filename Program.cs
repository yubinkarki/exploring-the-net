namespace ExploringTheNet;

using System;

using ExploringTheNet.src.Constant;

using ExploringTheNet.src.SessionOne.AppBasic;
using ExploringTheNet.src.SessionOne.AppArray;
using ExploringTheNet.src.SessionOne.AppOperator;

using ExploringTheNet.src.SessionTwo.AppStack;
using ExploringTheNet.src.SessionTwo.AppDefault;
using ExploringTheNet.src.SessionTwo.AppControl;

using ExploringTheNet.src.SessionThree.AppPoly;
using ExploringTheNet.src.SessionThree.AppClass;
using ExploringTheNet.src.SessionThree.AppInterface;

using ExploringTheNet.src.SessionFour.AppLinq;
using ExploringTheNet.src.SessionFour.AppDelegate;
using ExploringTheNet.src.SessionFour.AppException;

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
