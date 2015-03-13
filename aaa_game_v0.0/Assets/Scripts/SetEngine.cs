using UnityEngine;
using System.Collections;

public class SetEngine : MonoBehaviour {

	// Use this for initialization
	void Start () {}
	
	// Update is called once per frame
	void Update () {}
	


	public bool IsSet (GameObject[] cardsAddedToSet){
		Card card1 = cardsAddedToSet[0].GetComponent<Card>();
		Card card2 = cardsAddedToSet[1].GetComponent<Card>();
		Card card3 = cardsAddedToSet[2].GetComponent<Card>();

		Debug.Log("IsSet");

		/* check color is all identical or all diffrent*/
		if ((card1.cardColor == card2.cardColor && card2.cardColor == card3.cardColor) ||
		    (card1.cardColor != card2.cardColor &&
		    card2.cardColor != card3.cardColor &&
		    card1.cardColor != card3.cardColor)){
			Debug.Log("pass color test");
			/*Do nothing*/
		}
			else {
			return false;
		}

		/* check Shape is all identical or all diffrent*/
		if ((card1.cardShape == card2.cardShape && card2.cardShape == card3.cardShape) ||
		    (card1.cardShape != card2.cardShape &&
		    card2.cardShape != card3.cardShape &&
		    card1.cardShape != card3.cardShape)){
			Debug.Log("pass shape test");
			/*Do nothing*/
		}
		else {
			return false;
		}


		/* check Value is all identical or all diffrent*/
		if ((card1.cardNumber == card2.cardNumber && card2.cardNumber == card3.cardNumber) ||
		    (card1.cardNumber != card2.cardNumber &&
		    card2.cardNumber != card3.cardNumber &&
		    card1.cardNumber != card3.cardNumber)){
			Debug.Log("pass number test");
			/*Do nothing*/
		}
		else {
			return false;
		}

		/* check Type is all identical or all diffrent*/
		if ((card1.cardType == card2.cardType && card2.cardType == card3.cardType) ||
		    (card1.cardType != card2.cardType &&
		    card2.cardType != card3.cardType &&
		    card1.cardType != card3.cardType)){
			Debug.Log("pass fill test");
			/*Do nothing*/
		}
		else {
			return false;
		}



		return true;
	}
}
