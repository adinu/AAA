using UnityEngine;
using System.Collections;

public class Tut1Script : MonoBehaviour {

	public int TimeInSecondsBeforNExtSceneStarts;
	// Use this for initialization
	void Start () {
		Invoke("suspendNextScene", TimeInSecondsBeforNExtSceneStarts);
	}


	void suspendNextScene()
	{
		
		Application.LoadLevel(3);
	} 

	// Update is called once per frame
	void Update () {
	
	}
}
