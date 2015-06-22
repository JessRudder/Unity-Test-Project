using UnityEngine;
using System.Collections;

public class GameManager03 : MonoBehaviour {
	public GameObject dancingCube;
	public GameObject lonelySphere;
	private AudioSource audio;
	private Camera camera;

	// Use this for initialization
	void Start () {
		Instantiate (dancingCube, new Vector3(0,.5f,0), Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
	}
}
