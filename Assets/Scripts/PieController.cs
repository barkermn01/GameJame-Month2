using UnityEngine;
using System.Collections;

public class PieController : MonoBehaviour {

	// The time that this play through started.
	private float startTime;
	
	// How far into this play through the player is.
	private float currentTime;

	// How fast the pie comes at the user. (yChange=xChange).
	private float xChange;
	private float yChange;

	// Use this for initialization
	void Start () {
		// startTime = Time.time;

		if (Time.time > 5){
			xChange = Random.Range (Time.time/850f, currentTime/860f);
		}
		else{
			xChange = Random.Range (0.01f, 0.03f);
		}
		yChange = xChange;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		makeBigger();
	}

	// Makes the pie get bigger.
	void makeBigger(){
		// currentTime = Time.time - startTime;

//			if (currentTime > 0 && currentTime <= 6){
//				xChange = Random.Range (0.01F, 0.03F);
//				yChange = xChange;
//			}
//			else if (currentTime > 6 && currentTime <= 12){
//				xChange = Random.Range (0.02F, 0.04F);
//				yChange = xChange;
//			}
//			else if (currentTime > 12 && currentTime <= 18){
//				xChange = Random.Range (0.03F, 0.05F);
//				yChange = xChange;
//			}
//			else if (currentTime > 18 && currentTime <= 24){
//				xChange = Random.Range (0.04F, 0.06F);
//				yChange = xChange;
//			}
//			else if (currentTime > 24 && currentTime <= 30){
//				xChange = Random.Range (0.05F, 0.07F);
//				yChange = xChange;
//			}

		transform.localScale += new Vector3(xChange, yChange, 0);

		if(transform.localScale.x > 1f){
			Destroy (gameObject);
			// TODO make it splatter
		}
	}

	void OnMouseUp() {
		Destroy (gameObject);
	}

}
