using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour {

	public float jump;
	public float superJump;
	public float speed = 2.6f;
	public int Score = 0;

	private float time1;
	private float time2;
	private bool tap = false;

	void Start ()
	{
		GameObject.Find ("ScoreUI").GetComponent<UnityEngine.UI.Text> ().text = Score.ToString();
	}

	void Update ()
	{
		GameObject.Find ("ScoreUI").GetComponent<UnityEngine.UI.Text> ().text = Score.ToString();
		GameObject.Find ("DistUI").GetComponent<UnityEngine.UI.Text> ().text = ((int)(Time.time * 8)).ToString ();
		this.GetComponent<Animator> ().SetFloat ("Height", transform.position.y);

		if (Input.GetKeyDown ("space") && transform.position.y < -1) {
			if (tap == true) {
				time1 = Time.time;
				tap = false;

				if (time1 - time2 < 0.2f)
					this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, superJump), ForceMode2D.Impulse);
			} 
		} else {
		
			if (tap == false && transform.position.y < -2.4) {
				this.GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jump), ForceMode2D.Impulse);
				time2 = Time.time;
				tap = true;
			}
		}

		if (Input.GetKeyDown (KeyCode.A)) {
			this.GetComponent<Animator> ().speed = 1.1f;
			speed = 4;
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			this.GetComponent<Animator> ().speed = 1;
			speed = 2.6f;
		}
	}
}
