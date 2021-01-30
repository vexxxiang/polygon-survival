using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotManager : MonoBehaviour
{

    public bool Zajety ;

    public string ItemName = "none";
    public int ItemId = 0;
    public Sprite ItemSprite;
    public string ItemType;


    public void AddItem(GameObject Item)
    {
        ItemId = Item.GetComponent<BlockInfo>().Id;
        ItemName = Item.GetComponent<BlockInfo>().Nazwa;
        ItemSprite = Item.GetComponent<BlockInfo>().Ikona;
        ItemType = Item.GetComponent<BlockInfo>().typItemu.ToString();

        this.transform.GetChild(0).GetComponentInChildren<Image>().sprite = ItemSprite;

        Zajety = true;



    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


