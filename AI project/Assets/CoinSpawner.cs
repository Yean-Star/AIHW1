using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    [SerializeField]
    private Transform[] transform;
    [SerializeField]
    private GameObject coinSpawn;
    void Start()
    {
        SpawnBlock();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SpawnBlock()
    {
        int randomIndex = Random.Range(0, transform.Length);
        for (int i = 0; i < transform.Length; i++)
        {
            if (randomIndex == i)
            {
                Instantiate(coinSpawn, transform[i].position, Quaternion.identity);
            }
        }
    }
}
