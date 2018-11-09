using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	public float speed;
	public float endx;
	public float startx;

	void Start()
	{

		if (this.gameObject.tag == "Ground")
			speed = GameObject.Find ("Player").GetComponent<Character> ().speed;
	}
	
	void Update () {

		if (this.gameObject.tag == "Ground")
			speed = GameObject.Find ("Player").GetComponent<Character> ().speed;

		transform.Translate (Vector2.left * speed * Time.deltaTime);

		if (transform.position.x < endx) {
		
			transform.position = new Vector3 (startx, transform.position.y, transform.position.z);
		}
	}
}
