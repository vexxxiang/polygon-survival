using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInventory : MonoBehaviour
{
    public GameObject Ekwipunek ;
    private void Start()
    {

        Ekwipunek.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            if (Ekwipunek.activeSelf == true)
            {
                Ekwipunek.SetActive(false);

            }
            else 
            {
                Ekwipunek.SetActive(true);
            }
        }
    }
}
