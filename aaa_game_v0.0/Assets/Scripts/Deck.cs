using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class Deck  {
	
	List<Card>   m_cardsList;
	private int  m_height=0;
	private int   m_width=3;
			
	public int numOfCards { get; set; }
	public int height { get; set; }

	public Deck(List<Card> i_cardsList) {
		m_cardsList = i_cardsList; 
		numOfCards = i_cardsList.Count;
		m_height = i_cardsList.Count / 3;
	}
}
