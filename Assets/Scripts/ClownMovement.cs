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

	// Use this for initialization
	void Start () {
		if(transform.localPosition.x < 0){
			moving = Movement.Right;
		}else{
			moving = Movement.Left;
		}

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		transform.localPosition += new Vector3( this.moving == Movement.Left? -speed:speed, 0,0);
	}

	void OnMouseUp(){
		Destroy(gameObject);
		ScoreManager score = (ScoreManager)GameObject.FindGameObjectWithTag("background").GetComponent(typeof(ScoreManager));

		if(isZombie){
			score.Score+=2;
		}else{
			score.Score-=2;
		}
	}
}
