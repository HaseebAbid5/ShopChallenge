using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Basic inventory class to set and get the shirt sprite of the character
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
            SetShirt(defaultItem.art);
        else
            SetShirt(items[0].art);
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
        Naked();
    }
}
