using UnityEngine;
using System.Collections;

public class BackDropController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp() {
		((ScoreManager)GameObject.FindGameObjectWithTag("background").GetComponent(typeof(ScoreManager))).Score--;
	}

}
