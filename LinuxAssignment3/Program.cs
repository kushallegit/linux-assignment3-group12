using System;
using System.Text.Json;


namespace LinuxAssignment3
{
    internal class Program
    {
        static void Main(string[]args)
        {
            try
            {
                string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "linux-commands.json");
                Console.WriteLine($"DEBUG: Looking for JSON at: {filePath}");


                 if (!File.Exists(filePath))
                {
                    Console.WriteLine($"Error: File not found at {filePath}");
                    // Error: File not found at /workspaces/linux-assignment3-group12/LinuxAssignment3/bin/Debug/net8.0/linux-comm.json
                    // if the file is not found => stop/terminate our Main() method => the Entry point of our application
                    return; // Terminate the application
                }

                //  Step03: Reading the file using the static method "ReadAllText" of the class "File":
                // ------------------------------------------------------------------------------------
                string jsonString = File.ReadAllText(filePath);

                // for testing:
                Console.WriteLine(jsonString); // give us the full content as text file

                List<LinuxCommands> allCommands = JsonSerializer.Deserialize<List<LinuxCommands>>(jsonString);


                if (allCommands == null || allCommands.Count == 0)
                {
                    Console.WriteLine("No commands found in the JSON file.");
                }
                else
                {
                    // Step06: Iterate and display commands:
                    // -------------------------------------
                    // Using collections, foreach loop, and object method usage
                    // Display all commands
                    foreach (LinuxCommands cmd in allCommands)
                    {
                        cmd.PrintCommand(); // Call our public method "ShowInfo()" from "LinuxCommand" class
                    }
                }
                
            }
            catch (FileNotFoundException ex)
            {
                // Handle file not found
                Console.WriteLine($"Error: {ex.Message}");
            }

             catch (JsonException ex)
            {
                // Handle invalid JSON format
                Console.WriteLine($"Error in parsing the JSON File: {ex.Message}");
            }
            catch (Exception ex)
            {
                // Handle unexpected errors
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

        } // Main
    } // Class
} // Namespace