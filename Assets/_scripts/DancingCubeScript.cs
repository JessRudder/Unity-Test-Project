using UnityEngine;
using System.Collections;

public class DancingCubeScript : MonoBehaviour {
	[Range(0f,10f)]public float speed;
	private AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = Camera.main.GetComponent<AudioSource> ();
		speed = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		speed = audio.volume * 10;
		Debug.Log ("Speed: " + speed);
		Debug.Log ("Audio: " + audio.volume);
		transform.Translate (-Vector3.right * Time.deltaTime * speed);
	}
}
