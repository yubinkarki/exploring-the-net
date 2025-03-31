// Transfers control to another part of your program: break, continue, goto, return, throw

namespace ExploringTheNet.SessionTwo.AppControl {
    using System;

    public class Foo { }

    public static class Jump {
        public static void Run() {
            int count = 1, number = 1;
            int[] numbers = [2, 4, 6, 12, 8, 10];

            // Using break to terminate a loop
            for (int i = 0; i < numbers.Length; i++) {
                if (numbers[i] > 10) {
                    Console.WriteLine($"Number greater than 10 found: {numbers[i]}");
                    break;
                }

                Console.WriteLine($"Number {numbers[i]} at index {i}");
            }

            Console.WriteLine();
            Console.Write("Odd numbers: ");
            while (count <= 10) {
                if (count % 2 == 0) {
                    count++;
                    continue; // Skip the rest of the loop body for this iteration
                }

                Console.Write(count + " ");
                count++;
            }

            Console.WriteLine();
            ProcessNumbers();
            Console.WriteLine();

            Console.WriteLine("\nFrom goto statement");
        startLoop:
            if (number <= 5) {
                Console.Write(number + " ");
                number++;
                goto startLoop;
            }
        }

        private static void ProcessNumbers() {
            Console.Write("Numbers from function: ");
            for (int i = 1; i <= 10; i++) {
                if (i == 5) {
                    return;
                }

                Console.Write(i + " ");
            }

            Console.Write("\nThe breaking condition has been encountered.");
        }
    }

    namespace Inner {
        public class Foo { }

        public class Test {
            public readonly Foo? innerFoo; // AppControl.Inner.Foo
            public readonly AppControl.Foo? outerFoo; // AppControl.Foo
        }
    }
}
