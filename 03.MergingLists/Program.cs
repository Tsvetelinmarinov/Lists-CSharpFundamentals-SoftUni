/**
 * 03.MergingLists
 */

namespace _03.MergingLists;

class Program
{
    static void Main()
    {
        List<int> firstStream = (Console.ReadLine() ?? "6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> secondStream = (Console.ReadLine() ?? "6 6 6")
            .Split()
            .Select(int.Parse)
            .ToList();

        List<int> combinedList = new(firstStream.Count + secondStream.Count);
        int maxCount = Math.Max(firstStream.Count, secondStream.Count);
        for (int i = 0; i < maxCount; ++i)
        {
            if (firstStream.Count > i)
            {
                combinedList.Add(firstStream[i]);
            }

            if (secondStream.Count > i)
            {
                combinedList.Add(secondStream[i]);
            }
        }

        Console.WriteLine(String.Join(" ", combinedList));
    }
}