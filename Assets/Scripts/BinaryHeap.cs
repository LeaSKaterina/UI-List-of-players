using System.Collections.Generic;

public class BinaryHeap
{
    public static void heapSort(List<PersonData> list, int n)
    {
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(list, n, i);
        for (int i = n - 1; i >= 0; i--)
        {
            var temp = list[0];
            list[0] = list[i];
            list[i] = temp;
            heapify(list, i, 0);
        }
    }
    static void heapify(List<PersonData> list, int n, int i)
    {
        int smallest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        if (left < n && list[left] < list[smallest])
            smallest = left;
        if (right < n && list[right] < list[smallest])
            smallest = right;
        if (smallest != i)
        {
            var swap = list[i];
            list[i] = list[smallest];
            list[smallest] = swap;
            heapify(list, n, smallest);
        }
    }
}
