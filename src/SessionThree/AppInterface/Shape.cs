namespace ExploringTheNet.SessionThree.AppInterface;

using System;

public interface IShapeArea {
    public double GetArea();
}

public interface IShapeDraw {
    public void GetPosition();
}

public abstract class CommonShape : IShapeArea, IShapeDraw {
    public abstract string Name { get; set; }

    public abstract double GetArea();

    public abstract void GetPosition();
}

public class Circle : CommonShape {
    // These are fields
    public double Radius;
    private string _name = "Circle";

    // This is a property with accessors
    public override string Name {
        get { return _name; }
        set { _name = value; }
    }

    public override double GetArea() {
        double area = Math.PI * Radius * Radius;
        return Math.Round(area, 2);
    }

    public override void GetPosition() {
        Console.WriteLine($"⚡️ --- Drawing a {Name} --- ⚡️");
    }
}

public static class ShapeManager {
    public static void PrintShapeInfo(CommonShape shape) {
        shape.GetPosition();
        Console.WriteLine($"Shape Name: {shape.Name}");
        Console.WriteLine($"Area: {shape.GetArea()}");
    }
}
