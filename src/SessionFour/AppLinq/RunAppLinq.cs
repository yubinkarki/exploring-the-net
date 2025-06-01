namespace ExploringTheNet.src.SessionFour.AppLinq;

using System;
using System.Linq;
using System.Collections.Generic;

public static class RunAppLinq {
    public static void RunArrayLinq() {
        ArrayLinq.CheckEven();
        Console.WriteLine("------");
        ArrayLinq.GroupNames();
    }

    public static void FilterEmployee() {
        List<Employee> employees = [
            new Employee(1, "Alice", "123 Main St", 12000),
            new Employee(2, "Bob", "456 Elm St", 9500),
            new Employee(3, "Charlie", "789 Oak St", 15000),
            new Employee(4, "David", "101 Maple St", 8000)
        ];

        var highSalaryEmployees = from e in employees
                                  where e.Salary > 10000
                                  select new { e.Name, e.Address };

        Console.WriteLine("Name\t\tAddress");
        foreach (var emp in highSalaryEmployees) {
            Console.WriteLine($"{emp.Name}\t\t{emp.Address}");
        }
    }

    // Using aggregate functions - operations that process a collection of values
    public static void GetStats() {
        List<int> studentMarks = [10, 12, 5, 20, 25, 60, 44];

        int totalMark = studentMarks.Sum();
        int lowestMark = studentMarks.Min();
        int highestMark = studentMarks.Max();
        int markCount = studentMarks.Count();

        Console.WriteLine("Highest mark: " + highestMark);
        Console.WriteLine("Lowest mark: " + lowestMark);
        Console.WriteLine("Sum of all marks: " + totalMark);
        Console.WriteLine("Number of marks: " + markCount);
    }

    public static void JoinLists() {
        List<string> name = ["Ram", "Radha", "Krishna", "Hari"];
        List<string> address = ["Bhaktapur", "Kathmandu", "Bhaktapur", "Lalitpur"];

        var concatResult = name.Concat(address);

        Console.Write("Concat result >> ");
        foreach (string result in concatResult) Console.Write($"{result} ");
        Console.WriteLine();

        var unionResult = name.Union(address);

        Console.Write("Union result >> ");
        foreach (string result in unionResult) Console.Write($"{result} ");
        Console.WriteLine();
    }
}
