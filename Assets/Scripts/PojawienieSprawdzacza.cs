using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PojawienieSprawdzacza : MonoBehaviour
{
    public GameObject Sprawdzacz;


    // Start is called before the first frame update
    void Awake()
    {
        float x = this.transform.position.x;
        float y = this.transform.position.y;
        float z = this.transform.position.z;
        

        Instantiate(Sprawdzacz, new Vector3(x, y + 0.75f, z), Quaternion.identity);
   

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
