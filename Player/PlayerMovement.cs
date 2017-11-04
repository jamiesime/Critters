using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : Player  {

	public float moveSpeed;

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		getMovement();
		getDirection();
	}


	public void getMovement(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * moveSpeed);
	
	}

	public void getDirection(){
		if (Input.GetAxis("Vertical") > 0.0f){
			dir = Direction.North;
		}
		if (Input.GetAxis("Vertical") < 0.0f){
			dir = Direction.South;
		}
		if (Input.GetAxis("Horizontal") < 0.0f){
			dir = Direction.West;
		}
		if (Input.GetAxis("Horizontal") > 0.0f){
			dir = Direction.East;
		}
	}

}
