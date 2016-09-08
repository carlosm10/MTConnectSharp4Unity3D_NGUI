﻿using System;
using UnityEngine;
using System.Collections;

public class VariableController : MonoBehaviour {

	public UILabel value;

	public enum VariableList{
		NONE=0,
		Xcom=1
	}

	public VariableList variable;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//setValueToLabel (Session_App.values["Xcom"]);
	}

	public void setValueToLabel(string val){
		value.text=" ";
		value.text = val;
	}
		
	public string getValueString(){
		string stringValue = Enum.GetName(typeof(VariableList), ((int)variable));
		Debug.Log ("-----"+stringValue);
		return stringValue;
	}
}
