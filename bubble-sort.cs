		//BUBBLE SORT
//--------------------------------------------
//Pseudo-code
// bubbleSort( nums : list of sortable items )
// n = length(nums)
// loop
//    swapped = false
//    for i = 1 to n-1 // setup number of iterations equal to length of list - 1
//       // is swap needed?
//       if nums[i-1] > nums[i] then // swap them and note it by setting swapped bit
//          swap( nums[i-1], nums[i] )
//          swapped = true
//       end if
//    end for
// until swapped is false or end of list size
// end bubblesort
//--------------------------------------------
using System;
class MainClass {
  public static void Main (string[] args) {



// declare an array of integers that are not sorted
int[] nums = { 5, 10, 3, 2, 4 };

// Output the unsorted array to the console
Console.Write("Before: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write("{0}, ", nums[i]);
}
Console.WriteLine();

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
            // temp is used to hold the right value in the comparison so we don't lose it.  That value will be replaced in the next step
            int temp = nums[i + 1];

            // Here we replace the right value with the larger value that was on the left.   See why we needed the temp variable above?
            nums[i + 1] = nums[i];

            // Now we assign the value that is in temp, the smaller value, to the location that was just vacated by the larger number
            nums[i] = temp;

            // Indicate that we did a swap, which means we need to continue to check the remaining values.
            swapped = true;
        }
				else{

				}
Console.WriteLine();
// Console.WriteLine(swapped);
// Console.WriteLine(i);
Console.WriteLine();

			for (int j = 0; j < nums.Length; j++)
{
    Console.Write("{0}, ", nums[j]);
}	


    }
} while (swapped == true);

// output the sorted array to the console
Console.WriteLine();

Console.Write("After: ");
for (int i = 0; i < nums.Length; i++)
{
    Console.Write("{0}, ", nums[i]);
}

// Use Console.ReadLine() in the event application was started with debugging.
// Console.ReadLine();
  }
}