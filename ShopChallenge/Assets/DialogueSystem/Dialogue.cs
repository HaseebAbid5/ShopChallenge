using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class is used to set up each dialogue box
//Each box will have a name, display picture, and dialogue scentences

[System.Serializable]
public class Dialogue{

    public string[] names;

    public Sprite[] displayImage;

    [TextArea(3,10)]
    public string[] scentences;
}
