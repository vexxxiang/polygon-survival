using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SpawnSprawdzaczaBloku : MonoBehaviour
{

    public GameObject Ziemia;
    public GameObject SprawdzaczBloku;
    public GameObject SprawdzaczeBloku;


    // Start is called before the first frame update
    void Awake()
    {
        SprawdzaczeBloku = GameObject.FindGameObjectWithTag("Sprawdzacze");
        Invoke("Spawn", 2);
    }
    void Spawn()
    {
        var sprawdzacz = Instantiate(SprawdzaczBloku, new Vector3(Ziemia.transform.position.x, Ziemia.transform.position.y + 1.0F, Ziemia.transform.position.z), Quaternion.identity);
        sprawdzacz.transform.SetParent(SprawdzaczeBloku.GetComponent<StaticLocation>().startLocation);
        Invoke("Spawn", 60);
    }
    // Update is called once per frame


    void Update()
    {

    }
}
