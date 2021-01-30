using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlockInChunk : MonoBehaviour
{
    public GameObject Ziemia;
    public GameObject Chunk;


    // Start is called before the first frame update
    void Start()
    {
        StartSpawningBlockInChunk();
    }

    void StartSpawningBlockInChunk()
    {
        for (int x = 1; x <= 16; ++x)
        {
            for (int z = 1; z <= 16; ++z)
            {
                SpawnBlock(x, z);
            }
        }
        
    }
    void SpawnBlock(int x, int z)
    {
        float XChunk = Chunk.GetComponent<Transform>().transform.position.x;
        float ZChunk = Chunk.GetComponent<Transform>().transform.position.z;
        var Block = Instantiate(Ziemia, new Vector3(XChunk + (x * 1.0F), 0, ZChunk + (z * 1.0F)), Quaternion.identity);
        Block.transform.SetParent(Chunk.GetComponent<StaticLocation>().startLocation);
    }
    void FixedUpdate()
    {

    }
}
