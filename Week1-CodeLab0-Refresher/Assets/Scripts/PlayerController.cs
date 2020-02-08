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
        
        
    }

    // Update is called once per frame
    void Update()
    {
        //This is the sad debug.log to prove that update happens every frame
        //Debug.Log("Goodbye World!");


        //Input Code

        //If D is pressed apply a force right
        if(Input.GetKey(RightInput))
        {
            rb2d.AddForce(Vector2.right * force);
        }

        //If A is pressed apply a force left

        if(Input.GetKey(LeftInput))
        {
            rb2d.AddForce(Vector2.left * force);
        
        }
    
        //If W is pressed apply a force up

        if(Input.GetKey(UpInput))
        {
            rb2d.AddForce(Vector2.up * force);

        }

        //If S is pressed apply a force down

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
       
    }


}
