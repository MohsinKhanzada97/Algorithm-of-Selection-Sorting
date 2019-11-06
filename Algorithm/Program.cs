using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
        
        int[] arr = new int[10] { 10, 15, 22, 2, 4, 23, 11, 1, 99, 5 };
        int temp = 0;
        int lesser = 0;
            Console.Write("Input Array:");
            for(int i=0;i<10;i++) {
                Console.Write(arr[i] + " ");
            }
            
            for(int i=0;i<10-1;i++){
                lesser = i;
                for (int j=i+1;j<10;j++){
                    if (arr[j] < arr[lesser])
                    {
                        lesser = j;
                    }
                }
                temp = arr[lesser];
                arr[lesser] = arr[i];
                arr[i]=temp;
            }
            Console.WriteLine();
            Console.Write("Input Array After Sorting:");
            for (int i=0;i<10;i++){
                Console.Write(arr[i] + " ");
            }
                Console.ReadKey();


        }
    }
}
