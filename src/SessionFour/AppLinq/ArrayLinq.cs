// LINQ is a uniform query syntax to retrieve data from different sources

namespace ExploringTheNet.SessionFour.AppLinq;

using System;
using System.Linq;

// Object collection, ADO.Net database, XML document, SQL database and others
public class ArrayLinq {
    private static int[] numberList = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

    private static string[] names =
        ["Alice", "Bob", "Charlie", "David", "Eve", "Frank", "Grace", "George", "Evan", "Everest"];

    public static void CheckEven() {
        // from 'variable' in 'data_source' where 'condition' orderby 'variable' 'ascending' select 'variable';
        var evenNumbers = from num in numberList
                          where num % 2 == 0
                          orderby num descending
                          select num;

        foreach (int num in evenNumbers) Console.Write($"{num} ");
        Console.WriteLine();
    }

    public static void GroupNames() {
        var groupedNames = from name in names
                           group name by name[0] into nameGroup
                           orderby nameGroup.Key ascending
                           select nameGroup;

        foreach (var group in groupedNames) {
            Console.WriteLine($"Names starting with '{group.Key}':");
            foreach (string name in group) Console.WriteLine($" >> {name}");
        }
    }
}
