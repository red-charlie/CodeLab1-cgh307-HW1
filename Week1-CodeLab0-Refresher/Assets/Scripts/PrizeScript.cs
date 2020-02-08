﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrizeScript : MonoBehaviour
{

    ParticleSystem prizeBurst;

    // Start is called before the first frame update
    void Start()
    {
        prizeBurst = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D collsion)
    {
        //when hit by anything move to a random position on screen
        transform.position = new Vector2 (Random.Range (-6,6), Random.Range(-4,4));
        prizeBurst.Play();
    }
}
