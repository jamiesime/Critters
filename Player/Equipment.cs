using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipment : MonoBehaviour {

	public static Equipment control;

	public GameObject normalNet;
	public GameObject normalTrap;

	// Use this for initialization
	void Awake () {
			control = this;
			// just add two tools for now, more complexity later
	}

	// Update is called once per frame
	void Update () {
	}

	public void populateEquipment(List<GameObject> equipment){
		equipment.Add(normalNet);
		equipment.Add(normalTrap);
	}

	public void cycleEquipped(){
		print("Trying to cycle");
		GameObject unequip = Player.control.equipment[0];
		Player.control.equipment.RemoveAt(0);
		Player.control.equipment.Add(unequip);
		Player.control.equipped = Player.control.equipment[0];
	}


}
