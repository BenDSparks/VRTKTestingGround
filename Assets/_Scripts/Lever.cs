using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour {

	public Renderer rend;

	private HingeJoint hinge;
	private Material mat;

	[HideInInspector]
	public bool isOn = false;
	[HideInInspector]
	public bool isOff = true;

	// Use this for initialization
	void Start () {
		hinge = GetComponent<HingeJoint>();
		mat = new Material(rend.material);
		rend.material = mat;
	}
	
	// Update is called once per frame
	void Update () {


		//if not on and set to on
		if (hinge.angle < -88) {
			mat.color = Color.green;
			isOn = true;
			isOff = false;
		}
		//if not off and set to off
		else if (hinge.angle > 88) {
			mat.color = Color.red;
			isOff = true;
			isOn = false;
		}

		else {
			mat.color = Color.white;
			isOn = false;
			isOff = false;	
		}
	}
}
