using UnityEngine;
using System.Collections;

public class WalkScript : MonoBehaviour {

	public float movementSpeed = 10;
	public SpriteRenderer ren;

	void set()
	{
		ren = transform.Find ("Cube").GetComponent<SpriteRenderer>();
	}

	void Update(){

		transform.Translate(Vector2.right * movementSpeed * Time.deltaTime);
		//Vector2 v = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
		//v *= 20;
		//rigidbody.AddForce(v);
	}
}
