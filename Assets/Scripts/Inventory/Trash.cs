using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Trash: MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public GameObject Trzymator;
    public Sprite trash;
    public Sprite not_selected;
    public void OnPointerEnter(PointerEventData pointerEventData)
    { 
        gameObject.GetComponentInParent<nic>().GetComponent<Image>().sprite = trash;

    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        gameObject.GetComponentInParent<nic>().GetComponent<Image>().sprite = not_selected;


    }
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        if (gameObject == this.gameObject)
        {
            Debug.Log("click");

            if (Trzymator.GetComponent<potrzymaj>().trzymam == true)
            {
                print("jestem w  ufff");
                Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
                Trzymator.GetComponent<potrzymaj>().reset();
            }
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
