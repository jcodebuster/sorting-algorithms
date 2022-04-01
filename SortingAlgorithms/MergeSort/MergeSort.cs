namespace MergeSort;

public class MergeSort
{
    public void Sort(int[] items)
    {
        if (items.Length <= 1)
        {
            return;
        }

        var leftLength = items.Length / 2;
        var rightLength = items.Length - leftLength;
        var leftArr = new int[leftLength];
        var rightArr = new int[rightLength];
        Array.Copy(items, 0, leftArr, 0, leftLength);
        Array.Copy(items, leftLength, rightArr, 0, rightLength);

        Sort(leftArr);
        Sort(rightArr);

        Merge(items, leftArr, rightArr);
    }

    private void Merge(int[] items, int[] left, int[] right)
    {
        int leftIndex = 0;
        int rightIndex = 0;
        int targetIndex = 0;
        int remaining = left.Length + right.Length;

        while (remaining > 0)
        {
            if (leftIndex >= left.Length)
            {
                items[targetIndex] = right[rightIndex++];
            }
            else if (rightIndex >= right.Length)
            {
                items[targetIndex] = left[leftIndex++];
            }
            else if (left[leftIndex] < right[rightIndex])
            {
                items[targetIndex] = left[leftIndex++];
            }
            else if(right[rightIndex] < left[leftIndex])
            {
                items[targetIndex] = right[rightIndex++];
            }

            targetIndex++;
            remaining--;
        }
    }
}
