using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	public static PlayerActions control;

	public GameObject netObject;

	// Use this for initialization
	void Start () {
		control = this;
	}

	// Update is called once per frame
	void Update () {
		lookForInput();
	}

	public void lookForInput(){
		if (Input.GetButtonDown("PrimaryAction")){
			throwNet();
		}
	}

	public void throwNet(){
		PlayerMovement.control.rb2d.velocity = Vector3.zero;
		PlayerMovement.control.rb2d.angularVelocity = 0.0f;
		GameObject net = (GameObject)Instantiate(netObject, Player.control.getCurrentPosition(), Player.control.getCurrentRotation());
	}

	public void takeDamage(int damage){
		Player.control.health -= damage;
		Player.control.checkHealth();
	}


}
