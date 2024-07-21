namespace ExploringTheNet.SessionTwo.AppClass;

using System;

public class Music {
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public string? Artist { get; set; }

    public void ShowInfo() {
        Console.WriteLine("Music Information:");
        Console.WriteLine(
            $"Title: {Title?.Trim()} | Type: {Title?.GetType().Name ?? "Unknown"}\n" +
            $"Genre: {Genre?.Trim()} | Type: {Genre?.GetType().Name ?? "Unknown"}\n" +
            $"Artist: {Artist?.Trim()} | Type: {Artist?.GetType().Name ?? "Unknown"}"
        );
    }
}
