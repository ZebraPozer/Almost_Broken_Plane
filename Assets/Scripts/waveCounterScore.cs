using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class waveCounterScore : MonoBehaviour
{
    public Text waveScore;

    public static int score;

    private void OnTriggerEnter2D(Collider2D other)
        {
        waveScore.text = score.ToString();

        if (other.CompareTag("enemyObject"))
            {
            score++;
           // Debug.Log(score);

            }
        }
    }
