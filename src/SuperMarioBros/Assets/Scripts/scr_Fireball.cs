﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scr_Fireball : MonoBehaviour {

	private float speed = 0.05f;
	private scr_GameController gC;
	private Rigidbody2D rigidbody;

	void Start () {
		rigidbody  = GetComponent<Rigidbody2D>();
		gC = GameObject.Find("global_controller").GetComponent<scr_GameController>();
	}

	void Update () {
		rigidbody.velocity = new Vector2 (-speed, rigidbody.velocity.y);
	}

	void OnCollisionEnter2D(Collision2D coll) {
	if (coll.gameObject.tag == "player") {
			gC.damage_mario();
		}
	}
}
