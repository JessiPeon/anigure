using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pozo;

    private float timeBtwSpawn = 3;
    private float startTimeBtwSpawn = 8;

    void Update()
    {
        if (timeBtwSpawn <= 0)
        {
            Instantiate(pozo, transform.position, Quaternion.identity);
            startTimeBtwSpawn = Random.Range(4, 9);
            timeBtwSpawn = startTimeBtwSpawn;
        } else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
