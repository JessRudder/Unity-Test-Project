using UnityEngine;
using System.Collections;

public class LonelySphereScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime * 5);
		transform.Translate(Vector3.forward * Input.GetAxis("Vertical") * Time.deltaTime * 5);
	}
}
