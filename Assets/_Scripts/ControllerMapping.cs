using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class ControllerMapping : MonoBehaviour {


	private VRTK_ControllerEvents controllerEvents;

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

	}

	private void DoStartMenuPressed(object sender, ControllerInteractionEventArgs e){
		print("resetting scene");

		SceneManager.LoadSceneAsync("Main");

	}


}
