using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    internal class Even_Odd
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int j[5], k = 0;
            Console.WriteLine("Enter elemts of an array");
            for(int i=0;i<arr.Length-1;i++) {
                arr[i]=Convert.ToInt32(Console.ReadLine());
            }
            
            //Console.WriteLine("Even ");
            for (int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    arr[j++] = arr[i];
                   
                }
                else
                {
                    k++;
                }
            }
          
                Console.WriteLine("Even"+arr[j]);
           //
                //Console.WriteLine("odd" + arr[k]);

            

          
        }
    }
}
