using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBiter : Critter {

	public int movePeriod;
	public float moveSpeed;
	private float moveVertical;
	private float moveHorizontal;

	private Rigidbody2D rb2d;

	public int attackPower;

	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player" && !Player.control.invincible){
			attack(other.gameObject);
		}
	}

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D>();
		moveHorizontal = 0.0f;
		moveVertical = 0.0f;
	}

	// Update is called once per frame
	void Update () {
		if (!caught){
			countTime();
			standardMove();
			}
		else{
			rb2d.velocity = Vector3.zero;
			rb2d.angularVelocity = 0.0f;
		}
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

	public void attack(GameObject other){
		PlayerActions.control.takeDamage(attackPower);
		Vector2 movement = new Vector2 ((moveHorizontal * 10), (moveVertical * 10));
		PlayerMovement.control.rb2d.AddForce (movement * (moveSpeed *10));
	}





}
