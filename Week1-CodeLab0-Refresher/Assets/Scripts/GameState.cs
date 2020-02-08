using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameState : MonoBehaviour
{
    public bool  GameOver = false;
    public bool canScore = true;
    
    Score score;

    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        //get a reference to score
        score = GetComponent<Score>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver == true)
        {
            //when the game ends open up the ending message
            score.EndGame();
        }
    }

    
}
