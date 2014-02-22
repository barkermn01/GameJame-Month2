using UnityEngine;
using System.Collections;

public class KillScore : MonoBehaviour {
	ScoreManager score;
	// Use this for initialization
	void Start () {
		score = (ScoreManager)GameObject.FindGameObjectWithTag("background").GetComponent(typeof(ScoreManager));
		score.Score = 0;
	}
	
	// Update is called once per frame
	void Update () {
		guiText.text = "Score: "+score.Score.ToString();
	}
}
