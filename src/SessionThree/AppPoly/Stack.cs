namespace ExploringTheNet.SessionThree.AppPoly;

using System;

public class CustomStack<T> {
    private int top;
    private T[] elements;

    public string stackMessage = "This is parent Stack";

    public CustomStack(int capacity) {
        elements = new T[capacity];
        top = -1;
    }

    public void Push(T item) {
        if (top == elements.Length - 1) throw new Exception("Stack overflow");
        elements[++top] = item;
    }

    public T Pop() {
        if (top == -1) throw new Exception("Stack underflow");
        return elements[top--];
    }

    public void ShowStack() {
        for (int i = 0; i <= top; i++) {
            T item = elements[i];
            Console.WriteLine(item);
        }
    }
}

public class AnotherStack : CustomStack<int> {
    public new string stackMessage = "This is another Stack";

    // Calling parent constructor
    public AnotherStack(int capacity) : base(capacity) {}

    public void ShowBase() {
        // Using the base keyword
        Console.WriteLine(base.stackMessage);
        Console.WriteLine(stackMessage);
    }
}
