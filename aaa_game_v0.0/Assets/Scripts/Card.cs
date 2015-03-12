using UnityEngine;
using System.Collections;

public enum Enum_Card_number{
	Enum_Card_number_one = 1,
	Enum_Card_number_two = 2,
	Enum_Card_number_three = 3,
	Enum_Card_number_four = 4,
	
	Enum_Card_number_SIZE = 5
};

public enum Enum_Card_shape{
	Enum_Card_shape_heart = 1,
	Enum_Card_shape_diamond = 2,
	Enum_Card_shape_colver = 3,
	Enum_Card_shape_blackHeart = 4,
	
	Enum_Card_shape_SIZE = 5	
};

public enum Enum_Card_type{
	Enum_Card_type_regular = 1,
	Enum_Card_type_bonus = 2,
	Enum_Card_type_penalty = 3,
	
	Enum_Card_type_SIZE = 4	
};

public enum Enum_Card_color {
	Enum_Card_color_blue = 1,
	Enum_Card_color_red = 2,
	Enum_Card_color_green = 3,
	Enum_Card_color_yellow = 4,
	
	Enum_Card_color_SIZE = 5	
};

public class Card : MonoBehaviour  {
	
	public Enum_Card_number m_cardNumber;
	public Enum_Card_shape m_cardShape;
	public Enum_Card_color m_cardColor;
	public Enum_Card_type m_cardType;

	public GameObject levelController;
	private bool m_isCardSelected = false;
	private SpriteRenderer sr;
	
	public Enum_Card_number cardNumber{ get; set; }		
	public Enum_Card_shape cardShape{ get; set; }
	public Enum_Card_color cardColor{ get; set; }
	public Enum_Card_type cardType{ get; set; }
	
//	public Enum_Card_number getCardValue(){return m_cardNumber;}
//	public Enum_Card_shape getCardShape(){return m_cardShape;}
//	public Enum_Card_color getCardColor(){return m_cardColor;}
//	public Enum_Card_type getCardType(){return m_cardType;}
//	
//	public void setCardValue(Enum_Card_number i_number){ m_cardNumber = i_number;}
//	public void setCardShape(Enum_Card_shape i_shape){ m_cardShape = i_shape;}
//	public void setCardColor(Enum_Card_color i_color){ m_cardColor = i_color;}
//	public void setCardType(Enum_Card_type i_type){ m_cardType = i_type;}
//	

	
		// Use this for initialization
		void Start ()	{
			 sr = gameObject.GetComponent<SpriteRenderer>(); 
		Debug.Log("start card");
		}
		
		// Update is called once per frame
		void Update (){



	}
	
	void OnMouseDown ()
	{
		LevelController[] controller = levelController.GetComponents<LevelController> ();
		Debug.Log("OnMouseDown");

		if (m_isCardSelected) 
		{
			controller [0].deccreanentCardCount();
			m_isCardSelected = false;
			sr.color = new Color(1f, 1f, 1f, 1f);
			Debug.Log("unselect");
		} 
		else if(controller [0].canPeakCard ()) //check we don't choose more than max cards for set
		{
			controller [0].increanentCardCount();
			//controller [0].addCard();
			m_isCardSelected = true;
			sr.color = new Color(0.5f, 0.5f, 0.5f, 1f);
			Debug.Log("select");
		}
	}   


//	Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//	RaycastHit hit;
//	// Casts the ray and get the first game object hit
//	Physics.Raycast(ray, out hit);
//	Debug.Log("This hit at " + hit.point );

}



//using UnityEngine;
//using System.Collections;
//
//public enum Enum_Card_number{
//	Enum_Card_number_one = 1,
//	Enum_Card_number_two = 2,
//	Enum_Card_number_three = 3,
//	Enum_Card_number_four = 4,
//	
//	Enum_Card_number_SIZE = 5
//};
//
//public enum Enum_Card_shape{
//	Enum_Card_shape_heart = 1,
//	Enum_Card_shape_diamond = 2,
//	Enum_Card_shape_colver = 3,
//	Enum_Card_shape_blackHeart = 4,
//	
//	Enum_Card_shape_SIZE = 5	
//};
//
//public enum Enum_Card_type{
//	Enum_Card_type_regular = 1,
//	Enum_Card_type_bonus = 2,
//	Enum_Card_type_penalty = 3,
//	
//	Enum_Card_type_SIZE = 4	
//};
//
//public enum Enum_Card_color {
//	Enum_Card_color_blue = 1,
//	Enum_Card_color_red = 2,
//	Enum_Card_color_green = 3,
//	Enum_Card_color_yellow = 4,
//	
//	Enum_Card_color_SIZE = 5	
//};
//
//public class Card : MonoBehaviour  {
//	
//	private Enum_Card_number m_cardNumber;
//	private Enum_Card_shape m_cardShape;
//	private Enum_Card_color m_cardColor;
//	private Enum_Card_type m_cardType;
//	
//	public Enum_Card_number cardNumber{
//		get{return m_cardNumber;}
//		set{ m_cardNumber = value;}
//	}
//	public Enum_Card_shape cardShape{
//		get{return m_cardShape;}
//		set{ m_cardShape = value;}
//	}
//	public Enum_Card_color cardColor{
//		get{return m_cardColor;}
//		set{ m_cardColor = value;}
//	}
//	public Enum_Card_type cardType{
//		get{return m_cardType;}
//		set{ m_cardType = value;}
//	}
//	
//	public bool m_isCardSelected = false;
//	public SpriteRenderer sr = null;
//	
//	public Card( Enum_Card_number i_cardValue,
//	            Enum_Card_shape i_cardShape,
//	            Enum_Card_color i_cardColor,
//	            Enum_Card_type i_cardType)
//	{
//		setCardValue (i_cardValue);
//		setCardShape(i_cardShape);
//		setCardColor(i_cardColor);
//		setCardType(i_cardType);
//		
//		
//	}
//	
//	public Enum_Card_number getCardValue(){return m_cardNumber;}
//	public Enum_Card_shape getCardShape(){return m_cardShape;}
//	public Enum_Card_color getCardColor(){return m_cardColor;}
//	public Enum_Card_type getCardType(){return m_cardType;}
//	
//	public void setCardValue(Enum_Card_number i_number){ m_cardNumber = i_number;}
//	public void setCardShape(Enum_Card_shape i_shape){ m_cardShape = i_shape;}
//	public void setCardColor(Enum_Card_color i_color){ m_cardColor = i_color;}
//	public void setCardType(Enum_Card_type i_type){ m_cardType = i_type;}
//	
//	
//	
//	
//	
//	//	// Use this for initialization
//	//	void Start ()	{
//	//		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>(); 
//	//	}
//	//	
//	//	// Update is called once per frame
//	//	void Update (){}
//	//
//	//	void OnMouseDown(){
//	//		SpriteRenderer sr = gameObject.GetComponent<SpriteRenderer>(); 
//	//		if (m_isCardSelected) {
//	//			m_isCardSelected = false;
//	//			sr.color = new Color(1f, 1f, 1f, 1f);
//	//		} else {
//	//			m_isCardSelected = true;
//	//			sr.color = new Color(0.5f, 0.5f, 0.5f, 1f);
//	//		}
//	//	}   
//	
//	
//	
//}
