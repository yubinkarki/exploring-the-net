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
        List<EmployeeModel> employees = [
            new EmployeeModel(1, "Alice", 12000),
            new EmployeeModel(2, "Bob", 9500),
            new EmployeeModel(3, "Charlie", 15000),
            new EmployeeModel(4, "David", 8000)
        ];

        var highSalaryEmployees = from e in employees
                                  where e.Salary > 10000
                                  select new { e.Name, e.Salary };

        Console.WriteLine("Name\t\tSalary");
        foreach (var emp in highSalaryEmployees) {
            Console.WriteLine($"{emp.Name}\t\t{emp.Salary}");
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

    public static void LinqJoin() {
        List<EmployeeModel> employees = [
            new EmployeeModel(1, "Alice", 12000),
            new EmployeeModel(2, "Bob", 9500),
            new EmployeeModel(3, "Charlie", 15000),
            new EmployeeModel(4, "David", 8000)
        ];

        List<AddressModel> employeeAddress = [
            new AddressModel(100, "Bhaktapur", 1, "Changunarayan"),
            new AddressModel(101, "Kathmandu", 2, "Baneshwor"),
            new AddressModel(102, "Lalitpur", 3, "Khumaltar"),
            new AddressModel(103, "Illam", 4, "Kanyam"),
        ];

        var result = from emp in employees
                     join add in employeeAddress on emp.Id equals add.EmployeeId
                     where emp.Salary > 8000
                     select new { emp.Name, emp.Salary, add.City, add.StreetName };

        foreach (var item in result) {
            Console.WriteLine($"{item.Name} earns {item.Salary} and lives in {item.City}, {item.StreetName}.");
        }
    }
}
