using UnityEngine;
using System.Collections;

public class CrossHairMovement : MonoBehaviour {
	public Texture crosshair;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(
			Input.mousePosition.x - (crosshair.width/2), 
			((0-Input.mousePosition.y)+Screen.height) - (crosshair.height/2),
			crosshair.width,
			crosshair.height
			), crosshair);
	}
}
