using UnityEngine;
using System.Collections;

public class TimeTicker : MonoBehaviour {

	void Start () {
		StartCoroutine(MoveSeconds());
	}
	
	// Rotates the seconds hand around the clock face.
	IEnumerator MoveSeconds(){
		while(true){
			transform.Rotate(Vector3.forward, -6f);
			Debug.Log (transform.localRotation.eulerAngles);
			if (transform.localRotation.eulerAngles.z <= 0){
				if(Application.loadedLevel == 1){
					Application.LoadLevel (2);
				}else{
					Application.LoadLevel(0);
				}
				//yield return new WaitForSeconds(200f);
			}

			yield return new WaitForSeconds(0.5f);
		}
	}
}
