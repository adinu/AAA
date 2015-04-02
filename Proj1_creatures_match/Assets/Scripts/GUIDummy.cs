using UnityEngine;
using System.Collections;

public class GUIDummy : MonoBehaviour {
	public GameObject obj;
	// Use this for initialization
	void OnGUI() {
		SessionScore currentScore = obj.GetComponent<SessionScore>();
		/*if (GUI.Button (new Rect (20, 250, 200, 30), "Add Score")) {
			currentScore.AddScore(5);
			print(currentScore.getScore());
		}


		if (GUI.Button (new Rect (20, 120, 200, 30), "Back to Level select")) {

			ScoreManager.score = currentScore.getScore() + ScoreManager.score; 
			print(currentScore.getScore());

			Application.LoadLevel("scene_1.0");

		}*/
	

	}
}
