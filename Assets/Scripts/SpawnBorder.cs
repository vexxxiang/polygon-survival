using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBorder : MonoBehaviour
{
    public GameObject BorderBlock;

    // Start is called before the first frame update
    void Start()
    {

        StartSpawningBorder();
    }
    void StartSpawningBorder()
    {

        for (int x = 1; x <= 100; ++x)
        {
            for (int z = 1; z <= 100; ++z)
            {
                GoSpawnBorder(x, z);
            }
        }
    }
    void GoSpawnBorder(int x, int z)
    {
        float XChunk = this.GetComponent<Transform>().transform.position.x;
        float ZChunk = this.GetComponent<Transform>().transform.position.z;
        var Block = Instantiate(BorderBlock, new Vector3(XChunk + (x * 1.0F), 1, ZChunk + (z * 1.0F)), Quaternion.identity);
        Block.transform.SetParent(this.GetComponent<StaticLocation>().startLocation);

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
