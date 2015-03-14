using UnityEngine;
using System.Collections;

public class SetEngine : MonoBehaviour {
	
	void Start () {}
	void Update () {}

	public  bool IsShapeMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.cardShape == secondCard.cardShape && firstCard.cardShape == thirdCard.cardShape)
			||
				(firstCard.cardShape != secondCard.cardShape && firstCard.cardShape != thirdCard.cardShape &&
				 secondCard.cardShape != thirdCard.cardShape);
	}
	
	public  bool IsColorMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.cardColor == secondCard.cardColor && firstCard.cardColor == thirdCard.cardColor)
			||
				(firstCard.cardColor != secondCard.cardColor && firstCard.cardColor != thirdCard.cardColor &&
				 secondCard.cardColor != thirdCard.cardColor);
	}
	
	public  bool IsNumberMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.cardNumber== secondCard.cardNumber && firstCard.cardNumber == thirdCard.cardNumber)
			||
				(firstCard.cardNumber != secondCard.cardNumber && firstCard.cardNumber != thirdCard.cardNumber &&
				 secondCard.cardNumber != thirdCard.cardNumber);
	}
	
	public  bool IsShadingMatch(Card firstCard, Card secondCard, Card thirdCard)
	{
		return (firstCard.cardFill == secondCard.cardFill && firstCard.cardFill == thirdCard.cardFill)
			||
				(firstCard.cardFill != secondCard.cardFill && firstCard.cardFill != thirdCard.cardFill &&
				 secondCard.cardFill != thirdCard.cardFill);
	}


	public bool IsSet (GameObject[] cardsAddedToSet){
		Card firstCard = cardsAddedToSet[0].GetComponent<Card>();
		Card secondCard = cardsAddedToSet[1].GetComponent<Card>();
		Card thirdCard= cardsAddedToSet[2].GetComponent<Card>();
		Debug.Log("IsSet called");

		bool shapeMatch = IsShapeMatch( firstCard, secondCard, thirdCard);
		bool colorMatch = IsColorMatch( firstCard,  secondCard,  thirdCard);
		bool numberMatch = IsNumberMatch( firstCard,  secondCard,  thirdCard);
		bool shadingMatch = IsShadingMatch( firstCard,  secondCard,  thirdCard);
		
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
