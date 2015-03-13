using UnityEngine;
using System.Collections;

public enum Enum_Card_number{
	Enum_Card_number_one = 1,
	Enum_Card_number_two = 2,
	Enum_Card_number_three = 3,
	//Enum_Card_number_four = 4,
	
	Enum_Card_number_SIZE = 4
};

public enum Enum_Card_shape{
	Enum_Card_shape_bamba = 1,
	Enum_Card_shape_peanut = 2,
	Enum_Card_shape_diamond = 3,
	//Enum_Card_shape_blackHeart = 4,
	
	Enum_Card_shape_SIZE = 4
};

public enum Enum_Card_fill{
	Enum_Card_fill_noFill = 1,
	Enum_Card_fill_fullFill = 2,
	Enum_Card_fill_stripe = 3,
	
	Enum_Card_type_SIZE = 4	
};

public enum Enum_Card_color {
	Enum_Card_color_green = 1,
	Enum_Card_color_purple = 2,
	Enum_Card_color_red = 3,
	//Enum_Card_color_yellow = 4,
	
	Enum_Card_color_SIZE = 4
};

public class Card : MonoBehaviour  {

	public Enum_Card_number m_cardNumber;
	public Enum_Card_shape m_cardShape;
	public Enum_Card_color m_cardColor;
	public Enum_Card_fill m_cardFill;

	public GameObject levelController;
	private bool m_isCardSelected = false;
	private SpriteRenderer sr;
	
	//seters + getters
	public Enum_Card_number cardNumber{ get; set; }		
	public Enum_Card_shape cardShape{ get; set; }
	public Enum_Card_color cardColor{ get; set; }
	public Enum_Card_fill cardFill{ get; set; }


	void Start ()	{
		 sr = gameObject.GetComponent<SpriteRenderer>(); 
	}
		
	void Update()
	{
		if (Input.GetMouseButtonDown(0))
		{
			Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			Vector2 touchPos = new Vector2(wp.x, wp.y);
			if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
			{
				GameObject  card = GetComponent<Collider2D>().gameObject;
				LevelController[] controller = levelController.GetComponents<LevelController> ();
				if (m_isCardSelected) {
						controller [0].deccreanentCardCount ();
						m_isCardSelected = false;
						sr.color = new Color (1f, 1f, 1f, 1f);						
				} else if (controller [0].canPickCard ()) { //check we don't choose more than max cards for set
						controller [0].increanentCardCount ();
						RayCast();
						 controller [0].addCard(card);

						m_isCardSelected = true;
						sr.color = new Color (0.5f, 0.5f, 0.5f, 1f);
				}
				
			}
		}
	}


	public string cardToString(Card i_card){
			
		string res = "color:" + i_card.cardColor.ToString () + 
						"number:" + i_card.cardNumber.ToString () + 
						"shape:" + i_card.cardShape.ToString () + 
						"type:" + i_card.cardFill.ToString ();

		return res;
		}

	//void OnMouseDown (){}
		
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



