using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = 1f;
	// Use this for initialization
	void Start () { 
			}
	
	// Update is called once per frame
	void Update () {

	if (Input.GetKey (KeyCode.Mouse0))
			transform.position -= new Vector3 (speed * Time.deltaTime, 0.0f , 0.0f);
		if (Input.GetKey (KeyCode.Mouse1))
			transform.position += new Vector3 (speed * Time.deltaTime, 0.0f , 0.0f);

	}




}
