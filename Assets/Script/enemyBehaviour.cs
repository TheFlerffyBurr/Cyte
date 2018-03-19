using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour {

	public GameObject target;
	public float BaseSpeed = 1f;
	public float minPeriod = 1f;
	public float maxPeriod = 5f;
	public float period = 3f;
	public float distance = 100f;
	public float chasingSpeed = 2f;
	private float dist;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		dist = Vector3.Distance (target.transform.position,transform.position);
		if (dist < distance) {
			FollowState ();
		} else {
			NormalState ();
		}
			
	}

	private void NormalState(){
		//forward movement
		Transform pos = transform;
		pos.position += pos.forward * Time.deltaTime * BaseSpeed;
		transform.position = pos.position;

		//change in angle rotation every few second
		period -= Time.deltaTime;
		if (period <= 0f) {
			period = Random.Range(minPeriod,maxPeriod);
			Transform angle = transform;
			angle.Rotate (0,Random.Range(-180,180),Random.Range(-180,180));
			transform.rotation = angle.rotation;
		};
			
	} 

	private void FollowState(){
		
		Transform pos = transform;
		pos.position += pos.forward * Time.deltaTime * BaseSpeed * chasingSpeed;
		transform.position = pos.position;

		transform.LookAt (target.transform);

	}


}
