using UnityEngine;
using System.Collections;

public class SplatController : MonoBehaviour {

	private float startTime;
	private float currentTime;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		currentTime = Time.time - startTime;

		if (currentTime > 1){
			Destroy(gameObject);
		}
	}
}
