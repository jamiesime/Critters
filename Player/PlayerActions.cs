using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour {

	public GameObject netObject;

	// Use this for initialization
	void Start () {
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


}
