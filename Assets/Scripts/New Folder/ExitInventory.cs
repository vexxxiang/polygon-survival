using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitInventory : MonoBehaviour
{
    public GameObject Ekwipunek;

    // Start is called before the first frame update
    void Start()
    {

        
        exit();
    }
    public void exit()
    {
        Ekwipunek = GameObject.FindGameObjectWithTag("inventory");
        if (Ekwipunek.activeSelf == false)
        {
            Ekwipunek.SetActive(true);
        }
        else
        {
            Ekwipunek.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
