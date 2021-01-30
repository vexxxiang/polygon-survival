using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TakeAndDrop : MonoBehaviour, IPointerClickHandler
{

    public Sprite itemSprite;
    public int itemId;
    public string itemName;
    public string itemType;
    public Sprite kursor;

    public GameObject Trzymator;

    public bool zajety ;
    public bool trzymam;

    public Sprite NotSelect;

    public void OnPointerClick(PointerEventData pointerEventData)
    {

        zajety = gameObject.GetComponentInParent<SlotManager>().Zajety;
        trzymam = Trzymator.GetComponent<potrzymaj>().trzymam;

        if (zajety == true && trzymam == false)
        {
            

            Trzymator.GetComponent<potrzymaj>().itemSprite = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite;
            Trzymator.GetComponent<potrzymaj>().itemId = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId;
            Trzymator.GetComponent<potrzymaj>().itemName = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName;
            Trzymator.GetComponent<potrzymaj>().itemType = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType;

            gameObject.GetComponentInParent<Image>().sprite = NotSelect;

            gameObject.GetComponentInParent<SlotManager>().ItemSprite = null;
            gameObject.GetComponentInParent<SlotManager>().ItemId = 0;
            gameObject.GetComponentInParent<SlotManager>().ItemName = null;
            gameObject.GetComponentInParent<SlotManager>().ItemType = null;
            Cursor.SetCursor(Trzymator.GetComponent<potrzymaj>().itemSprite.texture, Vector2.zero, CursorMode.Auto);
            gameObject.GetComponentInParent<SlotManager>().Zajety = false;

            zajety = false;
            Trzymator.GetComponent<potrzymaj>().trzymam = true;
            
            return;



        }
        if (zajety == false && trzymam == true)
        {



            gameObject.GetComponent<Image>().sprite = Trzymator.GetComponent<potrzymaj>().itemSprite; ;

            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite = Trzymator.GetComponent<potrzymaj>().itemSprite;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId = Trzymator.GetComponent<potrzymaj>().itemId;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName = Trzymator.GetComponent<potrzymaj>().itemName;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType = Trzymator.GetComponent<potrzymaj>().itemType;

            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);


            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().Zajety = true;
            zajety = true;
            Trzymator.GetComponent<potrzymaj>().trzymam = false;
        }
        /*
        if (zajety == true && trzymam == true)
        {
            Debug.Log("klikam na " + gameObject);


            Trzymator.GetComponent<potrzymaj>().itemSprite2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite;
            Trzymator.GetComponent<potrzymaj>().itemId2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId;
            Trzymator.GetComponent<potrzymaj>().itemName2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName;
            Trzymator.GetComponent<potrzymaj>().itemType2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType;


            gameObject.GetComponent<Image>().sprite = Trzymator.GetComponent<potrzymaj>().itemSprite; ;

            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite = Trzymator.GetComponent<potrzymaj>().itemSprite;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId = Trzymator.GetComponent<potrzymaj>().itemId;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName = Trzymator.GetComponent<potrzymaj>().itemName;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType = Trzymator.GetComponent<potrzymaj>().itemType;
     
            Cursor.SetCursor(Trzymator.GetComponent<potrzymaj>().itemSprite2.texture, Vector2.zero, CursorMode.Auto);


            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().Zajety = true;
            zajety = true;
            Trzymator.GetComponent<potrzymaj>().trzymam = false;
        }
        */

    }




    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        Trzymator = GameObject.FindGameObjectWithTag("Trzymator");
    }
}
