using UnityEngine;
using System.Collections;

public class PieSpawner : MonoBehaviour {

	// The pie that spawns.
	public GameObject pie;

	// The time in between pie spawns.
	private float timeToWait;
	
	// The time that this play through started.
	private float startTime;
	
	// How far into this play through the player is.
	private float currentTime;




	// Use this for initialization
	void Start () {
		startTime = Time.time;
		StartCoroutine(TimedSpawn());
	}

	// CoRoutines are more efficient than putting this in Update()
	IEnumerator TimedSpawn(){
		while(true){ 
			//for (int i = 0; i < 20; i++){
				spawnPie ();
		//	}
			/* How long to wait before we send the next pie.  
			 * Time to wait decreases the longer the game is played.
			 */
			currentTime = Time.time - startTime;
			if (currentTime <= 6f){
				timeToWait = Random.Range(1, 5);
			}
			else if (currentTime > 6f && currentTime <= 12f){
				timeToWait = Random.Range(1, 4);
			}
			else if (currentTime > 12f && currentTime <= 18f){
				timeToWait = Random.Range(1, 3);
			}
			else if (currentTime > 30f && currentTime <= 40f){
				timeToWait = Random.Range(1, 2);
			}
			yield return new WaitForSeconds(timeToWait);
		}
	}
	
	// Update is called once per frame
	void Update () {

	}

	void spawnPie () {
		Vector3 spawnLocation = new Vector3(Random.Range(-3, 4), Random.Range(2f, -2f), 0);
		Instantiate(pie, spawnLocation, Quaternion.identity);
	}
}
