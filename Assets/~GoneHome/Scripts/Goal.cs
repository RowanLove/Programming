using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;
namespace GoneHome
{
    public class Goal : MonoBehaviour
    {
        public UnityEvent onTriggered;
     
        //runs function when collider enters triger (Goal) 
        void OnTriggerEnter(Collider other)
        {
            //check if other is "Player"
            if (other.name == "Player")
            {
                // run 'onTriggered' event

                onTriggered.Invoke();
            }
        }
    }
}