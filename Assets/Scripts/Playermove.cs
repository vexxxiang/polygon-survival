using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermove : MonoBehaviour
{
    public float speed = 3f;
    private Rigidbody rg;
    public GameObject obiekt1;
    public GameObject obiekt2;
    public GameObject obiekt3;
    GameObject TrigeredBlock;


    // Start is called before the first frame update
    void Start()
    {
        rg = GetComponent<Rigidbody>();
    }




    // Update is called once per frame
    void Update()
    {
        


        if (Input.GetKey(KeyCode.W))
        {

            rg.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {

            rg.AddForce(Vector3.forward * -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rg.AddForce(Vector3.left * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rg.AddForce(Vector3.right * speed);
        }
    }
}
