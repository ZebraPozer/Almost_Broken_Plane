using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpikyBomb : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    Vector3 currentPosition;
    //public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
        currentPosition = transform.position;
    }
   
    // Update is called once per frame
     
    private void Update()
        {
        currentPosition = transform.position;
        transform.Translate(Vector2.left * speed * Time.deltaTime);
        
        //transform.position = new Vector3(currentPosition.x - speed *Time.deltaTime , Mathf.Sin(Time.fixedTime * 2), currentPosition.z);

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
