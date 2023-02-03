using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class ListOfPersonsData
{
    public List<PersonData> Items;

    public void SortByPoints()
    {
        BinaryHeap.heapSort(Items, Items.Count);
    }
}
