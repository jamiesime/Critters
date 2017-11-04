using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum NetType {Normal, Big};

public class Net : MonoBehaviour {

	public NetType netType;

	// Use this for initialization
	void Start () {
		this.transform.position = Player.control.getCurrentPosition();
		netType = Player.control.equipped;
		findBehaviour(netType);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void findBehaviour(NetType type){
		switch (type)
		{
			case NetType.Normal:
			
			break;
		}
	}
}
