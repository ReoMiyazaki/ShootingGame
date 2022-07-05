using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn", 2.0f, 1.0f);
    }

    void Spawn()
    {
        Vector3 spawnPosition = new Vector3(
            Random.Range(-8.5f,8.5f),
            transform.position.y,
            transform.position.z
            );

        Instantiate(
            Enemy,
            spawnPosition,
            transform.rotation
            );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
