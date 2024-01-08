namespace BinarySearch;

public class Binary_Search
{
    public static int BinarySearch(List<int> array, int target)
    {
        int left = 0;
        int right = array.Count - 1;

        while (left <= right)
        {
            int mid = (int)Math.Floor((double)(left + right) / 2);

            if (array[mid] == target)
            {
                return mid;
            }
            else if (array[mid] < target)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        return -1;
    }
}