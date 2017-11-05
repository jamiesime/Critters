using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	public static PlayerActions control;

	public GameObject primaryTool;

	// Use this for initialization
	void Start () {
		control = this;
	}

	// Update is called once per frame
	void Update () {
		primaryTool = Player.control.equipment[0];
		lookForInput();
	}

	public void lookForInput(){
		if (Input.GetButtonDown("PrimaryAction")){
			primaryEquip();
		}
		if(Input.GetButtonDown("Switch")){
			swapEquipped();
		}
	}

	public void swapEquipped(){
		Equipment.control.cycleEquipped();
	}

	public void primaryEquip(){
		PlayerMovement.control.rb2d.velocity = Vector3.zero;
		PlayerMovement.control.rb2d.angularVelocity = 0.0f;
		GameObject net = (GameObject)Instantiate(primaryTool, Player.control.getCurrentPosition(), Player.control.getCurrentRotation());
	}

	public void takeDamage(int damage){
		Player.control.health -= damage;
		Player.control.checkHealth();
	}


}
