using UnityEngine;
using System.Collections;

public class CardDrawer : MonoBehaviour {


	Vector2 m_topLeft = new Vector2(1,2);
	Vector2 m_bottomRight = new Vector2(Screen.height,Screen.width);
	GameObject dect =   GameObject.Find("Deck");

	Deck deck;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void calculateLayout()
	{

	}

}
