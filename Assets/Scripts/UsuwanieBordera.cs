using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsuwanieBordera : MonoBehaviour
{
    public GameObject Sprawdzacz;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void OnTriggerStay(Collider trigger)
    {

        if (trigger.CompareTag("Border"))
        {
            Destroy(trigger);
            Destroy(Sprawdzacz);

        }
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
