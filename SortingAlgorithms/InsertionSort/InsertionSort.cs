namespace InsertionSort;

public class InsertionSort
{
    public void Sort(int[] items)
    {
        int sortedRangeEnd = 1;
        while (sortedRangeEnd < items.Length)
        {
            if (items[sortedRangeEnd] < items[sortedRangeEnd - 1])
            {
                var insertIndex = FindInsertionIndex(items, items[sortedRangeEnd]);
                InsertByIndex(items, sortedRangeEnd, insertIndex);
            }

            sortedRangeEnd++;
        }
    }

    private int FindInsertionIndex(int[] items, int valueToInsert)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] > valueToInsert)
            {
                return i;
            }
        }

        throw new InvalidOperationException();
    }

    private void InsertByIndex(int[] items, int indexFrom, int indexTo)
    {
        var temp = items[indexTo];

        items[indexTo] = items[indexFrom];
        for (int i = indexFrom; i > indexTo; i--)
        {
            items[i] = items[i - 1];
        }

        items[indexTo + 1] = temp;
    }
}
