using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;

    public float nextPipeTime;
    public float spawnInterval = 1;
    public float randomHeight = 1;

    private void Start()
    {
        nextPipeTime = Time.time;
    }

    private void Update()
    {
        print(Time.time);
        
        if (Time.time > nextPipeTime)
        {
            var pos = transform.position;
            pos += Vector3.up * Random.Range(-randomHeight,randomHeight);
            
            Instantiate(prefab,pos,Quaternion.Euler(0,0,0));
            nextPipeTime += spawnInterval;
        }
    }
}
