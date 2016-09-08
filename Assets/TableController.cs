using UnityEngine;
using System.Collections;
using System.Collections.Generic;	

public class TableController : MonoBehaviour {
	private UITable tabla;
	public ClientController cc;

	// Use this for initialization
	void Start () {
		
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void assignValue(){
		tabla = gameObject.GetComponent<UITable> ();

		List<Transform> lista = tabla.GetChildList ();
		foreach(Transform t in lista){
			GameObject go = t.gameObject;
			VariableController vc = go.GetComponent<VariableController> ();


			string vcString = vc.getValueString ();
			bool checkVar = Session_App.values.ContainsKey(vcString);

			Debug.Log (checkVar);
			if(checkVar){
				string valueChecked = Session_App.values[vcString];
				Debug.Log (valueChecked);
				vc.setValueToLabel (valueChecked);
			}


			//Session_App.values["Xcom"] = "";
			//Get Dictionary From ClientController

		}
	}


}
