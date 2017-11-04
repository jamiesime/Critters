using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCritter : Critter {


	public int movePeriod;
	public float moveSpeed;
	private float moveVertical;
	private float moveHorizontal;

	private Rigidbody2D rb2d;


	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		moveHorizontal = 0.0f;
		moveVertical = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		countTime();
		standardMove();
	}

	public void countTime(){
		movePeriod += 1;
	}

	public void standardMove(){
		if (movePeriod < 200){
			moveVertical = 1.0f;
			moveHorizontal = 0.0f;
		}
		if (movePeriod > 200){
			moveVertical = -1.0f;
			moveHorizontal = 0.0f;	
		}
		if (movePeriod > 400){
			movePeriod = 0;
		}
		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * moveSpeed);

	}
}
