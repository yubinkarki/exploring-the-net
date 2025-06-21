namespace ExploringTheNet;

using System;

using Constant;

using SessionOne.AppBasic;
using SessionOne.AppArray;
using SessionOne.AppOperator;

using SessionTwo.AppStack;
using SessionTwo.AppDefault;
using SessionTwo.AppControl;

using SessionThree.AppPoly;
using SessionThree.AppClass;
using SessionThree.AppInterface;

using src.SessionFour.AppLinq;
using src.SessionFour.AppDelegate;
using src.SessionFour.AppException;

public class Program {
    private static void Main(string[] args) {
        if (args.Length > 0) {
            string combinedArgs = string.Join(", ", args);
            Console.WriteLine("Here are the args: " + combinedArgs);
        } else {
            Console.WriteLine($"{AppString.RunWithoutArgument}");
            Console.WriteLine(AppString.Separator);
            // RunAppLinq.GetStats();
            AdoDatabase.AllOperations();
            Console.WriteLine(AppString.Separator);
        }
    }
}
