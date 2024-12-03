
using System;
using System.Linq;

public class HistorianHysteria
{
    private int[] leftList;
    private int[] rightList;

    public HistorianHysteria(int[] leftList, int[] rightList)
    {
        // Initialize the lists
        this.leftList = (int[])leftList.Clone();
        this.rightList = (int[])rightList.Clone();

        // Sort both lists in non-decreasing order
        Array.Sort(this.leftList);
        Array.Sort(this.rightList);
    }

    public int CalculateTotalDistance()
    {
        int totalDistance = 0;

        // Calculate the sum of absolute differences after sorting
        for (int i = 0; i < leftList.Length; i++)
        {
            totalDistance += Math.Abs(leftList[i] - rightList[i]);
        }

        return totalDistance;
    }
    
    public static void Main()
    {
        // Example input
        int[] leftList = { 1, 2, 3, 3, 3, 4 };
        int[] rightList = { 3, 3, 3, 4, 5, 9 };

        // Create instance of HistorianHysteria
        var historianHysteria = new HistorianHysteria(leftList, rightList);

        // Calculate the total distance
        int totalDistance = historianHysteria.CalculateTotalDistance();

        // Output the result
        Console.WriteLine($"Total distance: {totalDistance}");
    }
}