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

    void Start()
    {

    }
     
    private void Update()
        {
        speed += speedInrceaser;
        transform.position = new Vector2(transform.position.x- speedM * Time.deltaTime, transform.position.y + (Mathf.Sin(Time.time)) / 2f  * Time.deltaTime );
        //Debug.Log(speedM);
        }

    void OnTriggerEnter2D(Collider2D other)
        {

        if (other.CompareTag("myCharacter"))
            {
            other.GetComponent<myCharacterController>().health -= damage;
            Destroy(gameObject);
            }
        }
}
