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
    public GameObject EndScreen;
    Text EndText;
    string player1win = "GAME OVER \n Blue Wins!";
    string player2win = "GAME OVER \n Pink Wins!";
    



    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //finding the text components on the game objects
        player1Text = player1ScoreTextObject.GetComponent<Text>();
        player2Text = player2ScoreTextObject.GetComponent<Text>();

        //setting the score in the text objects

        player1Text.text = "Blue\n" + player1Score;
        player2Text.text = "Pink\n" + player2Score;
        

        //getting the text for the end screen
        EndText = EndScreen.GetComponent<Text>();



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScorePlayer1()
    {
        //add one to the blue score
        Debug.Log ("blue scores a point!");
        player1Score ++;
        player1Text.text = "Blue\n" + player1Score;

    }

    public void addScorePlayer2 ()
    {
        //add one to the pink score
        Debug.Log ("Pink scores a point!");
        player2Score ++;
        player2Text.text = "Pink\n" + player2Score;
    }

    public void EndGame()
    {
        //turning on the screen at the end
        EndScreen.SetActive(true);

    // Display the correct winning message based on score
        if(player1Score > player2Score)
        {
            EndText.text = player1win;
        }

        else if (player1Score < player2Score)
        {
            EndText.text = player2win;
        }

        else
        {
            EndText.text = "GAME OVER\n DRAW!";
        }
    }
}

