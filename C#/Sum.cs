namespace Sum;

public class SUMOFNUMBERS
{
    public static int ArraySum(List<int> s)
    {
        int sum = 0;
        foreach (int i in s)
        {
            sum += i;
        }
        return sum;
    }
}