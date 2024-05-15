using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using DataModel;
using UnityEngine.SceneManagement;


public class GameController : MonoBehaviour {

	[HideInInspector]
	public List<OpData> operationData = new List<OpData>();

	void Start () {
		if (PlayerPrefs.GetInt ("Played") == 0) {
			// Playing for the first time
			PlayerPrefs.SetInt("Played",10);
			PlayerPrefs.SetInt ("HighScore", 0);
		}

		DontDestroyOnLoad (this.gameObject);
		SceneManager.LoadScene ("Menu");
	}

}
