using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class SpawnBadPickUp : MonoBehaviour
    {

        public GameObject PickUp;

        void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Instantiate(PickUp, this.transform.position, this.transform.rotation);
            }
        }
    }
}