using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutBehaviour : MonoBehaviour {

	public float speed;

	void OnTriggerEnter2D(Collider2D col) {

		if (col.tag == "Player" && this.tag == "Nut") {
			Destroy (this.gameObject);
			GameObject.Find ("Player").GetComponent<Character> ().Score++;
		}
	}

	void Update()
	{
			speed = GameObject.Find ("Player").GetComponent<Character> ().speed;
			transform.Translate (-speed * Time.deltaTime, 0, 0);

		if (this.transform.position.x < -10)
			GameObject.Destroy(gameObject);
	}
}
