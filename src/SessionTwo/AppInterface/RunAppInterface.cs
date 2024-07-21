namespace ExploringTheNet.SessionTwo.AppInterface;

public class RunAppInterface {
    public static void RunAppShape() {
        Circle ball = new();
        ball.Radius = 10.0;
        ball.Name = "Football";

        ShapeManager.PrintShapeInfo(ball);
    }
}
