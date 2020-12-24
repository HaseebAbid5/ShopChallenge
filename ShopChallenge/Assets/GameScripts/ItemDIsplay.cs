using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemDIsplay : MonoBehaviour
{
    public Item item;

    public Image itemArt;
    public Text price;
    public bool equip;

    // Start is called before the first frame update
    void Start()
    {
        itemArt.sprite = item.art;
        price.text = item.price.ToString();
        equip = item.equip;
    }


}
