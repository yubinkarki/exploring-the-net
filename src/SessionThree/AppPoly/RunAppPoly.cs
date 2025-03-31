namespace ExploringTheNet.SessionThree.AppPoly;

using System;
using System.Collections.Generic;

using Constant;

public class RunAppPoly {
    public static void RunCasting() {
        // Upcasting - child to parent
        User admin = new Admin();
        User guest = new Guest();

        // Downcasting - parent to child
        Admin adminUser = (Admin)admin;

        adminUser.Greet();

        Guest? guestUser = guest as Guest;

        if (guestUser != null) {
            guestUser.Greet();
        }
    }

    public static void RunOperatorOverloading() {
        ComplexNumber c1 = new(2, 3);
        ComplexNumber c2 = new(4, 5);

        ComplexNumber result = c1 + c2;
        Console.WriteLine(result.ToString());

        Increment inc = new(5);
        Increment resultOne = inc++;
        Console.WriteLine($"This is incremented value {resultOne.ToString()}");
    }

    public static void RunStack() {
        int x = 9;
        object y = x; // Boxing the int x into object y
        int z = (int)y; // Unboxing the object y into int z

        CustomStack<int> myStack = new(4);
        myStack.Push(1);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Push(2);
        myStack.Pop();
        myStack.ShowStack();

        // Getting the type of an object
        Console.WriteLine(myStack.GetType());
        Type stackType = typeof(CustomStack<string>);
        Console.WriteLine($"Type of CustomStack = {stackType}");

        Console.WriteLine($"User role = {AppEnum.UserRole.admin} at position {(int)AppEnum.UserRole.admin}");

        AnotherStack newStack = new(10);
        newStack.ShowBase();
    }

    public static void RunDictionary() {
        // Creating a dictionary with string keys and int values
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adding key-value pairs to the dictionary
        ages["John"] = 30;
        ages["Alex"] = 25;
        ages["Tom"] = 45;

        // Accessing values by key
        Console.WriteLine($"John's age: {ages["John"]}");
        Console.WriteLine($"Alex's age: {ages["Alex"]}");

        // Iterating over the dictionary and printing key-value pairs
        foreach (KeyValuePair<string, int> entry in ages) {
            Console.WriteLine($"{entry.Key} is {entry.Value} years old.");
        }

        // Checking if a key exists
        if (ages.TryGetValue("Tom", out int value)) Console.WriteLine($"Tom's age: {value}");
    }

    public static void RunQueue() {
        // Creating a queue of integers
        Queue<int> queue = new Queue<int>();

        // Enqueue elements
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        // Peek at the front element without removing it
        Console.WriteLine($"Front element: {queue.Peek()}");

        // Dequeue elements
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");
        Console.WriteLine($"Dequeued: {queue.Dequeue()}");

        // Check the number of elements left
        Console.WriteLine($"Number of elements in queue: {queue.Count}");

        // Iterate over the remaining elements
        foreach (int item in queue) {
            Console.WriteLine(item);
        }
    }
}
