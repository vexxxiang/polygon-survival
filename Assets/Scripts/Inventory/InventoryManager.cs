using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class InventoryManager : MonoBehaviour
{
    public SlotManager[] SlotyEkwipunku;

    private void Start()
    {
        SlotyEkwipunku = GetComponentsInChildren<SlotManager>();

           
    }
    public void SprawdzPustySlot(GameObject Item)
    {

        for (int i = 0; i < SlotyEkwipunku.Length; ++i)
        {
            
            if (SlotyEkwipunku[i].Zajety == false)
            {
                Destroy(Item);
                SlotyEkwipunku[i].AddItem(Item);
                
                break;
            }
            if (i == SlotyEkwipunku.Length - 1 )
            {
                Debug.Log("invetory is full");
            }

        }
    
    }
    

}
