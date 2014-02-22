using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {
	public Texture background;
	public Texture start;
	public Texture exit;

	// Use this for initialization
	void Start () {
	
	}

	void OnGUI(){
		GUI.DrawTexture(new Rect(0,0, background.width/1.4f, background.height/2), background);
		GUI.DrawTexture(new Rect((Screen.width-start.width)/2, 50, start.width, start.height), start);
		GUI.DrawTexture(new Rect((Screen.width-exit.width)/2, 160, exit.width, exit.height), exit);
	}

	void OnMouseUp(){
		if(
			Input.mousePosition.x > (Screen.width-start.width)/2 &&
			Input.mousePosition.x < ((Screen.width-start.width)/2)+start.width &&
			Input.mousePosition.y > 50 &&
			Input.mousePosition.y < 50+start.height
		){
			Application.LoadLevel(1);
		}

		if(
			Input.mousePosition.x > (Screen.width-exit.width)/2 &&
			Input.mousePosition.x < ((Screen.width-exit.width)/2)+exit.width &&
			Input.mousePosition.y > 160 &&
			Input.mousePosition.y < 160+exit.height
			){
			Application.Quit();
		}
	}
}
