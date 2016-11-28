﻿using UnityEngine;
using System.Collections;

public class GhostMovement : MonoBehaviour {
    private float moveVelocity = -1.5f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	    GetComponent<Rigidbody2D>().velocity= new Vector3(moveVelocity,Mathf.Sin(transform.position.x)/2,0);
	}
}
