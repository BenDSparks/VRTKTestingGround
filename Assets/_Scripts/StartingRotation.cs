using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartingRotation : MonoBehaviour {


	public float startAngle = 90;
	public Vector3 connectedAnchor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){
		//print("rotating");
		transform.RotateAround(connectedAnchor, new Vector3(1f,0f,0f), startAngle);
		enabled = false;
	}
}
