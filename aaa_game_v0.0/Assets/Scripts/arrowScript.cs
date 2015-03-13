using UnityEngine;
using System.Collections;

public class arrowScript : MonoBehaviour {

	
	// Update is called once per frame
	void Update () {
		
	}

	public Vector3 pointB;
	
	IEnumerator Start () {

		while (true) {
			transform.localScale += new Vector3(0.1F, 0, 0);

			new WaitForSeconds(2);
			transform.localScale += new Vector3(-0.1F, 0, 0);
		}
	}
	

}
