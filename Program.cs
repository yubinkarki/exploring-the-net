namespace ExploringTheNet;

using System;

using src.Constant;

using src.SessionOne.AppBasic;
using src.SessionOne.AppArray;
using src.SessionOne.AppOperator;

using src.SessionTwo.AppStack;
using src.SessionTwo.AppDefault;
using src.SessionTwo.AppControl;

using src.SessionThree.AppPoly;
using src.SessionThree.AppClass;
using src.SessionThree.AppInterface;

using src.SessionFour.AppLinq;
using src.SessionFour.AppDelegate;
using src.SessionFour.AppException;

internal static class Program {
    private static void Main(string[] args) {
        if (args.Length > 0) {
            string combinedArgs = string.Join(", ", args);
            Console.WriteLine("Here are the args: " + combinedArgs);
        } else {
            Console.WriteLine($"{AppString.RunWithoutArgument}");
            Console.WriteLine(AppString.Separator);
            RunAppBasic.RunBaseType();
            Console.WriteLine(AppString.Separator);
        }
    }
}
