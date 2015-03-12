using UnityEngine;
using System.Collections;

public class SetEngine : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}
	


	public bool IsSet (Card i_card1, Card i_card2, Card i_card3) {

		/* check color is all identical or all diffrent*/
		if ((i_card1.cardColor == i_card2.cardColor && i_card2.cardColor == i_card3.cardColor) ||
		    i_card1.cardColor != i_card2.cardColor &&
		    i_card2.cardColor != i_card3.cardColor &&
		    i_card1.cardColor != i_card3.cardColor){
			/*Do nothing*/
		}
			else {
			return false;
		}

		/* check Shape is all identical or all diffrent*/
		if ((i_card1.cardShape == i_card2.cardShape && i_card2.cardShape == i_card3.cardShape) ||
		    i_card1.cardShape != i_card2.cardShape &&
		    i_card2.cardShape != i_card3.cardShape &&
		    i_card1.cardShape != i_card3.cardShape){
			/*Do nothing*/
		}
		else {
			return false;
		}


		/* check Value is all identical or all diffrent*/
		if ((i_card1.cardNumber == i_card2.cardNumber && i_card2.cardNumber == i_card3.cardNumber) ||
		    i_card1.cardNumber != i_card2.cardNumber &&
		    i_card2.cardNumber != i_card3.cardNumber &&
		    i_card1.cardNumber != i_card3.cardNumber){
			/*Do nothing*/
		}
		else {
			return false;
		}

		/* check Type is all identical or all diffrent*/
		if ((i_card1.cardType == i_card2.cardType && i_card2.cardType == i_card3.cardType) ||
		    i_card1.cardType != i_card2.cardType &&
		    i_card2.cardType != i_card3.cardType &&
		    i_card1.cardType != i_card3.cardType){
			/*Do nothing*/
		}
		else {
			return false;
		}



		return true;
	}
}
