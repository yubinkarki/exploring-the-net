// Selection statements: if and switch
namespace ExploringTheNet.SessionTwo.AppControl;

using System;

public static class Selection {
    public static void Run() {
        bool isLoggedIn = true;
        bool isActive = true;
        int i = 25, j = 20, k = 30;

        // Nested if
        if (isLoggedIn && isActive) {
            if (i > j && i > k) Console.WriteLine("i is greatest");

            if (j > k && j > i) {
                Console.WriteLine("j is greatest");
            } else Console.WriteLine("k is greatest");
        } else Console.WriteLine("Invalid user");

        // If else ladder
        if (i == j) {
            Console.WriteLine("i == j");
        } else if (i > j) {
            Console.WriteLine("i > j");
        } else if (i < j) {
            Console.WriteLine("i < j");
        } else {
            Console.WriteLine("Invalid number");
        }
    }
}
