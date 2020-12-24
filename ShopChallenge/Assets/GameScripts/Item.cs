using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An Item scriptable object, used to make many different items
[CreateAssetMenu]
public class Item: ScriptableObject
{
    public Sprite art;
    public int price;
    public bool equip;


}
