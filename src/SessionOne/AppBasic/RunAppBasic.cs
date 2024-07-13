namespace ExploringTheNet.SessionOne.AppBasic;

using System;

public static class RunAppBasic {
    public static void RunBaseType() {
        BaseType.Run();
    }

    public static void RunRandomBoolean() {
        RandomBoolean.Run();
    }

    public static void RunValuePoint() {
        ValuePoint pointOne = new ValuePoint();
        pointOne.X = 10;

        ValuePoint pointTwo = pointOne;

        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");

        pointOne.X = 20;

        Console.WriteLine($"Point one X >> {pointOne.X}");
        Console.WriteLine($"Point two X >> {pointTwo.X}");
    }

    public static void RunNumberConversion() {
        NumberConversion.Run();
    }

    public static void RunCharacter() {
        Character.Run();
    }
}
