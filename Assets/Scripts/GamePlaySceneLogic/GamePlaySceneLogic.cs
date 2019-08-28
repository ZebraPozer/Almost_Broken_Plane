using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamePlaySceneLogic : MonoBehaviour
{
    static int score = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (waveCounterScore.score >= score)
            {
            enemySpikyBomb.speedM += 1f;
            //enemySpikyBomb.speedInrceaser += 0.0005f * Time.deltaTime;
            score += 10;
            Debug.Log(score);
            }
        
        if (myCharacterController.staticHealth <= 0)
            {
            SceneManager.LoadScene(1);
            }
        }
}
