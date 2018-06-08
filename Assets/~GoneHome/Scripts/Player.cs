using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float acceleration = 10f;
        public float maxVelocity = 10f;
        private Rigidbody rigid;
        // Use this for initialization
        void Start()
        {
            rigid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

           
            Vector3 inputDir = new Vector3(inputH, 0, inputV);

            Transform cam = Camera.main.transform;
            inputDir = Quaternion.AngleAxis(cam.eulerAngles.y, Vector3.up) * inputDir;

            rigid.AddForce(inputDir * acceleration);

            Vector3 vel = rigid.velocity;

            if (vel.magnitude > maxVelocity)
            {
                vel = vel.normalized * maxVelocity;
            }
            rigid.velocity = vel;
        }
    }
}
