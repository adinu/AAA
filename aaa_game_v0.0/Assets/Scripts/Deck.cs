using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Deck : MonoBehaviour {

	int m_numOfCards = 0;
	Card [,] m_cardsArray =null;
	List<Card>  m_cardsList;


	Deck(List<Card> i_cardsList)
	{
		m_cardsArray = null;
		m_cardsList = i_cardsList; 
		m_numOfCards = i_cardsList.Count;
	}


	void buildDeck(){
		int height = 0;
		int width = 3;
		/*Build the array*/	switch(m_numOfCards)
		{
		case 3:
			m_cardsArray = new Card[0,width];
			break;
		case 6:
			m_cardsArray = new Card[2,width];
			break;
		case 9:
			m_cardsArray = new Card[3,width];
			break;
		case 12:
			m_cardsArray = new Card[4,width];
			break;

		default:
				break;

		}

		height = m_numOfCards/3;
		int pos = 0;

		/*Locte the cards*/
		for(int j = 0; j < height; j++)
		{
			for(int i = 0; i < width; i++)
			{
				if(pos < m_cardsList.Count)
				{
					m_cardsArray[j,i] = m_cardsList[pos];
					pos++;
				}
			}
		}
	}

	void createDeck(){

	}



	// Use this for initialization
	void Start () {
		createDeck ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
