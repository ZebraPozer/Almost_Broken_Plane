using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class myCharacterController : MonoBehaviour
{
    public float velocityMax = 8;
    public float velocityLow = 12;

    float lerpTime = 1f;
    float currentLerpTime;

    public static float characterAngle = 20f;
    public float gravity;
    public float smooth = 4;

    static float smallFlapForce = 0.1f;
    static float bigFlapForce = 0.2f;
    static float normalFlapHeigh = 1f;
    static float bigFlapHeigh = 2.0f;

    static float sideMove = 1f;
    static float sideMoveSmooth = 0.1f;
    static float positionXdestination;

    static int xPosTriger;
    static int yPosTriger;

    static float y1;
    static float y0;
    static float x1;
    static float x0;
    static float positionDestination;
    static float positionBeforeFlap;
     
    static Rigidbody2D rb;

    public int health = 3;
    public Text helthDispay;
    // Start is called before the first frame update
    void Start()
        {
        rb = GetComponent<Rigidbody2D>();
        }


    void Update()
        {
        // helath
        helthDispay.text = health.ToString();
        if (health <= 0)
            {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }

        rb = GetComponent<Rigidbody2D>();

        //up
        float rotation = rb.rotation;

        if (rb.rotation <= -25f)
            {
            rb.rotation = -25f;
            }
        if (rb.rotation >= 45f)
             {
                rb.rotation = 45f;
             }
          
       /* if (y0 < transform.position.y)
            {
                rb.rotation = rotation + 25f * Time.deltaTime;
            }
        else
            {
            rb.rotation = rotation - 25f * Time.deltaTime;
            }*/

        y0 = transform.position.y;
        x0 = transform.position.x;

        currentLerpTime += Time.deltaTime;
        float t = currentLerpTime / lerpTime;

        if (positionDestination > y0 && y0 <= 4 )
            {
            if (yPosTriger == 1)
                {
                y1 = y0 + bigFlapForce  + Mathf.Sin(t * Mathf.PI * 0.0001f);
                rb.rotation = 0f * Time.deltaTime;
              
                }
            else
                {
                 y1 = y0 + smallFlapForce  + Mathf.Sin(t * Mathf.PI *0.0005f);
                rb.rotation = 0f * Time.time * smooth;
                }
            
            }
       else if (y0 <= -4.6)
            {
            y1 = y0 + 1f *smooth;
            }
       else
            {
            rb.rotation = rotation - 15f * Time.deltaTime;
            y1 = y0 - gravity * (smooth + Mathf.Sin(t * Mathf.PI * 0.0001f));
            positionDestination = -1000;
            }

        if (xPosTriger ==1)
            {
            if (positionXdestination > x1)
                {
                x1 = x0 + sideMoveSmooth * smooth;
                }
            else
                {
                xPosTriger = 0;
                }
            }
        else if(xPosTriger == 2)
            {
            if (positionXdestination < x1)
                {
                x1 = x0 - sideMoveSmooth * smooth;
                }
            else
                {
                xPosTriger = 0;
                }
                
            }
        
        transform.position = new Vector2(x1, y1 );


        }

    public void myCharacterNormalFlap()
        {
        yPosTriger = 0;
        positionDestination = y0 + normalFlapHeigh;
        }

    public void myCharacterBigFlap()
        {
        yPosTriger = 1;
        positionDestination = y0 + bigFlapHeigh;
        }

    public void MyCharacterMoveRight()
        {
        positionXdestination = x0 + sideMove;
        xPosTriger = 1;
        }

    public void MyCharacterMoveLeft()
        {
        positionXdestination = x0 - sideMove;
        xPosTriger = 2;
        }
    }
