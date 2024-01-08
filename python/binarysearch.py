def binary_search(array, target):
    left = 0
    right = len(array) - 1

    while left <= right:
        mid = int((left + right) / 2)
        if array[mid] == target:
            return mid
        elif array[mid] < target:
            left = mid + 1
        else:
            right = mid - 1
    return -1


sortedArray = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
targetValue = 7

result = binary_search(sortedArray, targetValue)

if result != -1:
    print(f'Target {targetValue} found at index {result}')
else:
    print(f'Target {targetValue} not found in array')
