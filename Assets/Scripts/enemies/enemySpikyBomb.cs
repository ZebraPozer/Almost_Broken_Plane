using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpikyBomb : MonoBehaviour
{
    public int damage = 1;
    public float speed;
    public static float speedM = 2;
    static float spawnPointX;
    public static float speedInrceaser = 0.00f;
    private cameraAnimation cameraAnimation;


    //static float randomMultiplaer;
    //Vector3 currentPosition;
    //public GameObject effect;

    // Start is called before the first frame update
    void Start()
    {
      //  randomMultiplaer = Random.Range(0.5f, 1f);
    }
   
    // Update is called once per frame
     
    private void Update()
        {
        speed += speedInrceaser;
        // transform.Translate(Vector2.left * speed * Time.deltaTime);
        transform.position = new Vector2(transform.position.x- speedM * Time.deltaTime, transform.position.y + (Mathf.Sin(Time.time)) / 2f  * Time.deltaTime );
        Debug.Log(speedM);
        //transform.position = new Vector3(currentPosition.x - speed *Time.deltaTime , Mathf.Sin(Time.fixedTime * 2), currentPosition.z);
        
        }

    void OnTriggerEnter2D(Collider2D other)
        {

        if (other.CompareTag("myCharacter"))
            {
            //Instantiate(effect, transform.position, Quaternion.identity);
            Debug.Log(other.GetComponent<myCharacterController>());
            other.GetComponent<myCharacterController>().health -= damage;
            //cameraAnimation = GameObject.FindGameObjectsWithTag("cameraAnimation").getComponent<Shake>;

            Debug.Log(other.GetComponent<myCharacterController>().health);
            Destroy(gameObject);
            }
        }
}
