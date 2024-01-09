def quick_sort(array):
    if len(array) <= 1:
        return array

    middleIndex = len(array) // 2
    pivot = array[middleIndex]

    less = []
    greater = []

    for i in range(len(array)):
        element = array[i]
        if i == middleIndex:
            continue
        if element < pivot:
            less.append(array[i])
        else:
            greater.append(array[i])

    return quick_sort(less) + [pivot] + quick_sort(greater)


unsortedArray = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5]
sortedArray = quick_sort(unsortedArray)
print(sortedArray)
