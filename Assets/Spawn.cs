using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject bt;
	public float maxPos = 7.32f;
	public float dt = 0.85f;
		float timer;

	// Use this for initialization
	void Start () {

		timer = dt;


	
	}
	
	// Update is c	alled once per frame
	void Update () {

		timer -= Time.deltaTime;
			if (timer <= 0){


			Vector3 btpo = new Vector3 (Random.Range (-2.19f, 7.32f), Random.Range (-2f, 4f),transform.position.z);
		
		Instantiate (bt, btpo, transform.rotation);
	
			timer = dt;
	}
	}
}
