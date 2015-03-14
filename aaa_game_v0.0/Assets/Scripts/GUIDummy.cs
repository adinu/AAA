using UnityEngine;
using System.Collections;

public class GUIDummy : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {
		if (GUI.Button (new Rect (20, 120, 200, 30), "Add Score")) {
			Application.LoadLevel("scene_1.0");
		}
	

	}
}
