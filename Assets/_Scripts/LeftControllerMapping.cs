using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class LeftControllerMapping : MonoBehaviour {

	public Transform managerTransform;
	public float turnAngle = 45;
	private VRTK_ControllerEvents controllerEvents;
	private bool canTurn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnEnable(){


		controllerEvents = GetComponent<VRTK_ControllerEvents>();
		if (controllerEvents == null)
		{
			VRTK_Logger.Error(VRTK_Logger.GetCommonMessage(VRTK_Logger.CommonMessageKeys.REQUIRED_COMPONENT_MISSING_FROM_GAMEOBJECT, "VRTK_ControllerEvents_ListenerExample", "VRTK_ControllerEvents", "the same"));
			return;
		}

		controllerEvents.StartMenuPressed += DoStartMenuPressed;
		controllerEvents.TouchpadAxisChanged += DoTouchpadAxisChanged;
		canTurn = true;

	}

	private void DoStartMenuPressed(object sender, ControllerInteractionEventArgs e){
		print("resetting scene");

		SceneManager.LoadSceneAsync("Main");

	}

	private void DoTouchpadAxisChanged(object sender, ControllerInteractionEventArgs e){

		//print("Axis: " + e.touchpadAxis);

		float axisX = e.touchpadAxis.x;

		if (canTurn && axisX < -.9) {
			print("turn left");
			managerTransform.Rotate(0, -turnAngle, 0);
			canTurn = false;
		}
		else if (canTurn && axisX > .9) {
			print("turn right");
			managerTransform.Rotate(0, turnAngle, 0);
			canTurn = false;
		}
		else if (!canTurn && -.5 < axisX && axisX < .5) {
			canTurn = true;
		}



	}


}
