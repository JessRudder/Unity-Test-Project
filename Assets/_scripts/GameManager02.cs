using UnityEngine;
using System.Collections;

public class GameManager02 : MonoBehaviour {
	public GameObject musicCube;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			Instantiate(musicCube, new Vector3((5+(i*2)), 0.5f, 0), Quaternion.identity);
		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
