namespace ExploringTheNet.SessionOne.AppBasic;

using System;

public class ValuePoint {
    public int X { get; set; }
    public int Y { get; set; }
}

public class CopyByValue {
    public static void Run() {
        ValuePoint pointOne = new() { X = 10 };

        ValuePoint pointTwo = pointOne; // Assigning a copy/reference of pointOne to pointTwo

        Console.WriteLine("Before changing value of x in pointOne:");
        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");

        pointOne.X = 20; // Changing value of X in pointOne

        Console.WriteLine("\nAfter changing value of x in pointOne:");
        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");
    }
}
