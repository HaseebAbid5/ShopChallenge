using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//This class parses item information and displays it correctly
public class ItemDIsplay : MonoBehaviour
{
    public Item item;
    public Image itemArt;
    public Text price;

    public GameObject player, itemListing;

    public float offset = 1f;

    // Start is called before the first frame update
    void Start()
    {
        itemArt.sprite = item.art;
        price.text = item.price.ToString();


        UpdateListing();

    }

    private void Update()
    {

    }

    public void UpdateListing()
    {
        for (int i = 0; i < player.GetComponent<Inventory>().items.Count; i++)
        {
            Instantiate(itemListing, new Vector2(i * offset, 0f), Quaternion.identity);
            itemListing.GetComponent<Image>().sprite = player.GetComponent<Inventory>().items[i].art;
            itemListing.GetComponentInChildren<Text>().text = player.GetComponent<Inventory>().items[i].price.ToString();
        }
    }


}
