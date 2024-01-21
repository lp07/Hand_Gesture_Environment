# Selection Sort

# It is a simple algorithm.
# Repeatedly selecting a smallest or largest element from the unsorted portion of the list nd moving it to the
# sorted portion of the list.

# TC: O(n^2)
# One loop to select an element of Array one by one = O(N)
# Another loop to compare that element with every other Array element = O(N)

# SC: O(1)
# only extra memory used is for temporary variables while swapping two values in Array

def selection_sort(arr):
    # Traverse through all array element
    for i in range(len(arr)):
        # Assume the current index is the minimum index
        min_idx = i
        # Find the minimum element from the unsorted part of the array
        for j in range(i + 1, (len(arr))):
            # If the smaller is found, update it with the minimum index
            if arr[j] < arr[min_idx]:
                min_idx = j
        # Swap the found minimum element with the first element
        arr[i], arr[min_idx] = arr[min_idx], arr[i]


arr = [74, 35, 22, 32, 21]
selection_sort(arr)
print("Sorted array: ", arr)

