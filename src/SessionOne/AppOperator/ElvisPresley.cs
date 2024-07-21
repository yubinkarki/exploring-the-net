namespace ExploringTheNet.SessionOne.AppOperator;

using System;

// In C#, the null-conditional operator is aka the Elvis operator
public static class ElvisPresley {
    public static void Run() {
        User user = new User();
        user.Name = "Yubin Karki";

        Address address = new Address();
        address.Street = "Kathmandu";

        string userName = user.Name;
        string separateStreet = address.Street;
        string userStreet = user?.Address?.Street ?? "Default Street";

        Console.WriteLine($"User name is {userName}");
        Console.WriteLine($"Separate street is {separateStreet}");

        if (userStreet is not null) {
            Console.WriteLine($"User street is {userStreet} 🏠");
        } else Console.WriteLine("User has no street 💥");
    }
}