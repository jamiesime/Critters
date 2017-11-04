using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteEffects : MonoBehaviour {

	public static SpriteEffects control;

	public void Awake(){
		control = this;
	}

	public void fadeOutSprite(SpriteRenderer sprite){
		Color increment = new Color(0f, 0f, 0f, 0.05f);
		sprite.color -= increment;
	}
}
