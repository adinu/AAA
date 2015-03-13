using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelController : MonoBehaviour {

	public int numCardsInSet;
	private  int numOfCardsSelected = 0;
	List<Card> cardsAdded;


	public void addCard(Card i_card)
	{
		if (canPickCard ()) {
			foreach (Card card in cardsAdded) /*Search empty place and add card*/
			{
				if(card == null) {
					cardsAdded.Add(i_card);
					break;
				}
			}
		}
	}

	public void printCardsList()
	{
		foreach (Card card in cardsAdded) /*Search empty place and add card*/
		{
			if(card != null) {
				Debug.Log("new card:");
				Debug.Log(card.cardColor.ToString() + " " + card.m_cardNumber.ToString() +" " + card.m_cardType.ToString() + " " + card.m_cardShape.ToString() );
				break;
			}
		}
		}

	public void increanentCardCount(){
				numOfCardsSelected++;
		//TODO: check if count = numCardsInSet -> call isSetMethod 
		}

	public void deccreanentCardCount(){
		numOfCardsSelected--;
	}

	public int getCardCount(){
		return numOfCardsSelected;
	}

	public bool canPickCard()
	{
		return numOfCardsSelected < numCardsInSet ?  true:  false;
	}

	// Use this for initialization
	void Start () {
		cardsAdded = new List<Card>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
