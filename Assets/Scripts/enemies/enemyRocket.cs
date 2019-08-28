using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyRocket : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D other)
        {

        if (other.CompareTag("myCharacter"))
            {
            //Instantiate(effect, transform.position, Quaternion.identity);
            Debug.Log(other.GetComponent<myCharacterController>());
            other.GetComponent<myCharacterController>().health -= damage;

            Debug.Log(other.GetComponent<myCharacterController>().health);
            Destroy(gameObject);
            }
        }
    }
