
namespace SelectionSort;

public class SelectionSort
{
    public void Sort(ref int[] items)
    {
        int sortedRange = 0;
        while (sortedRange < items.Length)
        {
            var index = SmallestIndexFromRest(items, sortedRange);
            (items[sortedRange], items[index]) = (items[index], items[sortedRange]);
            sortedRange++;
        }
    }

    private int SmallestIndexFromRest(int[] items, int sortedRange)
    {
        int current = items[sortedRange];
        int currentIndex = sortedRange;

        for (int i = currentIndex + 1; i < items.Length; i++)
        {
            if (items[i] < current)
            {
                current = items[i];
                currentIndex = i;
            }
        }

        return currentIndex;
    }
}
