using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NetType {Normal, Big};

public class Net : MonoBehaviour {

	public NetType netType;

	public Direction dir;

	public float distance;

	private Vector3 initialScale;
	private Vector3 scaleIncrement;
	private Vector3 finalScale;

	private Vector3 movement;

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
	}

	public void findBehaviour(NetType type){
		switch (type)
		{
			case NetType.Normal:

			break;
		}
	}

	public void netThrow(){

		if (this.gameObject.transform.localScale.x < finalScale.x)
		{
		 	this.gameObject.transform.localScale += scaleIncrement;
		 	this.gameObject.transform.position += movement;
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

}
