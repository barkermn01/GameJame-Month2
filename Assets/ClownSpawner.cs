using UnityEngine;
using System.Collections;

public class ClownSpawner : MonoBehaviour {
	public GameObject clown;
	public GameObject zombieClown;

	public float spawnTime = 4;
	private float timeCount = 0;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if(timeCount > spawnTime){
			timeCount = 0.0f;
			bool startLeft = (Random.Range(0,1) == 0)? false:true;
			Vector3 StartLoc = new Vector3(
				(Random.Range(0,1) == 0)? -10.0f:10.0f,
				Random.Range(1.4f, 3.9f),
				0
			);
			Instantiate(clown, StartLoc, Quaternion.identity);
		}
	}
}
