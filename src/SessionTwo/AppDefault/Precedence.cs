namespace ExploringTheNet.src.SessionTwo.AppDefault;

using System;
using System.Text;

public static class Precedence {
    // Statements are instructions that execute sequentially in a function
    public static void Run() {
        // Declaration statements
        // const int age = 16;
        // bool hasBrain = true;
        // string name = "Myself";

        // * has higher precedence
        Console.WriteLine(1 + 2 * 3);

        // Binary operators are left associative (except for =, =>, ??)
        Console.WriteLine(8 / 4 / 2);

        // Right associative x = y = 3;

        {
            // Expression statements are expressions that are also valid statements
            // Assignment expression, method call expression, object instantiation expression
            string address;
            int x = 0, y = 0;

            x += 1;
            address = "USA";
            Console.WriteLine(address);
            y++;
            y = Math.Max(x, 5);
            new StringBuilder();
        }
    }
}
