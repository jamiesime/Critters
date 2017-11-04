using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Direction {North, South, East, West};

public class PlayerMovement : Player  {

	public static PlayerMovement control;

	public float moveSpeed;

	public Rigidbody2D rb2d;
	
	public Direction dir;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		control = this;
	}

	// Update is called once per frame
	void Update () {
		getMovement();
		setDirection();
	}


	public void getMovement(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * moveSpeed);

	}

	public void setDirection(){
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

	public Direction getPlayerDirection(){
		return this.dir;
	}

}
