using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop_Inventory_Animation_Controll : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
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
