using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
     int timeLeft;
     public int TimerAmt;
     public GameObject ScoringObj;
     GameState gameState;
   

    //Getting a reference to the text in the middle
    public Text TimerText;

    // Start is called before the first frame update
    void Start()
    {
        //set the timer to the correct time 
        timeLeft = TimerAmt;

        //display that time
        TimerText.text = "Time\n" + timeLeft;

        //reduce time every second
        InvokeRepeating("reduceTimer",1f,1);

        //get the gamestate script
        gameState = ScoringObj.GetComponent<GameState>();

    }

    // Update is called once per frame
    void Update()
    {
        //if there is no time left end the game
        if (timeLeft <= 0){
            timeLeft = 0;
            gameState.GameOver = true;

        }

        //display current time
        TimerText.text = "Time\n" + timeLeft;

        
    }

    void reduceTimer()
    {
        //reduce one from time
        timeLeft --;

    }
}
