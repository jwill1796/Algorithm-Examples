def insertionSort2(n, arr):
    # Need to check through the array and print it at each iteration
    print(arr)
    
    for i in range(1, n): # i is the index of the element to be inserted
        key = arr[i] # key is the element to be inserted
        j = i - 1 # j is left of i
        while j >= 0 and arr[j] > key: # while j is in bounds and the element to the left is greater than the key
            arr[j + 1] = arr[j] # shift the element to the right
            j -= 1 # decrement j

        arr[j + 1] = key # insert the key in the correct position
        print (f"Iteration {i}: ", arr) # print the array after each iteration
arr = [12 ,11, 13, 5, 6] # Example array
insertionSort2(5, arr) # Sort the array
print("Sorted array:", arr) # Print the sorted array
