using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineralsInfo : MonoBehaviour
{
    public int maxHealth = 4;
    public int currentHealth;
    public HealthBar healthBar;

    public GameObject Coal;
    public GameObject Diamond;
    public GameObject Emerald;
    public GameObject Iron;
    public GameObject Ruby;

    public GameObject Coal_item;
    public GameObject Diamond_item;
    public GameObject Emerald_item;
    public GameObject Iron_item;
    public GameObject Ruby_item;

    public GameObject Player;

    public OnGUIHandler onguiHandler;



    // Start is called before the first frame update
    void Start()
    {
        onguiHandler = GameObject.FindGameObjectWithTag("Canvas").GetComponent<OnGUIHandler>();
        Player = GameObject.FindGameObjectWithTag("Player");

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    private void OnMouseDown()
    {
        if (onguiHandler.overGUI == true) return;

        float dist = Vector3.Distance(Player.transform.position, transform.position);

        if (dist < 5.0)
        {

            TakeDamage(1);
        }
        
    }

    public void TakeDamage(int Damage)
    {
        currentHealth -= Damage;

        healthBar.SetHealth(currentHealth);
    }
    private void Update()
    {
        if (currentHealth <= 0)
        {
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);

            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;

            string surowiec = gameObject.name;

            
            
            Destroy(gameObject);
            if (surowiec == "Coal(Clone)")
            {
                Instantiate(Coal_item, new Vector3(x, y, z), Quaternion.identity);
            }
            if (surowiec == "Diamond(Clone)")
            {
                Instantiate(Diamond_item, new Vector3(x, y, z), Quaternion.identity);
            }
            if (surowiec == "Emerald(Clone)")
            {
                Instantiate(Emerald_item, new Vector3(x, y, z), Quaternion.identity);
            }
            if (surowiec == "Iron(Clone)")
            {
                Instantiate(Iron_item, new Vector3(x, y, z), Quaternion.identity);
            }
            if (surowiec == "Ruby(Clone)")
            {
                Instantiate(Ruby_item, new Vector3(x, y, z), Quaternion.identity);
            }
        }
    }
}
