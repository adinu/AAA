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
	
	private static int counter = 0;
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
		 //Debug.Log("start card");
	}
		
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (collider2D == Physics2D.OverlapPoint(touchPos))
			{
				GameObject  card = collider2D.gameObject;
				counter++;
				Debug.Log(counter  + "    card.GetType: " + card.GetType().ToString());

				LevelController[] controller = levelController.GetComponents<LevelController> ();
				if (m_isCardSelected) {
						controller [0].deccreanentCardCount ();
						m_isCardSelected = false;
						sr.color = new Color (1f, 1f, 1f, 1f);
						//Debug.Log ("unselect");
				} else if (controller [0].canPickCard ()) { //check we don't choose more than max cards for set
						controller [0].increanentCardCount ();
						RayCast();
						//controller [0].addCard();
						m_isCardSelected = true;
						sr.color = new Color (0.5f, 0.5f, 0.5f, 1f);
						//Debug.Log ("select");
				}
				
			}
		}
	}
	
	void OnMouseDown ()
	{
//				LevelController[] controller = levelController.GetComponents<LevelController> ();
//				Debug.Log ("OnMouseDown");
//
//				if (m_isCardSelected) {
//						controller [0].deccreanentCardCount ();
//						m_isCardSelected = false;
//						sr.color = new Color (1f, 1f, 1f, 1f);
//						Debug.Log ("unselect");
//				} else if (controller [0].canPeakCard ()) { //check we don't choose more than max cards for set
//						controller [0].increanentCardCount ();
//						RayCast();
//						//controller [0].addCard();
//						m_isCardSelected = true;
//						sr.color = new Color (0.5f, 0.5f, 0.5f, 1f);
//						Debug.Log ("select");
//				}

		}

	public void RayCast(){
//		RaycastHit hit;
//
//		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
//
//		Debug.Log ("ray: " + ray.ToString());
//		Debug.Log ("hit?" + Physics.Raycast (ray, out hit));
//
//		if (Physics.Raycast(ray, out hit)){
//			Debug.Log ("type" + hit.GetType());
//
//
//			if (hit.collider != null){
//				//hit.collider.enabled = false;
//				hit.collider.gameObject.transform.localScale+= new Vector3(3.1F, 0, 0);
//				Debug.Log ("RayCast function");
//			}
//		}
//		

	}
}   



