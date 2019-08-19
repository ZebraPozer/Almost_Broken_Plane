using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnPoint : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;

    private void Start()
        {
        Instantiate(enemy, transform.position, Quaternion.identity);
        }
    }
