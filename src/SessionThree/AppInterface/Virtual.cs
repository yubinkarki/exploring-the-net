// Method overriding with virtual type

namespace ExploringTheNet.SessionThree.AppInterface;

using System;

public class User {
    // Virtual method with implementation
    public virtual void Greet() {
        Console.WriteLine("Hello!");
    }
}

public class AdminUser : User {
    public override void Greet() {
        Console.WriteLine("Greetings, administrator!");
    }
}

public class GuestUser : User {
    public override void Greet() {
        Console.WriteLine("Welcome, guest!");
    }
}
