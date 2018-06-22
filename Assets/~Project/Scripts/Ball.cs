using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Ball : MonoBehaviour
    {
        public float speed = 5f; // speed that the ball travels

        private Vector3 velocity; // velocity of th ball (Direction x speed)
        public void Fire(Vector3 direction)
        {
            //calculatee velocity
            velocity = direction * speed;
        }

        void OnCollisionEnter2D(Collision2D other)
        {
            //grab contact point of collision
            ContactPoint2D contact = other.contacts[0];
            //calculate the reflection point of the ball using velocity & contact normal
            Vector3 reflect = Vector3.Reflect(velocity, contact.normal);
            //claculate new velocity from reflection multiply by the same speed (velocity.magnitude)
            velocity = reflect.normalized * velocity.magnitude;
        }
        // Update is called once per frame
        void Update()
        {
            // move ball using velocity & deltaTime
            transform.position += velocity * Time.deltaTime;
        }
        void OnTriggerEnter(Collider other)
        {
          if (other.gameObject.CompareTag ("Blocks"))
            {
                other.gameObject.SetActive(false);
            }
        }
    }
}
