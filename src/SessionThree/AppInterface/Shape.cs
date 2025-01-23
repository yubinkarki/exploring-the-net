// Interfaces define what a class must do and not how it must be done

namespace ExploringTheNet.src.SessionThree.AppInterface;

using System;

public interface IShapeArea {
    // Only method signature, abstract by default
    public double getArea();
}

public interface IShapeDraw {
    public void getPosition();
}

// Multiple inheritance
public abstract class CommonShape : IShapeArea, IShapeDraw {
    private int id;

    public abstract string Name { get; set; }

    public virtual void LocateUser() {
        Console.WriteLine("This is inside LocateUser");
    }

    public abstract double getArea();
    public abstract void getPosition();

    public int getId() {
        return this.id;
    }
}

// Hybrid inheritance
public class Circle : CommonShape {
    // These are fields
    private double radius = 0;
    private string name = "Circle";

    // This is a property with accessors
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

    public override double getArea() {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2);
    }

    public override void getPosition() {
        Console.WriteLine($"⚡️ --- Drawing a {Name} --- ⚡️");
    }
}

public static class ShapeManager {
    public static void PrintShapeInfo(CommonShape shape) {
        shape.getPosition();
        Console.WriteLine($"Shape Name: {shape.Name}");
        Console.WriteLine($"Area: {shape.getArea()}");
    }
}
