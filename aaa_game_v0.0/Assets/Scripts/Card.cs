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
	Enum_Card_shape_circle = 1,
	Enum_Card_shape_triangle = 2,
	Enum_Card_shape_square = 3,
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
	Enum_Card_color_blue = 1,
	Enum_Card_color_yellow = 2,
	Enum_Card_color_red = 3,
	//Enum_Card_color_yellow = 4,
	
	Enum_Card_color_SIZE = 4
};

public class Card : MonoBehaviour {

    private Enum_Card_number m_cardNumber;
    private Enum_Card_shape m_cardShape;
    private Enum_Card_color m_cardColor;
    private Enum_Card_fill m_cardFill;

    private GameObject levelController;
    private bool m_isCardSelected = false;
    private SpriteRenderer sr;

    //seters + getters
    public Enum_Card_number cardNumber { get; set; }
    public Enum_Card_shape cardShape { get; set; }
    public Enum_Card_color cardColor { get; set; }
    public Enum_Card_fill cardFill { get; set; }

    public int debugView_cardNumber { get { return (int)cardNumber; } }
    public int debugView_cardShape { get { return (int)cardShape; } }
    void Start() {
        levelController = GameObject.FindGameObjectWithTag("LevelController");
        sr = gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
		{
		}*/
    }


    public string cardToString(Card i_card) {

        string res = "color:" + i_card.cardColor.ToString() +
                        "number:" + i_card.cardNumber.ToString() +
                        "shape:" + i_card.cardShape.ToString() +
                        "type:" + i_card.cardFill.ToString();

        return res;
    }

    void OnMouseDown() {
        Debug.Log(this.cardColor);
        Debug.Log(this.cardFill);
        Debug.Log(this.cardShape);
        Debug.Log(this.cardNumber);
        Vector3 wp = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 touchPos = new Vector2(wp.x, wp.y);
        if (GetComponent<Collider2D>() == Physics2D.OverlapPoint(touchPos))
        {
            GameObject card = GetComponent<Collider2D>().gameObject;
            LevelController[] controller = levelController.GetComponents<LevelController>();
            //Debug.Log(controller [0].canPickCard () + "controller can pick");
            if (m_isCardSelected) {
                controller[0].deccreanentCardCount();
                m_isCardSelected = false;
                controller[0].removeCard(card);
                sr.color = new Color(1f, 1f, 1f, 1f);
            } else if (controller[0].canPickCard()) { //check we don't choose more than max cards for set			
                controller[0].addCard(card);
                //controller[0].increanentCardCount();
                m_isCardSelected = true;
                sr.color = new Color(0.5f, 0.5f, 0.5f, 1f);
            }

        }
    }
}

  



