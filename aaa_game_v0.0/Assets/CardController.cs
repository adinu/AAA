using UnityEngine;
using System.Collections;

public class CardController : MonoBehaviour {

	public float speed = 20.0f;
	private Vector3 directionOfMovment = new Vector3(0, 0, 0);
	private Rigidbody2D rb;

	// Use this for initialization
	void Start () {		
		rb = GetComponent<Rigidbody2D> ();
		directionOfMovment = new Vector3(1f,1f,0f);
	}
	
	// Update is called once per frame
	void Update () {}

	void FixedUpdate () {
		rb.velocity = directionOfMovment * speed;
	}

	void OnCollisionEnter2D (Collision2D collision){
		Debug.Log ("col************");

		float direction = Random.Range (-1, 1);

		if (collision.gameObject.tag == "border") {
			if(direction > 0)
			{ //randomly switch direction
			directionOfMovment.y *= -1;
			}
			directionOfMovment.x *= -1;
			
			Debug.Log("flip");
		}
		
	}

	public void Flip(){
		Vector3 scale = this.gameObject.transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
	}
}
