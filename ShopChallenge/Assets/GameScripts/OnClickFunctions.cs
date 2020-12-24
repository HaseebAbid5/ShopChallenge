using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnClickFunctions : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject player;
    public int amount;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseDialogueBox()
    {
        dm.EndDialogue();
    }

    public void Buy(Text amount)
    {
        player.GetComponent<Wallet>().Buy(int.Parse(amount.text));
    }

    public void Sell(Text amount)
    {
        player.GetComponent<Wallet>().Sell(int.Parse(amount.text));
    }

    public void Equip(Item item)
    {
        player.GetComponent<PlayerActions>().Equip(item);
    }


}
