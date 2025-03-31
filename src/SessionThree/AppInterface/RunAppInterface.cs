namespace ExploringTheNet.SessionThree.AppInterface;

public static class RunAppInterface {
    public static void RunShape() {
        Circle ball = new();
        ball.Radius = 10.0;
        ball.Name = "Football";

        ShapeManager.PrintShapeInfo(ball);
    }
}
