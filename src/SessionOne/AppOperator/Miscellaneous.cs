namespace ExploringTheNet.SessionOne.AppOperator;

public class User {
    private const int Age = 30;
    private const bool IsMarried = true;
    private const string Name = "John Doe";

    public void ShowInfo() {
        System.Console.WriteLine($"Name: {Name}\nAge: {Age}\nIsMarried: {IsMarried}");
    }
}

public class Theme {
    public void ShowInfo() {
        System.Console.WriteLine($"This is inside Theme");
    }
}

public static class Miscellaneous {
    public static unsafe void Run() {
        int year = 2024;
        int intSize = sizeof(int);
        int charSize = sizeof(char);
        int floatSize = sizeof(float);
        int doubleSize = sizeof(double);

        int* yearPtr = &year; // Creating a pointer

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
            System.Console.WriteLine($"\ntype of john is {typeof(User)}");
            john.ShowInfo();
        }

        object? planet = 11;
        string mercury = planet as string ?? "Earth";

        System.Console.WriteLine($"\nmercury = {mercury} \t type of mercury = {mercury.GetType()}");

        int maxResult = CheckMax(a: 20, b: 20);

        System.Console.WriteLine($"\nMax is {maxResult}");
    }
  
    private static int CheckMax(int a, int b) {
        return a > b ? a : b;
    }
}
