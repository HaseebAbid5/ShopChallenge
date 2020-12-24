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

    public GameObject player, itemListing;

    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        itemArt.sprite = item.art;
        price.text = item.price.ToString();
        equip = item.equip;

        UpdateListing();

    }

    private void Update()
    {

    }

    void UpdateListing()
    {
        for (int i = 0; i < player.GetComponent<Inventory>().items.Count; i++)
        {
            Instantiate(itemListing, new Vector2(i + offset, 0f), Quaternion.identity);
        }
    }


}
