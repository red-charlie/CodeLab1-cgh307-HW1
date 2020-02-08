using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Input Variables
    //the public variables for the input
    public KeyCode UpInput;
    public KeyCode DownInput;
    public KeyCode LeftInput;
    public KeyCode RightInput;

    #endregion


    #region Other Variables
    //This is where other variables go
    Rigidbody2D rb2d;

    public float force = 10;

    ParticleSystem hitWall;

    public GameObject Prize;

    public GameObject ScoreObj;

    Score ScoringScript;

    GameState gameState;

    

    #endregion

    // Start is called before the first frame update
    void Start()
    {
        //Hi world, I am testing the debug.log for codelab1 class
        Debug.Log ("Hello World");

        //The original movement chunk
         rb2d = GetComponent<Rigidbody2D>();

        // rb2d.AddForce(Vector2.right * force);


        //Getting the particle system for hitting a wall
        hitWall = GetComponent<ParticleSystem>();

        //getting the scoring script ready for when I need to add score
        ScoringScript = ScoreObj.GetComponent<Score>();

        gameState = ScoreObj.GetComponent<GameState>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is the sad debug.log to prove that update happens every frame
        //Debug.Log("Goodbye World!");


        //Input stuff

        //If right is pressed apply a force right
        if(Input.GetKey(RightInput))
        {
            rb2d.AddForce(Vector2.right * force);
        }

        //If left is pressed apply a force left

        if(Input.GetKey(LeftInput))
        {
            rb2d.AddForce(Vector2.left * force);
        
        }
    
        //If up is pressed apply a force up

        if(Input.GetKey(UpInput))
        {
            rb2d.AddForce(Vector2.up * force);

        }

        //If down is pressed apply a force down

        if (Input.GetKey(DownInput))
        {
            rb2d.AddForce (Vector2.down * force);
        }

      
    

    }

    void OnCollisionEnter2D (Collision2D collision){

        //if you hit a wall play the hit particle effect
        if(collision.gameObject.tag == "wall")
        {
        Debug.Log ("I have hit a wall");
        hitWall.Play();
    
        }

        if (collision.gameObject == Prize && gameState.GameOver == false)
        {
            Debug.Log("I have hit the prize");
          //run the add score section
            addScore();

        }
       
    }


    void addScore()
    {
        //check which player
        if(tag == "player1")
        {
            //run the score addition
           ScoringScript.addScorePlayer1();
        
        }

        //check which player
        else if (tag == "player2")
        {
            //run the score addition
            ScoringScript.addScorePlayer2();

        }
    }
}
