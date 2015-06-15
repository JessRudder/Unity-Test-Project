using UnityEngine;
using System.Collections;

public class GameManager02 : MonoBehaviour {
	public GameObject musicCube;
	public GameObject lonelySphere;
	
	// Use this for initialization
	void Start () {
		for (int i = 0; i < 5; i++) {
			Instantiate(musicCube, new Vector3((5+(i*2)), 0.5f, 0), Quaternion.identity);
		}
		StartCoroutine (oneSecondDelay ());
		Instantiate (lonelySphere, new Vector3(15, 0.5f, 0), Quaternion.identity);
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	IEnumerator oneSecondDelay() {
		yield return new WaitForSeconds (1f);
	}

}
