using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	void OnGUI()
	{

		if (GUI.Button (new Rect (10, 10, 150, 100), "Play")) 
		{
			Application.LoadLevel(0);
		}
		if (GUI.Button (new Rect (10, 150, 150, 100), "Quit")) 
		{
			Application.Quit();
		}
	}
}
