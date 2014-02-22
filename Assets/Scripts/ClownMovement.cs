using UnityEngine;
using System.Collections;

public class ClownMovement : MonoBehaviour {
	private enum Movement{
		Left,
		Right
	}
	private Movement moving;
	public float speed;
	public bool isZombie;

	ScoreManager score;

	// Use this for initialization
	void Start () {
		if(transform.localPosition.x < 0){
			moving = Movement.Right;
		}else{
			moving = Movement.Left;
		}

		score = (ScoreManager)GameObject.FindGameObjectWithTag("background").GetComponent(typeof(ScoreManager));

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.localPosition += new Vector3( this.moving == Movement.Left? -speed:speed, 0,0);

		if (transform.localPosition.x < -10.01f && moving == Movement.Left){
			if (isZombie){
				score.Score -= 1;
			}
			Destroy (gameObject);
		}
		else if (transform.localPosition.x > 10.01f && moving == Movement.Right){
			if (isZombie){
				score.Score -= 1;
			}
			Destroy (gameObject);
		}
	}

	void OnMouseUp(){
		Destroy(gameObject);


		if(isZombie){
			score.Score+=2;
		}else{
			score.Score-=2;
		}
	}
}
