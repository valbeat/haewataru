﻿using UnityEngine;
using System.Collections;

public class Item : MonoBehaviour {
	public GameObject itemFx;
	public AudioClip itemSE;
	public int amount = 100;
	void Start () {
	}
	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "PlayerModel") {
				GameObject.FindWithTag("Player").BroadcastMessage("GetItem",amount);
				GameObject.FindWithTag("GameController").BroadcastMessage("GetItem",amount);
				Object.Destroy(gameObject);
		}
	}
}

