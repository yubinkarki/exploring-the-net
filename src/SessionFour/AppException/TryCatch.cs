namespace ExploringTheNet.SessionFour.AppException;

using System;

public static class AppTryCatch {
    private static int numOne = 10, numTwo = 0;
    private static string[] nameList = ["Chris", "Jake", "Tom"];

    public static void ZeroDivision() {
        try {
            int result = numOne / numTwo;

            if (result == 5) throw new ArithmeticException("Result is less than zero.");

            Console.WriteLine($"Division result is {result}");
        } catch (DivideByZeroException e) {
            Console.WriteLine($"Can not divide by zero at {e.TargetSite}");
        } finally {
            Console.WriteLine("This always runs");
        }

        Console.WriteLine("This is outside try/catch inside ZeroDivision.");
    }

    public static void CheckRange() {
        try {
            nameList[3] = "Yubin";
        } catch (IndexOutOfRangeException e) {
            Console.WriteLine($"Invalid operation. {e.Message}");
        } catch (InvalidOperationException e) {
            Console.WriteLine($"Failed to execute this operation. {e}");
        } catch (FormatException e) {
            Console.WriteLine($"Data was not formatted properly. {e}");
        } catch (Exception e) {
            Console.WriteLine($"Something went wrong. {e}");
        }

        Console.WriteLine("This is outside try/catch inside CheckRange.");
    }
}
