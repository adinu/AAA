using UnityEngine;
using System.Collections;

public class GuiBtnsManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playLevel1()
	{

		Application.LoadLevel("Level1");
	}

	// Quit the game
	public void Quit()
	{
		Application.Quit();
	}



}
