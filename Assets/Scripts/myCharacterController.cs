using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class myCharacterController : MonoBehaviour
{
    public float velocityMax = 8;
    public float velocityLow = 12;

    public static float characterAngle = 20f;

    Vector3 currentPosition;
    Vector3 lastPosition;
    float smooth = 1.0f;

    static Rigidbody2D rb;

    public int health = 3;
    public Text helthDispay;
    // Start is called before the first frame update
    void Start()
        {
        rb = GetComponent<Rigidbody2D>();
        lastPosition = transform.position;
        }


    void Update()
        {
        helthDispay.text = health.ToString();

        rb = GetComponent<Rigidbody2D>();

        // get current position
        currentPosition = transform.position;
        //rb.MoveRotation(rb.rotation + characterAngle * Time.deltaTime);

        // Rotation based on Y current/last position 
        /*
        // Going Down
        if (lastPosition.y > currentPosition.y)
            {
            if (lastPosition.x > currentPosition.x)
                {
                if (rb.rotation <= -50f)
                    {
                    rb.rotation = currentPosition.y;
                    }
                else
                    {
                    characterAngle = -55f;
                    }
                }
            else
                {
                if (rb.rotation >= 45f)
                    {
                    //characterAngle = -15f;
                    rb.rotation = currentPosition.y;
                    Debug.Log(rb.rotation);
                    }
                else
                    {
                    characterAngle = 25f;
                    }
                //Debug.Log("down");
                }
            }

        // Going Up
        else if (lastPosition.y < currentPosition.y)
            {
            if (rb.rotation <= -50f)
                {
                characterAngle = 15f;
                //rb.rotation = currentPosition.y;
                }
            else
                {
                characterAngle = -25f;
                }
            //Debug.Log("up");
            }

        rb.MoveRotation(rb.rotation - characterAngle * Time.smoothDeltaTime);
        lastPosition = transform.position;
        */
        }

    public void myCharacterNormalFlap()
        {
        // Debug.Log("clicked");
        rb.velocity = Vector2.up * velocityLow;
        // Debug.Log(rb.position.y);

        }

    public void myCharacterBigFlap()
        {
        // Debug.Log("clicked");
        rb.velocity = Vector2.up * velocityMax;
        // Debug.Log(rb.position.y);
        }

    public void MyCharacterMoveRight()
        {
        rb.velocity = Vector2.right * velocityLow;
        }

    public void MyCharacterMoveLeft()
        {
        rb.velocity = Vector2.left * velocityLow;
        }
    }
