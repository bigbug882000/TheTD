using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TDTK;

public class RscRegen : MonoBehaviour {

	//public GameControl gameControl;
	public ResourceManager resourceManager;
	public float rscGenRate;


	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null){
			resourceManager = gameControllerObject.GetComponent<ResourceManager>();

			float r = resourceManager.rscGenRateList[0];
			r += rscGenRate;
			resourceManager.rscGenRateList [0] = r;
		}
		if (resourceManager == null){
			Debug.Log ("Cannot fine 'GameController' Script");
		}


	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
