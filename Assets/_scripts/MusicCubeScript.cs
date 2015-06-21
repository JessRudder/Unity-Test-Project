﻿using UnityEngine;
using System.Collections;

public class MusicCubeScript : MonoBehaviour {
	[Range(0f,10f)]public int speed;

	// Use this for initialization
	void Start () {
		speed = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (-Vector3.right * Time.deltaTime * speed);
	}
}
