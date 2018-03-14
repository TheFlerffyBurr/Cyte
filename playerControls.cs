using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {

	public float BaseSpeed = 5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if(Input.GetKey(KeyCode.A)){
			pos.x -=BaseSpeed * Time.deltaTime;
			transform.position = pos;
		}
		if(Input.GetKey(KeyCode.D)){
			pos.x +=BaseSpeed * Time.deltaTime;
			transform.position = pos;
		}
		if(Input.GetKey(KeyCode.W)){
			pos.z +=BaseSpeed * Time.deltaTime;
			transform.position = pos;
		}
		if(Input.GetKey(KeyCode.S)){
			pos.z -=BaseSpeed * Time.deltaTime;
			transform.position = pos;
		}
	}
}
