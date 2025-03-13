using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // ✅ Only declared once
public class Item
{
    public string itemName; // ✅ Renamed to avoid Unity's `Object.name`
    public int ID;
    public string description;

    public Item(string itemName, int ID, string description)
    {
        this.itemName = itemName;
        this.ID = ID;
        this.description = description;
    }
}