﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {
	private Paddle paddle;
	private Rigidbody2D myRigidBody;
	private bool hasStarted = false;
	private Vector3 paddleToBallVector;

	// Use this for initialization
	void Start () {

	paddle = GameObject.FindObjectOfType<Paddle>();

		paddleToBallVector = this.transform.position - paddle.transform.position;
		myRigidBody = GetComponent<Rigidbody2D>();

	}
	
	// Update is called once per frame
	void Update () {

	if (!hasStarted) {
	// lock the ball relative to the paddle.
		this.transform.position = paddle.transform.position + paddleToBallVector;

		// Wait for a mouse press to launch
		if (Input.GetMouseButtonDown(0)) {
		print ("Mouse Clicked, launch ball");
		hasStarted = true;
			this.myRigidBody.velocity = new Vector2 (2f, 10f);

			}
		}

	}
}
