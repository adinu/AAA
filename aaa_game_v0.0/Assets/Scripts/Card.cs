﻿using UnityEngine;
using System.Collections;

enum Enum_Card_number{
	Enum_Card_number_one = 1,
	Enum_Card_number_two = 2,
	Enum_Card_number_three = 3,
	Enum_Card_number_four = 4,

	Enum_Card_number_SIZE = 5

};

enum Enum_Card_shape{
	Enum_Card_shape_heart = 1,
	Enum_Card_shape_diamond = 2,
	Enum_Card_shape_colver = 3,
	Enum_Card_shape_blackHeart = 4,
	
	Enum_Card_shape_SIZE = 5
	
};


enum Enum_Card_type{
	Enum_Card_type_regular = 1,
	Enum_Card_type_bonus = 2,
	Enum_Card_type_penalty = 3,
	
	Enum_Card_type_SIZE = 4	
};

enum Enum_Card_color {
	Enum_Card_color_blue = 1,
	Enum_Card_color_red = 2,
	Enum_Card_color_green = 3,
	Enum_Card_color_yellow = 4,
	
	Enum_Card_color_SIZE = 5	
};

public class Card  {

	private Enum_Card_number m_cardNumber;
	private Enum_Card_shape m_cardShape;
	private Enum_Card_color m_cardColor;
	private Enum_Card_type m_cardType;

	 Card( Enum_Card_number i_cardValue,
	             Enum_Card_shape i_cardShape,
	             Enum_Card_color i_cardColor,
	             Enum_Card_type i_cardType)
	{
		setCardValue (i_cardValue);
		setCardShape(i_cardShape);
		setCardColor(i_cardColor);
		setCardType(i_cardType);
	}

	 Enum_Card_number getCardValue(){return m_cardNumber;}
	Enum_Card_shape getCardShape(){return m_cardShape;}
	 Enum_Card_color getCardColor(){return m_cardColor;}
	 Enum_Card_type getCardType(){return m_cardType;}

	private void setCardValue(Enum_Card_number i_number){ m_cardNumber = i_number;}
	private void setCardShape(Enum_Card_shape i_shape){ m_cardShape = i_shape;}
	private void setCardColor(Enum_Card_color i_color){ m_cardColor = i_color;}
	private void setCardType(Enum_Card_type i_type){ m_cardType = i_type;}





	// Use this for initialization
	void Start ()	{}
	
	// Update is called once per frame
	void Update (){}



}
