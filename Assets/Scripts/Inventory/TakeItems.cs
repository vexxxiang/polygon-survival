using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeItems : MonoBehaviour
{

    public GameObject SlotsKatalog;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider trigger)
    {
        if (trigger.CompareTag("Item"))
        {
            GameObject item = trigger.gameObject;
            var InventoryManager = SlotsKatalog.GetComponent<InventoryManager>();
            
            InventoryManager.SprawdzPustySlot(item);
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
