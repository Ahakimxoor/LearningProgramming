using System;
public class Program
{
    public static void Main(string[] args)
    {
        int[] arrayData = { 10, 3, 33, 45, 88, 99, 22, 11, 66, 44, 23 };

        int n = arrayData.Length; 
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arrayData[j] < arrayData[minIndex])
                {
                    minIndex = j; 
                }
            }

            int tempData = arrayData[minIndex];
            arrayData[minIndex] = arrayData[i];
            arrayData[i] = tempData;
        }

        foreach (int i in arrayData)
        {
            Console.Write(i + " " );
        }
    }
}
