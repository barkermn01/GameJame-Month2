using UnityEngine;
using System.Collections;

public class ClownSpawner : MonoBehaviour {
	public GameObject clown;
	public GameObject zombieClown;
	
	public float spawnTime = 2;
	private float timeCount = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timeCount += Time.deltaTime;
		if(timeCount > spawnTime){
			if(spawnTime > 0.2f){spawnTime -= 0.1f;}
			timeCount = 0.0f;
			bool startLeft = (Random.Range(0,2) == 0)? false:true;
			Vector3 StartLoc = new Vector3(
				(Random.Range(1,2) == 0)? -10.0f:10.0f,
				Random.Range(-3.9f, 1.4f),
				0
				);
			Instantiate(clown, StartLoc, Quaternion.identity);
		}
	}
}
