using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using DataModel;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {

	List<OpData> operationData = new List<OpData>();

	GameController gameControllerScript;

	void Start () {
		gameControllerScript = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
	}

	void Update(){
		if (Input.GetKey(KeyCode.Escape))
		{
			Application.Quit ();
		}
	}

	public void AddOperationData(OpData tempOpData){
		bool found = false;
		for (int i = 0; i < operationData.Count; i++) {
			if (tempOpData.operation == operationData [i].operation) {
				found = true;
				operationData [i] = tempOpData;
				Debug.Log (tempOpData.min + " " + tempOpData.max);
				break;
			}
		}

		if (!found) {
			operationData.Add (tempOpData);
		}

	/*	for (int i = 0; i < operationData.Count; i++) {
			Debug.Log(operationData[i].min + " " + operationData[i].max);
		}*/
	}
		
	public void PlayButton(){
		gameControllerScript.operationData = operationData;

		SceneManager.LoadScene ("Game");
	}
}
