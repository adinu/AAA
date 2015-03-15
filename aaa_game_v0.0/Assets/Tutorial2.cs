using UnityEngine;
using System.Collections;

public class Tutorial2 : MonoBehaviour {

	public int TimeInSecondsBeforNExtSceneStarts;
	// Use this for initialization
	void Start () {
		Invoke("suspendNextScene", TimeInSecondsBeforNExtSceneStarts);
	}
	
	
	void suspendNextScene()
	{
		
		Application.LoadLevel(2);
	} 
	
	// Update is called once per frame
	void Update () {
		
	}
}
