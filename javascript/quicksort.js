const quickSort = (array) => {
    if (array.length <= 1) {
        return array;
    }

    const middleIndex = Math.floor(array.length / 2);
    const pivot = array[middleIndex];

    const less = [];
    const greater = [];

    for (let index = 0; index < array.length; index++) {
        const element = array[index];
        if (index === middleIndex) {
            continue;
        }
        if (element < pivot) {
            less.push(element);
        } else {
            greater.push(element);
        }
    }

    return [...quickSort(less), pivot, ...quickSort(greater)];
}

const unsortedArray = [3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5];
const sortedArray = quickSort(unsortedArray);
console.log(sortedArray);