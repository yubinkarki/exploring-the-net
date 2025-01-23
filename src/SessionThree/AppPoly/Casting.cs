namespace ExploringTheNet.src.SessionThree.AppPoly;

using System;

public class User {
    public virtual void Greet() => Console.WriteLine("Hello!");
}

public class Admin : User {
    public override void Greet() => Console.WriteLine("Greetings, administrator!");
}

public class Guest : User {
    public override void Greet() => Console.WriteLine("Welcome, guest!");
}
