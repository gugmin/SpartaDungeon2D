using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ItemType
{
    None,
    Weapon,
    Armor
}

[CreateAssetMenu(fileName = "Item", menuName = "Items/Default", order = 0)]
public class Items : ScriptableObject
{
    public ItemType type = 0;
    public Sprite itemImage;
    public string Name;
    public string info;
    public int itemManpower;
    public int itemImprovisation;
    public int itemHealth;
    public int itemSpeech;
    public string statName;
    public Sprite itemStatImage;
    public bool IsEquip = false;
}
