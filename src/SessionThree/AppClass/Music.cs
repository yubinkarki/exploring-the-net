namespace ExploringTheNet.src.SessionThree.AppClass {
    using System;

    public class Music {
        // Member properties with get and set accessors
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Artist { get; set; }

        // Default constructor
        public Music() { }

        // Method to get the album information
        public void ShowInfo() {
            Console.WriteLine("Music Information:");
            Console.WriteLine(
                $"Title: {Title?.Trim() ?? "N/A"} | Type: {Title?.GetType().Name ?? "Unknown"}\n" +
                $"Genre: {Genre?.Trim() ?? "N/A"} | Type: {Genre?.GetType().Name ?? "Unknown"}\n" +
                $"Artist: {Artist?.Trim() ?? "N/A"} | Type: {Artist?.GetType().Name ?? "Unknown"}"
            );
        }
    }

    namespace InnerSpace {
        public class Movie { }

        public class School { }
    }
}
