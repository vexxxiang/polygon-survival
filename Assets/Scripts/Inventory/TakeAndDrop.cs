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
            Debug.Log("if 1");

            Trzymator.GetComponent<potrzymaj>().itemSprite2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite;
            Trzymator.GetComponent<potrzymaj>().itemId2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId;
            Trzymator.GetComponent<potrzymaj>().itemName2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName;
            Trzymator.GetComponent<potrzymaj>().itemType2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType;

            Trzymator.GetComponent<potrzymaj>().itemSprite = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite;
            Trzymator.GetComponent<potrzymaj>().itemId = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId;
            Trzymator.GetComponent<potrzymaj>().itemName = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName;
            Trzymator.GetComponent<potrzymaj>().itemType = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType;

            gameObject.GetComponentInParent<Image>().sprite = NotSelect;

            gameObject.GetComponentInParent<SlotManager>().ItemSprite = null;
            gameObject.GetComponentInParent<SlotManager>().ItemId = 0;
            gameObject.GetComponentInParent<SlotManager>().ItemName = null;
            gameObject.GetComponentInParent<SlotManager>().ItemType = null;
            Cursor.SetCursor(Trzymator.GetComponent<potrzymaj>().itemSprite2.texture, Vector2.zero, CursorMode.Auto);
            gameObject.GetComponentInParent<SlotManager>().Zajety = false;

            zajety = false;
            Trzymator.GetComponent<potrzymaj>().trzymam = true;
            Trzymator.GetComponent<potrzymaj>().ClickedObject = gameObject;
            
            return;



        }
        else if (zajety == false && trzymam == true)
        {
            Debug.Log("if 2");

            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

            gameObject.GetComponent<Image>().sprite = Trzymator.GetComponent<potrzymaj>().itemSprite2; ;

            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite = Trzymator.GetComponent<potrzymaj>().itemSprite2;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId = Trzymator.GetComponent<potrzymaj>().itemId2;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName = Trzymator.GetComponent<potrzymaj>().itemName2;
            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType = Trzymator.GetComponent<potrzymaj>().itemType2;






            gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().Zajety = true;
            zajety = true;
            Trzymator.GetComponent<potrzymaj>().trzymam = false;
        }
   
        else if (zajety == true && trzymam == true)
        {
            if (gameObject != Trzymator.GetComponent<potrzymaj>().ClickedObject)
            {

                Debug.Log("if 3");

                Cursor.SetCursor(gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite.texture, Vector2.zero, CursorMode.Auto);

                gameObject.GetComponent<Image>().sprite = Trzymator.GetComponent<potrzymaj>().itemSprite2;

                Trzymator.GetComponent<potrzymaj>().itemSprite2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite;
                Trzymator.GetComponent<potrzymaj>().itemId2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId;
                Trzymator.GetComponent<potrzymaj>().itemName2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName;
                Trzymator.GetComponent<potrzymaj>().itemType2 = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType;

                gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemSprite = Trzymator.GetComponent<potrzymaj>().itemSprite;
                gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemId = Trzymator.GetComponent<potrzymaj>().itemId;
                gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemName = Trzymator.GetComponent<potrzymaj>().itemName;
                gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().ItemType = Trzymator.GetComponent<potrzymaj>().itemType;
                Trzymator.GetComponent<potrzymaj>().ClickedObject = gameObject;
            }
            

            

            


            

            
     
            


            zajety = gameObject.GetComponentInParent<SlotManager>().GetComponent<SlotManager>().Zajety = true;
            
            Trzymator.GetComponent<potrzymaj>().trzymam = true;
        }
  

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
