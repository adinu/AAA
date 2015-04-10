using UnityEngine;
using System.Collections;

public class CardsSpawner : MonoBehaviour
{
    public int numOfCards;

    // range limiters
    public float minY;
    public float minX;
    public float maxY;
    public float maxX;

    //
    private static Object prefab;
    private static Sprite[] SpriteArray;
    private int[] shape = { 0, 1, 2, 3 };
    private int[] color = { 0, 1, 2, 3 };
    private int[] fill = { 0, 1, 2, 3 };

    void Start()
    {
        prefab = Resources.Load("Prefabs/Card");
        if (prefab == null) {
            Debug.Log("null prefb");
        }
        SpriteArray = Resources.LoadAll<Sprite>("Art/cards");

        for (int i = 0; i < numOfCards; i++)
        {
              Create();
        }       
    }

    void Update()
    {

    }

    public void Create()
    {      
        GameObject newCard = 
            Instantiate(prefab, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity) as GameObject;
        SpriteRenderer sr = newCard.GetComponent<SpriteRenderer>();
        int cardIndex = (int) Random.Range(0,SpriteArray.Length);
        sr.sprite = SpriteArray[cardIndex];
        Card card = newCard.GetComponent<Card>();
      setCardAttributes( card, sr.sprite.name);

    }

    public static void setCardAttributes(Card card, string cardName)  //0 - color   1- shape  2-fill
    {
    
        Card cardScript = card.GetComponent <Card> ();
        cardScript.cardNumber = 0;
     
        switch (cardName[0])
        { //color
            case '1':
                cardScript.cardColor = Enum_Card_color.Enum_Card_color_red;
                break;
            case '2':
                cardScript.cardColor = Enum_Card_color.Enum_Card_color_blue;
                break;
            case '3':
                cardScript.cardColor = Enum_Card_color.Enum_Card_color_yellow;
                break;
            default:
                Debug.Log("error at setCardAttributes ");
                break;
        }

        switch (cardName[1])
        { //shape
            case '1':
                cardScript.cardShape = Enum_Card_shape.Enum_Card_shape_circle;
                break;
            case '2':
                cardScript.cardShape = Enum_Card_shape.Enum_Card_shape_square;
                break;
            case '3':
                cardScript.cardShape = Enum_Card_shape.Enum_Card_shape_triangle;
                break;
            default:
                Debug.Log("error at setCardAttributes ");
                break;
        }

        switch (cardName[2])
        { //fill
            case '1':
                cardScript.cardFill = Enum_Card_fill.Enum_Card_fill_noFill;
                break;
            case '2':
                cardScript.cardFill = Enum_Card_fill.Enum_Card_fill_fullFill;
                break;
            case '3':
                cardScript.cardFill = Enum_Card_fill.Enum_Card_fill_stripe;
                break;
            default:
                Debug.Log("error at setCardAttributes ");
                break;
        }


       


    }
}