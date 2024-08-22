// Control statements causes flow of execution to branch: Selection, Iteration and Jump
namespace ExploringTheNet.SessionTwo.AppControl;

public static class RunAppControl {
    // Selection: if, switch
    public static void RunSelection() {
        Selection.Run();
    }

    // Iteration: for, foreach, while, do loops
    public static void RunIteration() {
        Iteration.Run();
    }

    // Jump: break, continue, goto, return, throw
    public static void RunJump() {
        Jump.Run();
    }
}
