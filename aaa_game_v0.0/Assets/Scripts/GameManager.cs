using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System.Collections;

public class GameManager : MonoBehaviour {

	// Score
	public static int currentScore;
	public static int currentEnergy;

	// Level identifiers 
	public static int currentUnlockedLevel;
	public static int currentWorldID;


	// GUI & UI 
	// NOTE: GUISkin might be redundant.. 
	public GUISkin  skin;

	void Update() 
	{

	}

	void OnGUI() 
	{
		GUI.skin = skin;

		if (GUI.Button (new Rect (20, 120, 200, 30), "Add Score")) {
			ScoreManager.score += 5;
		}
		
		if (GUI.Button (new Rect (20, 180, 200, 30), "Reset High Score")) {
			LeaderBoard.ResetHighScore();
		}
		
		if (GUI.Button (new Rect (20, 240, 200, 30), "Remove Points")) {
			if(ScoreManager.score >= 5) {
			ScoreManager.score -= 5;
			}
		}

		if (GUI.Button (new Rect (20, 300, 200, 30), "Save Score")) {
			LeaderBoard.SaveHighScore(ScoreManager.score);
		}
		
	}
}