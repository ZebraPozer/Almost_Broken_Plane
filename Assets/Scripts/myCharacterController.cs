using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCharacterController : MonoBehaviour
{
    public float velocity = 6;
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
        
    public void myCharacterFlap()
    {
        rb.velocity = Vector2.up * velocity;
        Debug.Log("clicked");
    }

    // Update is called once per frame
    void Update()
    {
        rb = GetComponent<Rigidbody2D>();
        /* if (Input.GetMouseButtonDown(0))
         {
                 rb.velocity = Vector2.up * velocity;
         }*/
        }
}
