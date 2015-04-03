using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	 //public float speed;
	private Vector3 directionOfMovment;	
	private Vector3 direction = new Vector3(0, 0, 0);
	private Vector3 speed = new Vector3 (3, 0, 0);
	private float waveTime = 1;

	// Use this for initialization
	void Start () {		
		directionOfMovment = new Vector3(1f,-1f,0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void FixedUpdate () {
//		this.rigidbody2D.velocity = directionOfMovment * speed;
//		waveTime -= Time.deltaTime;
//		if (waveTime < 0) {
//			waveTime = WaveMovementTime;
//			directionOfMovment.y *= -1;
//		}
	}

	void OnCollisionEnter2D (Collision2D collision){
		Debug.Log ("col************");

		if (collision.gameObject.tag == "border") {
			direction.y *= -1;
			Debug.Log("flip");
		}
		
	}

	public void Flip(){

		Vector3 scale = this.gameObject.transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		
	}
}
