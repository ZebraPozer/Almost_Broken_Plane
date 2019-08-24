using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackUpForChar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


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


/*if (positionDestination > currentPosition.y)
    {
        rb.velocity = new Vector2(rb.velocity.x, smallFlapForce);
        // transform.Translate(Vector2.up * smallFlapForce * Time.deltaTime);
        Debug.Log("up");
    }
else if (positionDestination <= currentPosition.y)
    {
        transform.Translate(Vector2.down * gravity * Time.deltaTime);
        positionDestination = -10000;
        Debug.Log("down");
    }
*/




//rb = GetComponent<Rigidbody2D>();
// currentPosition.y = currentPosition.y * gravity * Time.deltaTime;
//rb.position = new Vector2(currentPosition.x, currentPosition.y);



// get current position
// currentPosition = transform.position;
