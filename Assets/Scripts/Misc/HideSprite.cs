﻿using UnityEngine;
using System.Collections;

public class HideSprite : MonoBehaviour {

	// Use this for initialization
	void Start () {
		this.gameObject.GetComponent<SpriteRenderer> ().enabled = false;


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
