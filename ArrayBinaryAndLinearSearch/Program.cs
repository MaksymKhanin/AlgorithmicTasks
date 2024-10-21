using System;
using System.Threading.Tasks;

namespace ArrayBinaryAndLinearSearch;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var res = false;

        if (numbers.Length >= 10) res = PerformBinarySearch(numbers, 6).GetAwaiter().GetResult();

        else res = PerformLinearSearch(numbers, 6).GetAwaiter().GetResult();


        Console.WriteLine(res);

    }

    //CPU bound operation
    private static Task<bool> PerformBinarySearch(int[] numbers, int searchable)
    {
        return Task.Run(() =>
        {

            int index = Array.BinarySearch(numbers, searchable);

            return index >= 0 ? true : false;

        });

    }

    //CPU bound operation
    private static Task<bool> PerformLinearSearch(int[] numbers, int searchable)
    {
        return Task.Run(() =>
        {

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchable)
                    return true;
            }

            return false;

        });

    }
}
