using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelManager : MonoBehaviour {
	
	public float spacingBewtweenCards = 0.1f;
	public GameObject cardPsrefab;
	private int gridX=0;
	private int gridY=0;
	private List<Card> m_cards;
	
	// Use this for initialization
	void Start () 
	{
		m_cards = new List<Card> ();
//		m_cards .Add (new Card (Enum_Card_number.Enum_Card_number_one,
//		                        Enum_Card_shape.Enum_Card_shape_heart,
//		                        Enum_Card_color.Enum_Card_color_blue,
//		                        Enum_Card_type.Enum_Card_type_regular));
//		
//		m_cards.Add (new Card (Enum_Card_number.Enum_Card_number_one,
//		                       Enum_Card_shape.Enum_Card_shape_heart,
//		                       Enum_Card_color.Enum_Card_color_blue,
//		                       Enum_Card_type.Enum_Card_type_regular));
//		
//		m_cards.Add (new Card (Enum_Card_number.Enum_Card_number_one,
//		                       Enum_Card_shape.Enum_Card_shape_heart,
//		                       Enum_Card_color.Enum_Card_color_blue,
//		                       Enum_Card_type.Enum_Card_type_regular));
		
		
		Deck deck = new Deck (m_cards);
		gridX = 3;
		gridY = deck.height;
		drawDeck ();
	}
	
	void drawDeck(){
		int screenWidth = -Screen.width / 2;
		int screenHeight = -Screen.height / 2;
		int cardPos = 0;
		
		for (int x = 0; x < gridX; x++) {
			for (int y = 0; y < gridY; y++) {
				Vector2 pos = new Vector2 (screenHeight, screenWidth) * spacingBewtweenCards; //calc pos on screen
				GameObject curCard = (GameObject) Instantiate(cardPsrefab, pos, Quaternion.identity); //create prefab
				//	Card cur = m_cards[cardPos];
				//	curCard.GetComponent<Card>().m_cardColor = cur.getCardColor();//set cards
				cardPos++;
				screenHeight++;
				screenWidth++;
				
			}
		}
	}
	
	
	// Update is called once per frame
	void Update () {
		
	}
}