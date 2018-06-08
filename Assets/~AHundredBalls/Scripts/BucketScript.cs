using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucketScript : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private Renderer[] renderers;

	// Use this for initialization
	void Start ()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        renderers = GetComponentInChildren<Renderer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        HandlePosition();
        HandleBoundary();
	}
}
