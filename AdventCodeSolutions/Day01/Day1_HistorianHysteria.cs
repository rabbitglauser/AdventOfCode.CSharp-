using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        string filePath = "data.txt"; // File path storing the data pairs

        // Create an instance of DifferenceCalculator
        var calculator = new DifferenceCalculator(filePath);

        // Process the file and get the sum of absolute differences
        int sumOfDifferences = calculator.ComputeDifferenceSum();

        // Print the sum of the differences
        Console.WriteLine(sumOfDifferences);
    }
}

class DifferenceCalculator
{
    private readonly string _filePath;
    private List<int> _list1 = new List<int>();
    private List<int> _list2 = new List<int>();

    public DifferenceCalculator(string filePath)
    {
        _filePath = filePath;
    }

    // Method to read numbers from file and compute sum of absolute differences
    public int ComputeDifferenceSum()
    {
        int sumOfDifferences = 0; // Variable to track sum of differences

        // Read each line of the file
        string[] lines = File.ReadAllLines(_filePath);

        foreach (string line in lines)
        {
            // Split the line into two numbers based on spaces (removing extra spaces)
            string[] parts = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Check if two numbers are present and parse them
            if (parts.Length == 2 &&
                int.TryParse(parts[0].Trim(), out int number1) &&
                int.TryParse(parts[1].Trim(), out int number2))
            {
                _list1.Add(number1); // Add the first number to list1
                _list2.Add(number2); // Add the second number to list2
            }
        }

        // Sort the lists in ascending order
        _list1.Sort();
        _list2.Sort();

        // Add up the absolute differences between corresponding elements
        for (int i = 0; i < _list1.Count; i++)
        {
            sumOfDifferences += Math.Abs(_list1[i] - _list2[i]); // Calculate absolute difference
        }

        // Return the sum of the absolute differences
        return sumOfDifferences;
    }
}