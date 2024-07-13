namespace ExploringTheNet.SessionOne.AppOperator;

public class User {
    private const int Age = 30;
    private const bool IsMarried = true;
    private const string Name = "John Doe";

    public void ShowInfo() {
        System.Console.WriteLine($"Name: {Name}\nAge: {Age}\nIsMarried: {IsMarried}");
    }
}

public class Theme { }

public static class Miscellaneous {
    public static unsafe void Run() {
        int year = 2024;
        int intSize = sizeof(int);
        int charSize = sizeof(char);
        int floatSize = sizeof(float);
        int doubleSize = sizeof(double);

        int* yearPtr = &year; // Creating a pointer to an int

        System.Console.WriteLine(
            $"sizeof(int) = {intSize}\n" +
            $"sizeof(char) = {charSize}\n" +
            $"sizeof(float) = {floatSize}\n" +
            $"sizeof(double) = {doubleSize}\n"
        );

        System.Console.WriteLine($"type of int = {typeof(int)}");
        System.Console.WriteLine($"type of char = {typeof(char)}");

        System.Console.WriteLine("'year' address in memory = " + (int)yearPtr);
        System.Console.WriteLine("'year' value in memory = " + *yearPtr);

        User john = new User();

        if (john is User) {
            System.Console.WriteLine();
            john.ShowInfo();
        }

        object? planet = null;
        string mercury = planet as string;

        System.Console.WriteLine($"mercury = {mercury}");

        int maxResult = Max(a: 20, b: 20);

        System.Console.WriteLine($"Max is {maxResult}");
    }

    private static int Max(int a, int b) {
        return a > b ? a : b;
    }
}
