using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Clean code: CTRL + K + D (in that order)
// Fold code: CTRL + M + O
// Un-Fold code: CTRL + M + P

// {} - Braces
// [] - Brackets
// () - Parenthesis 

// Level 1 - Classes
// Level 2 - Functions and Variables
// Level 3 - Statements

namespace Asteroids
{
    public class Moving : MonoBehaviour
    {
        public float movementSpeed = 10f;
        public float rotationSpeed = 360f;


        void Rotation()
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Rotate(Vector3.forward, rotationSpeed * Time.deltaTime);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Rotate(Vector3.back, rotationSpeed * Time.deltaTime);
            }
        }
        void Movement()
        {
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //Vector3 position = transform.position;
                //position.y += movementSpeed * Time.deltaTime;
                //transform.position = position;
                transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
            }
        }

        // Update is called once per frame
        void Update()
        {
            Movement();

            Rotation();
        }
    }
}