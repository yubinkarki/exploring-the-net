namespace ExploringTheNet.SessionThree.AppClass;

using System;

public class Optimus {
    // Public members are accessible from anywhere
    public int publicField = 10;

    public void PublicMethod() {
        Console.WriteLine("Public method");
    }

    // Private members are only accessible in the same class
    private readonly int privateField = 15;

    private void PrivateMethod() {
        Console.WriteLine("Private method");
    }

    // Internal members are accessible within the same assembly (project)
    internal int internalField = 20;

    internal void InternalMethod() {
        Console.WriteLine("Internal method");
    }

    // Protected members are accessible within the class and its derived classes
    protected int protectedField = 30;

    protected void ProtectedMethod() {
        Console.WriteLine("Protected method");
    }

    private protected class Helper {
        public void Info() {
            Console.WriteLine("This is an internal method");
        }
    }

    public void Check() {
        Helper helper = new();
        helper.Info();
    }
}

// Derived class extending/inheriting from Optimus
public class Derived : Optimus {
    // Derived class can access public, internal, and protected members from the base class
    public void CheckInfo() {
        Helper _ = new();
        Console.WriteLine($"PublicField: {publicField}");
        Console.WriteLine($"InternalField: {internalField}");
        Console.WriteLine($"ProtectedField: {protectedField}");
        // Console.WriteLine($"ProtectedField: {privateField}");
        PublicMethod();
        InternalMethod();
        ProtectedMethod();
        // PrivateMethod();
    }
}

public class Megatron {
    // Separate class can access public and internal members
    public void CheckIsAuthenticated() {
        Optimus prime = new();

        Console.WriteLine($"PublicField: {prime.publicField}");
        Console.WriteLine($"InternalField: {prime.internalField}");
        // Console.WriteLine($"ProtectedField: {prime.privateField}");
        // Console.WriteLine($"ProtectedField: {prime.protectedField}");
        prime.PublicMethod();
        prime.InternalMethod();
        // prime.PrivateMethod();
        // prime.ProtectedMethod();
    }
}
