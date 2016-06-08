using UnityEngine;
using System.Collections;

public class Butterfly_Movement : MonoBehaviour {
	public float velocity = 1f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += Vector3.down * Time.deltaTime * velocity;
	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		Destroy(gameObject);
		
	}
}



