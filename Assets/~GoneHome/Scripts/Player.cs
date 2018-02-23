using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GoneHome
{
    public class Player : MonoBehaviour
    {
        public float movemoentspeed = 10f;
        private Rigidbody ridgid;
        // Use this for initialization
        void Start()
        {
            ridgid = GetComponent<Rigidbody>();
        }

        // Update is called once per frame
        void Update()
        {
            
            float inputH = Input.GetAxis("Horizontal");
            float inputV = Input.GetAxis("Vertical");

           
            Vector3 inputDir = new Vector3(inputH, 0, inputV);


            Vector3 position = transform.position;

            position += inputDir * movemoentspeed * Time.deltaTime;

            ridgid.MovePosition(position);
        }
    }
}
