using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    private Animator anim;

	// Use this for initialization
	void Start ()
    {
        anim = GetComponent<Animator>(); // get the animator component		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKey(KeyCode.DownArrow)) // check if down arrow is pressed
        {
            //modify parameter we created eralier
            anim.SetBool("isOpened", true);
        }
        else //if the botton isn't pressed
        {
            //set that paramitor as false
            anim.SetBool("isOpened", false);
        }	
	}
}
