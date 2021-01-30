using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseChanger : MonoBehaviour
{
    GameObject Player;
    public Texture2D PickaxeImage;
    public CursorMode cursorMode = CursorMode.Auto;
    public Vector2 hotSpot = Vector2.zero;

    public OnGUIHandler onguiHandler;
    void Start()
    {

        onguiHandler = GameObject.FindGameObjectWithTag("Canvas").GetComponent<OnGUIHandler>();

        Player = GameObject.FindGameObjectWithTag("Player");

        this.transform.GetChild(0).gameObject.SetActive(false);
    }
    private void OnMouseEnter()
    {
        float dist = Vector3.Distance(Player.transform.position, transform.position);


        if (onguiHandler.overGUI == true) return;

       

        
        if (gameObject.CompareTag("Blok"))
        {
            if (dist < 5.0)
            {
                gameObject.transform.GetChild(0).gameObject.SetActive(true);

                Cursor.SetCursor(PickaxeImage, hotSpot, cursorMode);
                


            }
        }

        
        
    }
    private void OnMouseExit()
    {
        if (onguiHandler.overGUI == true) return;
        if (gameObject.CompareTag("Blok"))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
            Cursor.SetCursor(null, Vector2.zero, cursorMode);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
