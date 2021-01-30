using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    GameObject chest;
    public GameObject EQPanel;
    public GameObject InChest;




    // Start is called before the first frame update
    void Start()
    {
        chest = this.gameObject;
    }

    public void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
        {
            EQPanel.gameObject.SetActive(true);
            InChest.gameObject.SetActive(true);
        }
    }





    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            InChest.gameObject.SetActive(false);
            EQPanel.gameObject.SetActive(false);
        }
    }
}
