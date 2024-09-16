using System;
public class Program 
{
    public static void Main(string[] args)
    {
        int[] num = {43, 34, 12, 65, 6, 78};
        int n = num.Length - 1;

        for(int i = 0; i < n; i++)
        {
            for(int j = 0; j < n - i; j++)
            {
                if(num[j] > num[j + 1])
                {
                    int tmp = num[j + 1];
                    num[j + 1] = num[j];
                    num[j] = tmp;
                }
               
            }
        }

        for (int i = 0; i < num.Length; i++)
        {
              Console.Write(num[i] + " ");
        }

    }
}