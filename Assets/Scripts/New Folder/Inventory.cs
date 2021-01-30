using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public GameObject Ekwipunek;

    // Start is called before the first frame update
    void Start()
    {
        Ekwipunek.SetActive(false);
    }
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Ekwipunek.activeSelf == false)
            {
                Ekwipunek.SetActive(true);
            }
            else
            {
                Ekwipunek.SetActive(false);
            }
            
        }
    }
}
