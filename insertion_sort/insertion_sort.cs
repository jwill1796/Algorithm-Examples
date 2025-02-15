public static void InsertionSort(int[] arr)
{
    for (int i = 1; i < arr.Length; i++)
    {
        int key = arr[i]; // The element to be inserted in the sorted part of the array
        int j = i - 1; // Index of the last element in the sorted part of the array

        while (j >=0 && arr[j]> key)
        {
            arr[j + 1] = arr[j]; // Shift the element to the right
            j--;
        }
        arr[j + 1] = key; // Insert the key in its correct position

        Console.WriteLine(string.Join(" ", arr));
    }
}

public static void Main(string[] args)
{
    int[] arr = { 5, 2, 9, 1, 5, 6 };
    InsertionSort(arr);
    Console.WriteLine(string.Join(", ", arr));
}
