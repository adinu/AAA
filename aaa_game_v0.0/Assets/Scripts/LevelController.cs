using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;



public class LevelController : MonoBehaviour {

	
	//TIMER
	public float startTime;
	private string currentTime;
	public Slider timerSlider;
	public Text timerText;
	private bool isTimeUp = false;


	public GameObject setEngineObject;
	public Text textToPlayer;
	public int numCardsInSet;
	private  int numOfCardsSelected = 0;
	private SetEngine setEngine;
	private bool canPeakCard = true;
	GameObject[] cardsAddedToSet;
	
	public void addCard(GameObject i_card)
	{
		Debug.Log ("cardsAddedToSet.Length: " + cardsAddedToSet.Length);
		if (canPeakCard) {
			
			for(int i = 0; i < cardsAddedToSet.Length; i++){
				if (cardsAddedToSet[i] == null){
					cardsAddedToSet[i] = i_card;
					Debug.Log ("addCard");
					printCardsList();
					break;
				}
			}
			
			if(numCardsInSet == numOfCardsSelected)
			{
				if(setEngine.IsSet(cardsAddedToSet)){
					Debug.Log("****  SET FOUND  ****");
					StartCoroutine(showTextToUser("SET FOUND!", 3));
					
					
					
				} 
				else {
					Debug.Log("!!!!  SET NOT FOUND  !!!!");
					StartCoroutine(showTextToUser("SET Not FOUND!", 3));
				}
			}
		}
	}
	
	IEnumerator showTextToUser(string message, float delay) {
		//Debug.Log ("text" + text);
		textToPlayer.text = message;
		textToPlayer.enabled = true;
		print(Time.time);
		yield return new WaitForSeconds(delay);
		textToPlayer.enabled = false;
		
		
	}
	
	
	public void removeCard(GameObject i_card)
	{
		for(int i = 0; i < cardsAddedToSet.Length; i++){
			if (cardsAddedToSet[i] == i_card){
				cardsAddedToSet[i] = null;
				Debug.Log ("removeCard");
				break;
			}
		}
	}
	
	public void printCardsList()
	{
		foreach (GameObject card in cardsAddedToSet) /*Search empty place and add card*/
		{
			if(card != null) {
				Debug.Log(( card.GetComponent<Card>().m_cardColor.ToString() )+
				          " / " + card.GetComponent<Card>().m_cardNumber.ToString() +
				          "\n" + card.GetComponent<Card>().m_cardFill.ToString() +
				          " / " + card.GetComponent<Card>().m_cardShape.ToString() );
			}
		}
	}
	
	public void increanentCardCount(){
		numOfCardsSelected++;
		Debug.Log(numOfCardsSelected + "increanentCardCount");
	}
	
	public void deccreanentCardCount(){
		numOfCardsSelected--;
	}
	
	public int getCardCount(){
		return numOfCardsSelected;
	}
	
	public bool canPickCard()
	{
		if (numOfCardsSelected < numCardsInSet) {
			canPeakCard = true;
		}else{
			canPeakCard =false;
		}
		
		Debug.Log("numOfCardsSelected:" + numOfCardsSelected + "canPeakCard:" + canPeakCard);
		
		return canPeakCard;
	}
	
	void Start () {
		cardsAddedToSet = new GameObject[numCardsInSet];
		setEngine = setEngineObject.GetComponent<SetEngine>();
		numOfCardsSelected = 0;
		Debug.Log ("start numOfCardsSelected" + numOfCardsSelected);
	}
	
	
	public void Awake()
	{
		TimerEvents.onAddTime += this.AddTime;
		TimerEvents.onSubstractTime += this.SubTime;
	}
	
	public void Destroy() 
	{
		TimerEvents.onAddTime -= this.AddTime;
		TimerEvents.onSubstractTime -= this.SubTime;
	}

	
	// Update is called once per frame
	void Update () {
		timerUpdate ();
		
	}
	
	void timerUpdate() {
		startTime -= Time.deltaTime;
		currentTime = string.Format ("{0:0.0}", startTime);
		timerSlider.value = startTime;
		timerText.text = currentTime;
		if (startTime <= 0) {
			// TIME UP
			startTime = 0;
			isTimeUp = true;
			print ("timeUp");}			}
	public void AddTime(float deltaTime) {
		float extraTimeFromDelta = ((deltaTime + startTime) > timerSlider.maxValue)
			? timerSlider.maxValue - startTime: deltaTime;
		if (!isTimeUp) {
			startTime += extraTimeFromDelta;
		}
	}
	
	public void SubTime(float deltaTime) {
				if (!isTimeUp && deltaTime < startTime) {
						startTime -= deltaTime;
				}
		}
}