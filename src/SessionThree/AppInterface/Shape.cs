// Interfaces define what a class must do and not how it must be done

namespace ExploringTheNet.SessionThree.AppInterface;

using System;

public interface IShapeArea {
    // Only method signature, abstract by default
    double GetArea();
}

public interface IShapeDraw {
    void GetPosition();
}

// Multiple inheritance - dynamic polymorphism with abstract
public abstract class CommonShape : IShapeArea, IShapeDraw {
    private readonly int id;

    public abstract string Name { get; set; }

    public virtual void LocateUser() {
        Console.WriteLine("This is inside LocateUser");
    }

    public int GetId() {
        return id;
    }

    // These two come from the interfaces above
    public abstract double GetArea();
    public abstract void GetPosition();
}

// Hybrid inheritance
public class Circle : CommonShape {
    private double radius = 0;
    private string name = "Circle";

    public override string Name {
        get { return name; }
        set { name = value; }
    }

    public double Radius {
        get { return radius; }
        set { radius = value; }
    }

    public override void LocateUser() {
        Console.WriteLine("This is inside overridden LocateUser method");
    }

    public override double GetArea() {
        double area = Math.PI * radius * radius;
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
