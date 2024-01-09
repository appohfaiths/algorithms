namespace SortingAlgorithms;

public class Quick_Sort
{
    public static List<int> QuickSort(List<int> array)
    {
        if (array.Count <= 1)
        {
            return array;
        }

        int middleIndex = (int)Math.Floor((double)array.Count / 2);
        int pivot = array[middleIndex];

        var less = new List<int> { };
        var greater = new List<int> { };

        for (int i = 0; i < array.Count; i++)
        {
            int element = array[i];
            if (i == middleIndex)
                continue;
            if (element < middleIndex)
                less.Add(element);
            else
                greater.Add(element);
        }
        return QuickSort(less).Concat(new List<int> { pivot }).Concat(QuickSort(greater)).ToList();

    }
}