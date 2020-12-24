using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


//Functions for just the button listeners in the UI
public class OnClickFunctions : MonoBehaviour
{
    public DialogueManager dm;
    public GameObject player;
    public int amount;


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

}
