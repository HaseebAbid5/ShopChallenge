using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventory : MonoBehaviour
{
    public List<Item> items;
    public Item defaultItem;

    Sprite shirt;

    private void Start()
    {
        SetShirt(items[0].art);
    }

    void Naked()
    {
        if (items.Count == 0)
        {
            SetShirt(defaultItem.art);
        }
    }

    public void SetShirt(Sprite shirt)
    {
        this.shirt = shirt;
    }

    public Sprite GetCurrentShirt()
    {
        return shirt;
    }

    public void AddShirt(Item shirt)
    {
        items.Add(shirt);
    }

    public void RemoveShirt(Item shirt)
    {
        items.Remove(shirt);
    }
}
