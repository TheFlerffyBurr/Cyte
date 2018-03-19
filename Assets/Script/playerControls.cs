using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControls : MonoBehaviour {

	public float BaseSpeed = 5f;
	public float Sensitivity =10f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
		followMouse ();
	}

	private void followMouse(){
		float mouseX = Input.GetAxis("Mouse X") * Sensitivity;
		float mouseY = Input.GetAxis("Mouse Y") * Sensitivity;

		Transform angle = transform;
		Vector3 mouse = new Vector3(-mouseY,mouseX,0f); 
		angle.Rotate(mouse);
		angle.eulerAngles = new Vector3 (angle.eulerAngles.x, angle.eulerAngles.y, 0f);
		transform.rotation = angle.rotation;
	}

	private void Movement(){
		Transform pos = transform;
		if(Input.GetKey(KeyCode.A)){
			pos.position -=pos.right * BaseSpeed * Time.deltaTime;
			transform.position = pos.position;
		}
		if(Input.GetKey(KeyCode.D)){
			pos.position +=pos.right * BaseSpeed * Time.deltaTime;
			transform.position = pos.position;
		}
		if(Input.GetKey(KeyCode.W)){
			pos.position +=pos.forward * BaseSpeed * Time.deltaTime;
			transform.position = pos.position;
		}
		if(Input.GetKey(KeyCode.S)){
			pos.position -=pos.forward * BaseSpeed * Time.deltaTime;
			transform.position = pos.position;
		}
	}
}
