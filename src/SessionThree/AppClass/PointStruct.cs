namespace ExploringTheNet.SessionThree.AppClass;

public struct Point {
    public int X { get; set; }
    public int Y { get; set; }

    public Point(int x, int y) {
        X = x;
        Y = y;
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
