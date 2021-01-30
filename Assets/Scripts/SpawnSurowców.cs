using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSurowców : MonoBehaviour
{
    public GameObject generatorsurowcow;
    public GameObject Wegiel;
    public GameObject Diamond;
    public GameObject Emerald;
    public GameObject Iron;
    public GameObject Ruby;


    public GameObject SprawdzaczBloku;
    int Koliduje = 1;
    public int Liczba;

    // Start is called before the first frame update
    void Start()
    {
        generatorsurowcow = GameObject.FindGameObjectWithTag("GeneratorSurowcow");
        Invoke("Spawn", 1);
    }

    void Spawn()
    {
        
        if (Koliduje == 1)
        {
            Liczba = Random.Range(1, 200);
            float x = this.transform.position.x;
            float y = this.transform.position.y;
            float z = this.transform.position.z;

            if (Liczba == 1)
            {
                var Surowiec = Instantiate(Wegiel, new Vector3(x,y-0.29f,z), Quaternion.Euler(-90f, 0f, 0f));
                Surowiec.transform.SetParent(generatorsurowcow.GetComponent<StaticLocation>().startLocation);
            }
            if (Liczba == 2)
            {
                var Surowiec = Instantiate(Diamond, new Vector3(x, y - 0.29f, z), Quaternion.Euler(-90f, 0f, 0f));
                Surowiec.transform.SetParent(generatorsurowcow.GetComponent<StaticLocation>().startLocation);

            }
            if (Liczba == 3)
            {
                var Surowiec = Instantiate(Emerald, new Vector3(x, y - 0.29f, z), Quaternion.Euler(-90f, 0f, 0f));
                Surowiec.transform.SetParent(generatorsurowcow.GetComponent<StaticLocation>().startLocation);

            }
            if (Liczba == 4)
            {
                var Surowiec = Instantiate(Iron, new Vector3(x, y - 0.29f, z), Quaternion.Euler(-90f, 0f, 0f));
                Surowiec.transform.SetParent(generatorsurowcow.GetComponent<StaticLocation>().startLocation);

            } 
            if (Liczba == 5)
            {
                var Surowiec = Instantiate(Ruby, new Vector3(x, y - 0.29f, z), Quaternion.Euler(-90f, 0f, 0f));
                Surowiec.transform.SetParent(generatorsurowcow.GetComponent<StaticLocation>().startLocation);

            }




            Destroy(SprawdzaczBloku);

        }
        Start();
    }
    private void OnTriggerStay(Collider trigger)
    {

        if (trigger.CompareTag("Blok"))
        {
            Koliduje = 0;
            Destroy(SprawdzaczBloku);

            
        }
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
