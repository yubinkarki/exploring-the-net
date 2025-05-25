namespace ExploringTheNet.SessionThree.AppPoly;

// Swap two numbers using a generic method
public static class SwapNumbers {
    // A generic method that works with the type "T"
    public static void SwapValues<T>(ref T a, ref T b) {
        T temp = a;

        // Swapping values
        a = b;
        b = temp;
    }
}