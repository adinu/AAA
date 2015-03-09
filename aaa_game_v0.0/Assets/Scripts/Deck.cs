using UnityEngine;
using System.Collections;


public class Deck : MonoBehaviour {

	int m_numOfCards = 0;
	Card [][] m_cardsArray;


	Deck()
	{
		m_numOfCards = 6;
		m_cardsArray = new Card[2][3];

	}


	void displayDeck(){


	}

	void createDeck(){
		Deck deck = new Deck ();

	}



	// Use this for initialization
	void Start () {
		createDeck ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
