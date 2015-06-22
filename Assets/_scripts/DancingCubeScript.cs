using UnityEngine;
using System.Collections;

public class DancingCubeScript : MonoBehaviour {
	[Range(0f,10f)]public float speed;
	private AudioSource audio;
	private float avgnum = 0f;
	private float avgdenom = 0f;
	private float red = 0f;
	private float green = 0f;
	private float blue = 0f;
	private float xrotation = 0f;

	// Use this for initialization
	void Start () {
		audio = Camera.main.GetComponent<AudioSource> ();
		speed = 1;
	
	}
	
	// Update is called once per frame
	void Update () {
		avgnum = 0f;
		avgdenom = 0f;
		float[] spectrum = audio.GetSpectrumData(1024, 0, FFTWindow.BlackmanHarris);
		speed = audio.volume * 10;
		transform.Translate (-Vector3.right * Time.deltaTime * speed);

		// make this object scale up and down along y axis with bass 
		for (int i = 0; i<200; i++) {
			avgnum += spectrum[i];
			avgdenom++;
		}
		this.transform.localScale = Vector3.Lerp(this.transform.localScale, new Vector3 (1f,avgnum/avgdenom*350f,1f), 0.5f);
		
		// make other objects scale up and down along y axis with various spectra 
		avgnum = 0f;
		avgdenom = 0f;
		for (int i = 200; i<500; i++) {
			avgnum += spectrum[i];
			avgdenom++;
			//i++;
		}
		red = ((Mathf.Sqrt (avgnum / avgdenom)) * 10000) / 300;
//		cubesies[0].transform.localScale = new Vector3 (1f,avgnum/avgdenom*500f,1f);

//		
		avgnum = 0f;
		avgdenom = 0f;
		for (int i = 500; i<700; i++) {
			avgnum += spectrum[i];
			avgdenom++;
			//i++;
		}
		green = ((Mathf.Sqrt(avgnum/avgdenom)) * 10000)/500;
//		cubesies[1].transform.localScale = new Vector3 (1f,avgnum/avgdenom*1000f,1f);
//		
		avgnum = 0f;
		avgdenom = 0f;
		for (int i = 700; i<870; i++) {
			avgnum += spectrum[i];
			avgdenom++;
			//i++;
		}
		blue = ((Mathf.Sqrt (avgnum / avgdenom)) * 10000) / 250;
		gameObject.GetComponent<MeshRenderer>().material.color = Color.Lerp(gameObject.GetComponent<MeshRenderer>().material.color, new Color(red,green,blue), 2f * Time.deltaTime);
//		cubesies[2].transform.localScale = Vector3.Lerp(cubesies[1].transform.localScale, new Vector3 (1f,avgnum/avgdenom*10000f,1f), 0.5f);
//		
		avgnum = 0f;
		avgdenom = 0f;
		for (int i = 870; i<1024; i++) {
			avgnum += spectrum[i];
			avgdenom++;
			i++;
		}
		xrotation = (Mathf.Sqrt (avgnum / avgdenom)) * 100000;
		Debug.Log (Time.deltaTime * xrotation);
		transform.Rotate(Time.deltaTime * xrotation, 0, 0);
	}
}
