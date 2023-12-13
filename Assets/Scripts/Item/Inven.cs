using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Inven : MonoBehaviour
{
    public List<Items> items = new List<Items>();

    public void AddItem(Items Item)
    {
        items.Add(Item);
    }
    public void RemoveItem(Items item)
    {
        items.Remove(item);
    }
}
