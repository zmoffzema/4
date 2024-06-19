using System;

public class Program
{
    public static void Main()
    {
        int[] numbers = { 1, 3, 7, 2, 9, 5 };
        int maxValue = FindMaxValue(numbers);
        Console.WriteLine("The maximum value in the array is: " + maxValue);
    }

    public static int FindMaxValue(int[] array)
    {
        if (array == null || array.Length == 0)
        {
            throw new ArgumentException("Array cannot be null or empty");
        }

        int maxValue = array[0];
        foreach (int num in array)
        {
            if (num > maxValue)
            {
                maxValue = num;
            }
        }

        return maxValue;
    }
}