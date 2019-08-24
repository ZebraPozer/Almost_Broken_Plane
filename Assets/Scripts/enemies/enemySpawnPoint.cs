using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    public static float startXposition;
    private float spawnPointX;

    
    private void Start()
        {
        startXposition = transform.position.x;
        Instantiate(enemy, transform.position, Quaternion.identity);
        }

    public static implicit operator float(enemySpawnPoint v)
        {
        throw new NotImplementedException();
        }
   

    }
