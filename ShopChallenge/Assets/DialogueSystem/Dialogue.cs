using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is used to set up each dialogue box

[System.Serializable]
public class Dialogue{

    public string[] names;

    public Sprite[] displayImage;

    [TextArea(3,10)]
    public string[] scentences;
}
