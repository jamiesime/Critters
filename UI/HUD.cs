using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour {

	public Text healthDisplay;
	public Text equipDisplay;


	public string healthString;
	public string equipString;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		healthString = Player.control.getHealth();
		equipString = Player.control.getEquipped();
		healthDisplay.text = healthString;
		equipDisplay.text = equipString;
	}
}
