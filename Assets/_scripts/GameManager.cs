using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject musicCube;
	public int killList;
	public GameObject[] killObjects;
	public GameObject killObject;
	private int cubeCount;
	public int killNum;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < 50; i++) {
			Instantiate (musicCube);
		}
		StartCoroutine ("killBox");
	}
	
	// Update is called once per frame
	void Update () {
		//Destroy (GameObject.FindGameObjectWithTag ("box"));
	}

	IEnumerator killBox() {
		cubeCount = GameObject.FindGameObjectsWithTag("box").Length;
		yield return new WaitForSeconds (1f);
		//Debug.Log(GameObject.FindGameObjectsWithTag("box").Length);
		for (int i = 0; i < cubeCount - 1; i++) {
			killObjects = GameObject.FindGameObjectsWithTag("box");
			killList = GameObject.FindGameObjectsWithTag("box").Length;
			killNum = Random.Range(0, killList - 1);
			//Debug.Log(killNum);
			killObject = killObjects[killNum];
			Debug.Log("Before: " + killObjects[killNum] + " Length: " + killList);
			Destroy (killObject);
			yield return new WaitForSeconds (0.5f);
			Debug.Log("After: " + killObjects[killNum] + " Length: " + killList);

		}
		yield return null;
	}
}
