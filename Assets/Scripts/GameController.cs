using PolyAndCode.UI;
using System.IO;
using UnityEngine;

public class GameController : MonoBehaviour, IRecyclableScrollRectDataSource
{
    [SerializeField]
    RecyclableScrollRect _recyclableScrollRect;
    public string jsonFilePath;
    private ListOfPersonsData ListOfPersonsData;

    private void Awake()
    {
        var jsonData = File.ReadAllText(jsonFilePath);
        jsonData = "{\"Items\":" + jsonData + "}";
        ListOfPersonsData = JsonUtility.FromJson<ListOfPersonsData>(jsonData);
        ListOfPersonsData.SortByPoints();
        _recyclableScrollRect.DataSource = this;
    }
    public int GetItemCount()
    {
        return ListOfPersonsData.Items.Count;
    }

    public void SetCell(ICell cell, int index)
    {
        var item = cell as Item;
        item.ConfigureItem(ListOfPersonsData.Items[index]);
    }
}