using UnityEngine;
using System.Collections;

public class SetEngine : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	bool IsSet (Card i_card1, Card i_card2, Card i_card3) {

		/* check color is all identical or all diffrent*/
		if ((i_card1.getCardColor() == i_card2.getCardColor() && i_card2.getCardColor() == i_card3.getCardColor()) ||
		    i_card1.getCardColor() != i_card2.getCardColor() &&
		    i_card2.getCardColor() != i_card3.getCardColor() &&
		    i_card1.getCardColor() != i_card3.getCardColor()){
			/*Do nothing*/
		}
			else {
			return false;
		}

		/* check Shape is all identical or all diffrent*/
		if ((i_card1.getCardShape() == i_card2.getCardShape() && i_card2.getCardShape() == i_card3.getCardShape()) ||
		    i_card1.getCardShape() != i_card2.getCardShape() &&
		    i_card2.getCardShape() != i_card3.getCardShape() &&
		    i_card1.getCardShape() != i_card3.getCardShape()){
			/*Do nothing*/
		}
		else {
			return false;
		}


		/* check Value is all identical or all diffrent*/
		if ((i_card1.getCardValue() == i_card2.getCardValue() && i_card2.getCardValue() == i_card3.getCardValue()) ||
		    i_card1.getCardValue() != i_card2.getCardValue() &&
		    i_card2.getCardValue() != i_card3.getCardValue() &&
		    i_card1.getCardValue() != i_card3.getCardValue()){
			/*Do nothing*/
		}
		else {
			return false;
		}

		/* check Type is all identical or all diffrent*/
		if ((i_card1.getCardType() == i_card2.getCardType() && i_card2.getCardType() == i_card3.getCardType()) ||
		    i_card1.getCardType() != i_card2.getCardType() &&
		    i_card2.getCardType() != i_card3.getCardType() &&
		    i_card1.getCardType() != i_card3.getCardType()){
			/*Do nothing*/
		}
		else {
			return false;
		}



		return true;
	}
}
