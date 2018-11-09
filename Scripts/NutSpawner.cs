using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NutSpawner : MonoBehaviour {

	public float[] spawnHeight;
	public GameObject nut;
	public int start = 0;
	public int time;
	public int noNuts;

	void Update () {

		time = (int)Time.time;
	
		if (time - start == 3) {

			noNuts = Random.Range (1, 4);

			for (int i = 0; i < noNuts; i++) {
				Instantiate (nut, new Vector3 (transform.position.x, spawnHeight [Random.Range (0, spawnHeight.Length)], -0.5f), Quaternion.identity);
				StartCoroutine (Timer ());
			}

			start = (int)Time.time;
		}
	}

	IEnumerator Timer()
	{
		while (true)
			yield return new WaitForSeconds (0.5f);
	}
}
