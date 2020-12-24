using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Inventory_Animation_Controll : MonoBehaviour
{
    //simple script for controller the animator for the UI windows
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    public void Open()
    {
        anim.SetBool("Open", true);
    }

    public void Close()
    {
        anim.SetBool("Open", false);
    }
}
