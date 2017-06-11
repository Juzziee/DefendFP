using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair : MonoBehaviour {

	public Texture2D tex_crosshair;

	void OnGUI(){
		drawCrosshair ();
	}

	void drawCrosshair(){
		GUI.DrawTexture (new Rect(Screen.width / 2 - 12.5f, Screen.height / 2 - 25f, 25, 25), tex_crosshair);
	}
}
