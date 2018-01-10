using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour {

	[SerializeField]
	private float defaultHeight = 1.8f;
	[SerializeField]
	private Camera camera;

	// Use this for initialization
	void Start () {
		
	}





	// Update is called once per frame
	void Update () {
		float headHeight = camera.transform.localPosition.y;
		if (headHeight > 0) {
			SetToDefaultHeight(headHeight);
			enabled = false;
		}
	}



	void SetToDefaultHeight(float headHeight){
		//print("head hight: " + headHeight);
		float scale = defaultHeight / headHeight;
		//print("Scale: " + scale);
		transform.localScale = Vector3.one * scale;
		//print("local scale: " + transform.localScale);
	}
}
