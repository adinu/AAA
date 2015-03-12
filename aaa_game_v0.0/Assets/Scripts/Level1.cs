using UnityEngine;
using System.Collections;

public class Level1 : MonoBehaviour {

	private int numOfCardsSelected = 0;


	public void increanentCardCount(){
				numOfCardsSelected++;
		}

	public void deccreanentCardCount(){
		numOfCardsSelected--;
	}

	public int getCardCount(){
		return numOfCardsSelected;
	}

	// Use this for initialization
	void Start () {
		Debug.Log("start");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
