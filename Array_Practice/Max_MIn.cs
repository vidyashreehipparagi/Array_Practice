using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    internal class Max_MIn
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter number");
           // int n=Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<arr.Length; i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            int max = arr[0];
            int min= arr[0];
            for(int i=0;i<arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                else if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine($"Maximum Value is {max}");
            Console.WriteLine($"Minimum value is {min}");
        }
    }
}
