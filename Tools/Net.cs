﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NetType {Normal, Big};

public class Net : MonoBehaviour{

	public SpriteRenderer netModel;
	public string sortingLayer = "LowScene";

	public GameObject netType;

	public Direction dir;

	public float distance;

	private Vector3 initialScale;
	private Vector3 scaleIncrement;
	private Vector3 finalScale;

	private Vector3 movement;

	private bool landed;


	public void OnTriggerEnter2D(Collider2D other){
		if (other.gameObject.tag == "Critter" && !landed) {
			movement = Vector3.zero;
			attemptCatch(other.gameObject);
		}
	}

	// Use this for initialization
	void Awake () {

		initialScale = new Vector3 (0.0f, 0.0f, 0.0f);
		scaleIncrement = new Vector3 (0.1f, 0.1f, 0.1f);
		finalScale = new Vector3 (1.0f, 1.0f, 1.0f);
		this.gameObject.transform.localScale = initialScale;
		this.transform.position = Player.control.getCurrentPosition();
		netType = Player.control.equipped;
		findBehaviour(netType);
		setDirection();
	}

	// Update is called once per frame
	void Update () {
		netThrow();
		if (landed) {
			SpriteEffects.control.fadeOutSprite(netModel);
			Destroy(this.gameObject, 1.0f);
			}
	}

	public void findBehaviour(GameObject netType){

	}

	public void netThrow(){

		if (this.gameObject.transform.localScale.x < finalScale.x)
		{
		 	this.gameObject.transform.localScale += scaleIncrement;
		 	this.gameObject.transform.position += movement;
		}
		else {
			StartCoroutine(delayAfterLanding());
		}
	}

	public void setDirection(){
		dir = PlayerMovement.control.getPlayerDirection();
		switch (dir)
		{
			case Direction.North:
				movement = new Vector3 (0.0f, distance, 0.0f);
			break;
			case Direction.South:
				movement = new Vector3(0.0f, -distance, 0.0f);
			break;
			case Direction.West:
				movement = new Vector3(-distance, 0.0f, 0.0f);
			break;
			case Direction.East:
				movement = new Vector3(distance, 0.0f, 0.0f);
			break;
		}
	}

	public void attemptCatch(GameObject critter){
			critter.GetComponent<Critter>().caught = true;
			Destroy(critter, 1.0f);
	}

	public IEnumerator delayAfterLanding(){
		yield return new WaitForSeconds(0.5f);
		netModel.sortingLayerName = sortingLayer;
		landed = true;
	}

}
