using UnityEngine;
using System.Collections;

public class SessionScore : MonoBehaviour {

	private int currentScore;

	void Start() {
		currentScore = 0; 
	}
	public int getScore() {
		return currentScore;
	}

	public void AddScore(int addValue) { 
		currentScore = currentScore + addValue;
		}
	public void SubScore(int subValue) {
		currentScore =  currentScore - subValue;
		}	

	// TODO:: Add method for bonus points, different factors ect.. 


}
