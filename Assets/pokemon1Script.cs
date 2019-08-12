﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pokemon1Script : MonoBehaviour {

	public Button attackButton1;
	public GameObject hose;
	// Use this for initialization
	void Start () {

		attackButton1.onClick.AddListener (attackButton1Down);
		hose.transform.FindChild ("WaterShower").gameObject.SetActive (false);

		
	}

	IEnumerator Wait(){

		hose.transform.FindChild ("WaterShower").gameObject.SetActive (true);
		yield return new WaitForSeconds (2);
		hose.transform.FindChild ("WaterShower").gameObject.SetActive (false);

		
	}

	void attackButton1Down(){
		
		StartCoroutine (Wait ());
	}

	
	// Update is called once per frame
	void Update () {
		
	}

}
