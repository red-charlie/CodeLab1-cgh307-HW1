using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    #region variables
    //the game objects that hold the text component for each player
    public GameObject player1ScoreTextObject;
    public GameObject player2ScoreTextObject;

    //the text components for each player

    Text player1Text;
    Text player2Text;


    //the current score for each player

    int player1Score = 0;
    int player2Score = 0;



    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //finding the text components on the game objects
        player1Text = player1ScoreTextObject.GetComponent<Text>();
        player2Text = player2ScoreTextObject.GetComponent<Text>();

        //setting the score in the text objects

        player1Text.text = "Blue \n" + player1Score;
        player2Text.text = "Pink \n" + player2Score;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
