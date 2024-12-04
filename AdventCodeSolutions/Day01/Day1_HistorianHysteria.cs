using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.txt"; // File path storing the data pairs

        // Process the file and get the sum of absolute differences
        int sumOfDifferences = ReadAndComputeDifferenceSum(filePath);

        // Print the sum of the differences
        Console.WriteLine(sumOfDifferences);
    }

    // Method to read numbers from file and compute sum of absolute differences
    static int ReadAndComputeDifferenceSum(string filePath)
    {
        List<int> list1 = new List<int>(); // List to store first numbers
        List<int> list2 = new List<int>(); // List to store second numbers
        int sumOfDifferences = 0; // Variable to track sum of differences

        // Read each line of the file
        string[] lines = File.ReadAllLines(filePath);

        foreach (string line in lines)
        {
            // Split the line into two numbers based on spaces (removing extra spaces)
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if two numbers are present and parse them
            if (parts.Length == 2 &&
                int.TryParse(parts[0].Trim(), out int number1) &&
                int.TryParse(parts[1].Trim(), out int number2))
            {
                list1.Add(number1); // Add the first number to list1
                list2.Add(number2); // Add the second number to list2
            }
        }

        // Sort the lists in ascending order
        list1.Sort();
        list2.Sort();

        // Add up the absolute differences between corresponding elements
        for (int i = 0; i < list1.Count; i++)
        {
            sumOfDifferences += Math.Abs(list1[i] - list2[i]); // Calculate absolute difference
        }

        // Return the sum of the absolute differences
        return sumOfDifferences;
    }
}