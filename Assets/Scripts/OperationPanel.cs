using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using DataModel;

public class OperationPanel : MonoBehaviour {

	public string operationName;
	public Text operationNameText,minText,maxText;
	public InputField minInputField, maxInputField;
	public int max = 100, min = 0,curMax = 100,curMin = 0;

	OpData operationData;
	MenuController menuScript;

	void Start () {
		menuScript = GameObject.FindGameObjectWithTag ("MenuController").GetComponent<MenuController> ();
		operationNameText.text = operationName;
		minText.text = "MIN : " + min.ToString ();
		maxText.text = "MAX : " + max.ToString ();
		minInputField.text = curMin.ToString ();
		maxInputField.text = curMax.ToString ();
		operationData.min = curMin;
		operationData.max = curMax;
		operationData.operation = GetOperation ();
		menuScript.AddOperationData (operationData);
	}


	public void OnInputChange(){
		if (System.Convert.ToInt32 (minInputField.text) < min) {
			curMin = min;
			minInputField.text = curMin.ToString ();
		}
		if (System.Convert.ToInt32 (maxInputField.text) > max) {
			curMax = max;
			maxInputField.text = curMax.ToString ();
		}
		operationData.min = System.Convert.ToInt32 (minInputField.text);
		operationData.max = System.Convert.ToInt32 (maxInputField.text);
		menuScript.AddOperationData (operationData);
	}
		

	Operation GetOperation(){
		char operationChar = operationName [0];
		switch (operationChar) {
		case 'A':
			return Operation.Add;
		case 'S':
			return Operation.Sub;
		case 'M':
			return Operation.Prd;
		case 'D':
			return Operation.Div;
		default:
			return Operation.Add;
		}
	}
}
