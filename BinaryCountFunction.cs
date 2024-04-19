namespace BinaryCountFunction;

public static class BinaryCount
{
    public static int CountBits(int number)
    {
        int count = 0;

        while (number > 0)
        {
            count += number & 1;
            number >>= 1;
        }

        return count;
    }
}
