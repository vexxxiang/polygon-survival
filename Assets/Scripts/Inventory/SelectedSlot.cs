using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SelectedSlot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public Sprite selected;
    public Sprite not_selected;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        gameObject.GetComponentInParent<SlotManager>().GetComponent<Image>().sprite = selected;
    }

    public void OnPointerExit(PointerEventData pointerEventData)
    {
        gameObject.GetComponentInParent<SlotManager>().GetComponent<Image>().sprite = not_selected;
       
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
