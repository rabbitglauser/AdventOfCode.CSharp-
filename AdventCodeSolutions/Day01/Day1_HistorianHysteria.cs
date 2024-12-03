
using System;
using System.Linq;

public class HistorianHysteria
{
    public static int CalculateTotalDistance(int[] leftList, int[] rightList)
    {
        // Sort both lists in non-decreasing order
        Array.Sort(leftList);
        Array.Sort(rightList);

        int totalDistance = 0;
        
        // Calculate the sum of absolute differences
        for (int i = 0; i < leftList.Length; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }

        return totalDistance;
    }
    
    public static void Main()
    {
        // Example input
        int[] leftList = { 3, 4, 2, 1, 3, 3 };
        int[] rightList = { 4, 3, 5, 3, 9, 3 };

        // Calculate the total distance
        int totalDistance = CalculateTotalDistance(leftList, rightList);

        // Output the result
        Console.WriteLine($"Total distance: {totalDistance}");
    }
}