using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortingAlgorithms;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 58, 16, 18, 33 };
            Console.WriteLine("--------Original Array------");
            printArray(arr);
            Console.WriteLine("--------Bubble Sort------");
            SortingAlgorithms.BubbleSort(arr);
            printArray(arr);
            Console.WriteLine("------Insertion Sort--------");
            assignRandomValuesToArray(arr);
            SortingAlgorithms.InsertionSort(arr);
            printArray(arr);
            Console.WriteLine("------Selection Sort--------");
            assignRandomValuesToArray(arr);
            printArray(arr);
            Console.WriteLine("-------");
            SortingAlgorithms.SelectionSort(arr);
            printArray(arr);
            Console.ReadKey();

        }

        public static void printArray (int[] arr) {
            for (int i=0; i<arr.Length ; i++) {
                Console.WriteLine(arr[i]);
            }
        }


        /*assignRandomValuesToArray(int [] arr):
         * Randomly assigns int values from 0 to 99 to the array so we can properyl check the
         * differents sorts are working as expected.
         * */
        public static void assignRandomValuesToArray(int [] arr) {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(0, 100);
            }
        }        
    }
}
