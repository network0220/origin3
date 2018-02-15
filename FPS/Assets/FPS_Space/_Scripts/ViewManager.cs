using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewManager : MonoBehaviour {

	public GameObject prefabController;

	// Use this for initialization
	void Start () {
		Instantiate (prefabController, transform.position, prefabController.transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
