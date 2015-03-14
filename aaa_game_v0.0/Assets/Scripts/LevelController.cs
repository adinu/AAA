﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour {

	public GameObject setEngineObject;
	public int numCardsInSet;
	private  int numOfCardsSelected = 0;
	private SetEngine setEngine;
	private bool canPeakCard= true;
	GameObject[] cardsAddedToSet;

	public void addCard(GameObject i_card)
	{
		if (canPeakCard) {
		
			for(int i = 0; i < cardsAddedToSet.Length; i++){
				if (cardsAddedToSet[i] == null){
					cardsAddedToSet[i] = i_card;
					Debug.Log ("addCard");
					printCardsList();
					break;
				}
			}

			if(numCardsInSet == numOfCardsSelected)
			{
				if(setEngine.IsSet(cardsAddedToSet)){
					Debug.Log("****  SET FOUND  ****");
				}
			}
		}
	}

	public void printCardsList()
	{
		foreach (GameObject card in cardsAddedToSet) /*Search empty place and add card*/
		{
			if(card != null) {
				Debug.Log(( card.GetComponent<Card>().m_cardColor.ToString() )+
				          " / " + card.GetComponent<Card>().m_cardNumber.ToString() +
				          "\n" + card.GetComponent<Card>().m_cardFill.ToString() +
				          " / " + card.GetComponent<Card>().m_cardShape.ToString() );
			}
		}
		}

	public void increanentCardCount(){
				numOfCardsSelected++;
		}

	public void deccreanentCardCount(){
		numOfCardsSelected--;
	}

	public int getCardCount(){
		return numOfCardsSelected;
	}

	public bool canPickCard()
	{

		canPeakCard= numOfCardsSelected < numCardsInSet ?  true:  false; 
		return numOfCardsSelected < numCardsInSet ?  true:  false;
	}
	
	void Start () {
		cardsAddedToSet = new GameObject[numCardsInSet];
		setEngine = setEngineObject.GetComponent<SetEngine>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
