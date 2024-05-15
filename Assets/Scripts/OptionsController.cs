using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using DataModel;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {

	public List<GameObject> optionsObject;
	public Text questionText,scoreText;
	public LevelController levelScript;

	List<OptionData> optionData = new List<OptionData>();
	int correctIndex;

	void Start () {
		for (int i = 0; i < optionsObject.Count; i++) {
			OptionData tempOptionData;
			tempOptionData.text = optionsObject [i].transform.GetChild (0).gameObject.GetComponent<Text> ();
			tempOptionData.button = optionsObject [i].GetComponent<Button> ();
			optionData.Add (tempOptionData);
		}
	}

	public void UpdateUI(DataModel.QuestionData questionData){
		string question = questionData.ques.l.ToString () + OperationChar (questionData.ques.operation) +
		                  questionData.ques.r.ToString ();
		questionText.text = question;
		for (int i = 0; i < optionsObject.Count; i++) {
			optionData [i].text.text = questionData.opts.options [i].ToString ();
		}
		correctIndex = questionData.opts.correctIndex;
	}

	public void OptionClick(int index){
		optionData [correctIndex].button.GetComponent<Image> ().color = Color.green;
		if (index == correctIndex) {
			levelScript.UpdateScore ();
			levelScript.MakeQuestion (false);
		} 
		else {
			optionData [index].button.GetComponent<Image> ().color = Color.red;
			levelScript.MakeQuestion (true);
		}
	}

	public void ResetOptionColor(){
		for (int i = 0; i < optionsObject.Count; i++) {
			optionData [i].button.GetComponent<Image> ().color = Color.white;
		}
	}

	public void UpdateScoreUI(int score){
		scoreText.text = score.ToString();
	}
		

	char OperationChar(Operation operation){
		switch (operation) {
		case Operation.Add:
			return '+';
		case Operation.Sub:
			return '-';
		case Operation.Prd:
			return '*';
		case Operation.Div:
			return '/';
		}
		return '$';
	}

}
