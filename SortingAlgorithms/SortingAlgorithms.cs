using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class SortingAlgorithms
    {
        /*
         * BubbleSort Algorithm: it's the simplest sorting algorithm.
         * Repeatedly steps through the list, compares two adjancets
         * elements and swaps them if they are in the wrong order.
         * */
        public static void BubbleSort(int [] arr) {

            bool swapped;
            for (int i=0; i<arr.Length; i++) {
                swapped = false;
                for (int j=0; j<arr.Length-i-1; j++) {
                    if (arr[j]>arr[j+1]) {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
        }
        /*
         * Insertion Sort Algorithm: sorts a list of elements by 
         * taking each element and inserting in the corresponding
         * position to the left.
         * */
        public static void InsertionSort(int [] arr) {
            int j;
            for (int i=1; i<arr.Length; i++) {
                j = i;
                while (j>0 && arr[j-1] > arr[j]) {
                    int temp = arr[j];
                    arr[j] = arr[j - 1];
                    arr[j - 1] = temp;
                    j = j - 1;
                }
            }
        }

        /*
         *Selection Sort: sorts a list of elements by taking the smallest element and
         *swapping it with the element to the left.
         * */
        public static void SelectionSort(int [] arr) {
            for (int k=0; k<arr.Length-1; k++) {
                int minimumIndex = k;
                for (int j = k+1; j<arr.Length; j++) {
                    if (arr[j] < arr[minimumIndex])
                        minimumIndex = j;
                }
                    int temp = arr[minimumIndex];
                    arr[minimumIndex] = arr[k];
                    arr[k] = temp;
            }
        }
    } //end SortingAlgorithms
} //end namespace
