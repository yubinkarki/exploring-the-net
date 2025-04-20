namespace ExploringTheNet.SessionThree.AppClass;

using System;

public struct Point {
    private int _x;
    private int _y;

    // Parameterized constructor
    public Point(int x, int y) {
        _x = x;
        _y = y;
    }

    public int X {
        get => _x;
        set {
            if (value < 18) throw new ArithmeticException("Invalid value");
            _x = value;
        }
    }

    public int Y {
        get => _y;
        set => _y = value;
    }

    // Invalid: Cannot have a constructor without parameters
    // public Point() {}

    // Invalid: Cannot have field initializers
    // public int X = 10;
    // public int Y = 20;

    // Invalid: Cannot have a finalizer
    // ~Point() {}

    // Invalid: Cannot have virtual or protected methods
    // public virtual void Move(int dx, int dy) {}
}
