﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Project
{
    public class Paddle : MonoBehaviour
    {
        public float movementSpeed = 20f;
        public Ball currentBall;
        public Text CountText;
        private int Count;
        public bool hasFired;
        //directions array defaults
        public Vector2[] directions = new Vector2[]
        {
            new Vector2(-0.5f, 0.5f),
            new Vector2(0.5f, 0.5f)
        };

        // Use this for initialization
        void Start()
        {
            //Grabs currentBall from children of the paddle
            currentBall = GetComponentInChildren<Ball>();
        }

        void Fire()
        {
            //Detach as child
            currentBall.transform.SetParent(null);
            //Generate random dirrection from list of directions
            Vector3 randomDir = directions[Random.Range(0, directions.Length)];
            // fire off ball in random direction
            currentBall.Fire(randomDir);
            hasFired = true;
        }

        void CheckInput()
        {
            if(!hasFired)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    Fire();
                }
            }
        }

        void Movement()
        {
            //Get input on horizontal axis
            float inputH = Input.GetAxis("Horizontal");
            // set force to direction (inputH to decide which direction)
            Vector3 force = transform.right * inputH;
            // Apply delta time to force
            force *= movementSpeed;
            // Apply delta time to force
            force *= Time.deltaTime;
            //add force to position
            transform.position += force;
        }
        // Update is called once per frame
        void Update()
        {
            CheckInput();
            Movement();
        }
        //gain score on pick up
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Pick Up"))
            {
                other.gameObject.SetActive(false);
                Count = Count + 1;
                SetCountText();
            }
            //lose points on bad pick up
            if (other.gameObject.CompareTag("Pick Up Bad"))
            {
                other.gameObject.SetActive(false);
                Count = Count - 1;
                SetCountText();
            }
        }
        //counts score
        void SetCountText()
        {
            CountText.text = "Count: " + Count.ToString();
        }
    }
}
