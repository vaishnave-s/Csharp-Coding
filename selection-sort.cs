// Selection Sort 
using System; 

class SelectionSort 
{ 
	static void sort(int []arr) 
	{ 
		int n = arr.Length; 

		// One by one move boundary of unsorted subarray 
		for (int i = 0; i < n - 1; i++) 
		{ 
			// Find the minimum element in unsorted array 
			int min_idx = i; 
			for (int j = i + 1; j < n; j++) 
				if (arr[j] < arr[min_idx]) 
					min_idx = j; 

			// Swap the found minimum element with the first 
			// element 
			int temp = arr[min_idx]; 
			arr[min_idx] = arr[i]; 
			arr[i] = temp; 
		} 
	} 


	// Driver code 
	public static void Main() 
	{ 
		int []arr = {64,25,12,22,11}; 
		foreach(var x in arr){
			Console.Write(x+" "); 

		}
		Console.WriteLine(); 

		sort(arr); 
		Console.WriteLine("Sorted array"); 
		for (int i=0; i<arr.Length; ++i) 
			Console.Write(arr[i]+" "); 
		Console.WriteLine(); 
	} 

} 
