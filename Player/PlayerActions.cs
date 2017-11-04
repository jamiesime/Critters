using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : Player {

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
		GameObject net = (GameObject)Instantiate(netObject, getCurrentPosition(), getCurrentRotation());
	}


}
