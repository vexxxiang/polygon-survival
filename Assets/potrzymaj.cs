using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class potrzymaj : MonoBehaviour
{
    public GameObject ClickedObject;
    public bool trzymam;
    public Sprite itemSprite;
    public int itemId;
    public string itemName;
    public string itemType;

    public Sprite itemSprite2;
    public int itemId2;
    public string itemName2;
    public string itemType2;


    public void reset()
    {
    ClickedObject = null;
    trzymam = false;
    itemSprite = null;
    itemId = 0;
    itemName = null;
    itemType = null;

    itemSprite2 = null;
    itemId2 = 0;
    itemName2 = null;
    itemType2 = null;

}


}

