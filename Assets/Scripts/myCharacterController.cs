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
    public float gravity = 0.2f;
    public float smooth = 4;

    static float smallFlapForce = 0.06f;
    static float bigFlapForce = 0.2f;
    static float normalFlapHeigh = 0.75f;
    static float bigFlapHeigh = 2.0f;

    static float kinematicEnergy = 2.6f;
    static float gravityEnergy = 1;

    static float tapTrigger;

    static float sideMove = 2.5f;
    static float sideMoveSmooth = 0.1f;
    static float positionXdestination;
    static int score = 10;

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
            SceneManager.LoadScene(1);
            }

        rb = GetComponent<Rigidbody2D>();

        //up
        float rotation = rb.rotation;
          
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

        if (positionDestination > y1 && y0 <= 4 )
            {
            if (yPosTriger == 1)
                {
                gravityEnergy = 0f;
                y1 = y0 + bigFlapForce /* + Mathf.Sin(t * Mathf.PI * 0.0001f)*/;
                /* if (rb.rotation < 0)
                     {
                     rb.rotation += 15f ;
                     }  */
                //rb.rotation = 0f * Time.deltaTime;
                tapTrigger = 0;
                }
            else
                {
                 gravityEnergy = 0f;
                 y1 = y0 + smallFlapForce * kinematicEnergy /*  + Mathf.Sin(t * Mathf.PI *0.0005f)*/;
                //rb.rotation = 0f * Time.time * smooth;
                if (tapTrigger == 1)
                    {
                    kinematicEnergy = 2.6f;
                    }
                else { 
                    if ( kinematicEnergy >= 0.2f)
                        {
                        kinematicEnergy -= 0.04f;
                        //Debug.Log(kinematicEnergy);
                        }
                    else
                        {
                        kinematicEnergy -= 0.01f;
                        }
                }
                tapTrigger = 0;
                }
            
            }
       else if (y0 <= -4.8)
            {
            kinematicEnergy = 2.6f;
            y1 = y0;
            }
       else
            {
            kinematicEnergy = 2.6f;
            //rb.rotation = rotation - 15f * Time.deltaTime;

            y1 = y0 - gravity*gravityEnergy * (smooth + Mathf.Sin(t * Mathf.PI * 0.0001f));
            positionDestination = -1000;
            if (gravity < 1)
                {
                gravityEnergy += 0.1f;
                }
            else
                {
                gravityEnergy = 1.25f;
                }
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
        x1 -= 0.625f * Time.deltaTime;

        if (waveCounterScore.score >= score)
            {
            enemySpikyBomb.speedM += 1f;
            //enemySpikyBomb.speedInrceaser += 0.0005f * Time.deltaTime;
            score += 10;
            Debug.Log(score);
            }

        transform.position = new Vector2(x1, y1);

        }

    public void myCharacterNormalFlap()
        {
        tapTrigger = 1;
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
