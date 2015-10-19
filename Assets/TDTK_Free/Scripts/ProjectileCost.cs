using UnityEngine;
using System.Collections;
using System.Collections.Generic;

using TDTK;

public class ProjectileCost : MonoBehaviour {

	//public GameControl gameControl;
	public ResourceManager resourceManager;
	public float projectileCost;
	
	
	// Use this for initialization
	void Start () {
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null){
			resourceManager = gameControllerObject.GetComponent<ResourceManager>();
			
			float  v = (float) resourceManager.rscList[0].value;
			v += projectileCost;	//cast v as float
			resourceManager.rscList[0].value = (int) v;
		}
		if (resourceManager == null){
			Debug.Log ("Cannot fine 'GameController' Script");
		}
		
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
