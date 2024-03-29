﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insertion Sort");

            #region InsertionSort
            // Declare an integer array that is not sorted
            int[] arr = { 7, 8, 4, 6, 2, 1 };
            // Output the values of the array to the console
            Console.WriteLine("Array before sort: 7,8,4,6,2,1");
            // Declare variable for the insertion value
            int newValue;
            // The outer loop allows us to iterate over the complete array that we will use for sorting
            for (int i = 1; i < arr.Length; i++)
            {
               // set newValue equal to the second element in the array
               // we don't start at the first element because it has no preceding value
               // which means we can't move it any further forward in the array
               newValue = arr[i];
               // Also set the start of our inner loop to the same value as i
               int j = i;
               // This loop will check the value of j to ensure we have not reached the end of the iteration (j = 0)
               // but also checks to see if the value preceding the current value is larger.
               // If it is, we "swap" the value before this one, decrement j, and then test against the next value
               // This continues until we run out of numbers in the array (j = 0) or there are no more values larger than
               // the current number (newValue) to it's left (preceding it).
               while (j > 0 && arr[j - 1] > newValue)
               {
                   arr[j] = arr[j - 1];
                   j--;
               }
               arr[j] = newValue;
            }
            Console.Write("Array after sort: ");
            foreach (int val in arr)
            {
               Console.Write(val + ",");
            }
            Console.WriteLine();
            // Use Console.ReadLine() in the event application was started with debugging.
            Console.ReadLine();
            #endregion


 #region BubbleSort
   Console.WriteLine("Bubble Sort");

            // declare an array of integers that are not sorted
            int[] nums = { 5, 10, 3, 2, 4 };
            // Output the unsorted array to the console
            Console.WriteLine("Before: 5, 10, 3, 2, 4");
            // Use this to know when to stop the sorting routine
            bool swapped;
            // Here we use a do loop but could have used for or while loops as well.
            do
            {
               // set swapped to false so that we can ensure at least one pass on the array
               swapped = false;
               // This loop will iterate over the array from beginning to end
               for (int i = 0; i < nums.Length - 1; i++)
               {
                   // here we use the i for the position in the array
                   // So i is the first value to compare and i + 1 compares the adjacent value
                   // Once i is incremented at the end of this loop, we compare the next two sets of values, etc.
                   if (nums[i] > nums[i + 1])
                   {
                       // swap routine.  Could be a separate method as well but is used inline for simplicity here
                       // _temp is used to hold the right value in the comparison so we don't lose it.  That value will be replaced in the next step
                       int _temp = nums[i + 1];
                       // Here we replace the right value with the larger value that was on the left.   See why we needed the _temp variable above?
                       nums[i + 1] = nums[i];
                       // Now we assign the value that is in _temp, the smaller value, to the location that was just vacated by the larger number
                       nums[i] = _temp;
                       // Indicate that we did a swap, which means we need to continue to check the remaining values.
                       swapped = true;
                   }
               }
            } while (swapped == true);
            // output the sorted array to the console
            Console.Write("After: ");
            for (int i = 0; i < nums.Length; i++)
            {
               Console.Write("{0}, ", nums[i]);
            }
            // Use Console.ReadLine() in the event application was started with debugging.
            Console.ReadLine();
            #endregion

              #region SelectionSort

            // Declare an integer array that is not sorted
            int[] _arr = { 7, 8, 4, 6, 2, 1 };
            // Output the values of the array to the console
            Console.WriteLine("Array before sort: 7,8,4,6,2,1");
            //minPos will  keep track of where the minimum value is located
            int minPos;
            // temp is used for the swapping of values for the sort
            int temp;
            // outer loop will be responsible for ensuring we have iterated over the entire array
            for (int i = 0; i < _arr.Length - 1; i++)
            {
               //set minPos to the current counter value for traversing the array
               minPos = i;
               Console.WriteLine(minPos);
               // inner loop will perform the comparisons between the min and the other values in the array
               for (int j = i + 1; j < _arr.Length; j++)
               {
                   if (_arr[j] < _arr[minPos])
                   {
                       //minPos will keep track of the index that min is in, this is needed when a swap happens
                       minPos = j;
                                    //   Console.WriteLine(minPos);
                   }
               }
               //if minPos no longer equals i, it indicates a smaller value existed so a swap must take place to sort the values
               if (minPos != i)
               {
                   temp = _arr[i];
                   _arr[i] = _arr[minPos];
                   _arr[minPos] = temp;
                                  Console.WriteLine("SWAP ROUTINE COMMENCE");  
                                  Console.WriteLine(minPos);
                                  Console.WriteLine("SWAP ROUTINE END");
               }
            }
            Console.Write("Array after sort: ");
            foreach (int val in _arr)
            {
               Console.Write(val + ",");
            }
            Console.WriteLine();
            #endregion
        }
    }
}
