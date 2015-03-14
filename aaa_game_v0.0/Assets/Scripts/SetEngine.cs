using UnityEngine;
using System.Collections;

public class SetEngine : MonoBehaviour {
	
	void Start () {}
	void Update () {}

	public  bool IsShapeMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.m_cardShape == secondCard.m_cardShape && firstCard.m_cardShape == thirdCard.m_cardShape)
			||
				(firstCard.m_cardShape != secondCard.m_cardShape && firstCard.m_cardShape != thirdCard.m_cardShape &&
				 secondCard.m_cardShape != thirdCard.m_cardShape);
	}
	
	public  bool IsColorMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.m_cardColor == secondCard.m_cardColor && firstCard.m_cardColor == thirdCard.m_cardColor)
			||
				(firstCard.m_cardColor != secondCard.m_cardColor && firstCard.m_cardColor != thirdCard.m_cardColor &&
				 secondCard.m_cardColor != thirdCard.m_cardColor);
	}
	
	public  bool IsNumberMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.m_cardNumber== secondCard.m_cardNumber && firstCard.m_cardNumber == thirdCard.m_cardNumber)
			||
				(firstCard.m_cardNumber != secondCard.m_cardNumber && firstCard.m_cardNumber != thirdCard.m_cardNumber &&
				 secondCard.m_cardNumber != thirdCard.m_cardNumber);
	}
	
	public  bool IsShadingMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.m_cardFill == secondCard.m_cardFill && firstCard.m_cardFill == thirdCard.m_cardFill)
			||
				(firstCard.m_cardFill != secondCard.m_cardFill && firstCard.m_cardFill != thirdCard.m_cardFill &&
				 secondCard.m_cardFill != thirdCard.m_cardFill);
	}


	public bool IsSet (GameObject[] cardsAddedToSet){
		Card firstCard = cardsAddedToSet[0].GetComponent<Card>();
		Card secondCard = cardsAddedToSet[1].GetComponent<Card>();
		Card thirdCard= cardsAddedToSet[2].GetComponent<Card>();

		Debug.Log("IsSet called");

		bool shapeMatch = IsShapeMatch( firstCard, secondCard, thirdCard);
		Debug.Log("shapeMatch " + shapeMatch);
		bool colorMatch = IsColorMatch( firstCard,  secondCard,  thirdCard);
		Debug.Log("colorMatch " + colorMatch);
		bool numberMatch = IsNumberMatch( firstCard,  secondCard,  thirdCard);
		Debug.Log("numberMatch " + numberMatch);
		bool shadingMatch = IsShadingMatch( firstCard,  secondCard,  thirdCard);
		Debug.Log("shadingMatch " + shadingMatch);
		
		return shapeMatch && colorMatch && numberMatch && shadingMatch;
	}



//		Debug.Log(( card1.m_cardColor.ToString() )+
//		          " / " + card1.m_cardNumber.ToString() +
//		          "\n" + card1.m_cardFill.ToString() +
//		          " / " + card1.m_cardFill.ToString() );
//
//		Debug.Log(( card2.m_cardColor.ToString() )+
//		          " / " + card2.m_cardNumber.ToString() +
//		          "\n" + card2.m_cardFill.ToString() +
//		          " / " + card2.m_cardFill.ToString() );
//
//		Debug.Log(( card3.m_cardColor.ToString() )+
//		          " / " + card3.m_cardNumber.ToString() +
//		          "\n" + card3.m_cardFill.ToString() +
//		          " / " + card3.m_cardFill.ToString() );

		/* check color is all identical or all diffrent*/

}
