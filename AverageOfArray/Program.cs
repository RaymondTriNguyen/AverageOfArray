using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 6, 9, 12, 20, 25 };

            int sum = 0;
            
        
           for (int i = 0; i < arr.Length; i++) //i<=5
            {
                sum += arr[i]; // sum=sum+arr[i]
            }
           
            double average = (double)sum / arr.Length;
            Console.WriteLine("The average is "+average+".");
            Console.ReadKey();
        }

    }
}
