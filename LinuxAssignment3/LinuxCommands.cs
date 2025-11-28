using System;

namespace LinuxAssignment3;

    /*
        "LinuxCommand" => Blueprint class for a Linux command.
        Demonstrates Object-Oriented Programming (OOP) concepts:
        - Encapsulation: properties are exposed with getters/setters
        - Constructor: initializes object state
        - Methods: define object behavior
    */
public class LinuxCommands
{
    // ---------------- Properties ----------------
        public string Name { get; set; } = ""; // It prevents null errors by giving the property a safe default value
        public string Description { get; set; } ="";
        public string Category { get; set; } ="";
        public string Example { get; set; } ="";
        public string Difficulty { get; set; } ="";
        public string Notes { get; set; } ="";

        // ---------------- Constructors ----------------

        // Default constructor (needed for JSON)
        public LinuxCommands() { }

        // Parameterized constructor (optional)
        public LinuxCommands(string name, string description, string category,
                            string example, string difficulty, string notes)
        {
            Name = name;
            Description = description;
            Category = category;
            Example = example;
            Difficulty = difficulty;
            Notes = notes;
        }

        // ---------------- Methods ----------------

        public void PrintCommand()
        {
            Console.WriteLine($"Command: {Name}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Example: {Example}");
            Console.WriteLine($"Difficulty: {Difficulty}");
            Console.WriteLine($"Notes: {Notes}");
            Console.WriteLine("---------------------------------------------");
        }
} // class
