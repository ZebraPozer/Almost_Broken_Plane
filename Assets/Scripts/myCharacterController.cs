using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class myCharacterController : MonoBehaviour
{
    public float velocityMax = 8;
    public float velocityLow = 12;

    public static float characterAngle = 20f;
    public float gravity;
    public float smooth = 4;

    static float smallFlapForce = 0.08f;
    static float bigFlapForce = 0.2f;
    static float normalFlapHeigh = 0.8f;
    static float bigFlapHeigh = 3.0f;

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

        y0 = transform.position.y;
        x0 = transform.position.x;
        
       if (positionDestination > y0 && y0 <= 4 )
            {
            if (yPosTriger == 1)
                {
                y1 = y0 + bigFlapForce * smooth;
                }
            else
                {
                 y1 = y0 + smallFlapForce * smooth;
                }
            
            }
       else if (y0 <= -4.6)
            {
            y1 = y0 + 1f *smooth;
            }
       else
            {
            y1 = y0 - gravity * smooth;
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


        transform.position = new Vector2(x1, y1);
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
