using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DataModel;

public class LevelController : MonoBehaviour {

	public int scoreMultiplier = 10;
	public float timePenelty = 1,totalTime = 60;
	public Text timeText,highScoreText;
	public OptionsController optionsScript;
	public Animator canvasAnimator;

	List<OpData> operationData = new List<OpData>();
	OpData curOperationData;
	QuestionData curQuestionData;
	int score = 0;
	bool gameOver = false;
	GameController gameControllerScript;

	void Start () {
		gameControllerScript = GameObject.FindGameObjectWithTag ("GameController").GetComponent<GameController> ();
		timeText.text = totalTime.ToString();
		optionsScript.UpdateScoreUI (score);
		operationData = gameControllerScript.operationData;	

/*		for (int i = 0; i < operationData.Count; i++) {
			Debug.Log(operationData[i].min + " " + operationData[i].max);
		}*/

		MakeQuestion ();
	}

	void Update () {
		if (totalTime > 0) {
			totalTime -= Time.deltaTime;
			timeText.text = ((int)totalTime).ToString();
		}
		else{
			timeText.text = "0";
			if (!gameOver) {
				gameOver = true;
				GameOver ();
			}
		}

		if (Input.GetKey(KeyCode.Escape))
		{
			MenuButton ();
		}
	}


	public void MakeQuestion(bool wait = false){
		StartCoroutine (MakeQuestionCoron(wait));
		if (wait) {
			Handheld.Vibrate ();
		}
	}

	IEnumerator MakeQuestionCoron(bool wait = false){
		if (wait) {
			yield return new WaitForSeconds(timePenelty);
		} 
		else {
			yield return new WaitForSeconds(0.2f);
		}
		optionsScript.ResetOptionColor ();
		Question ();
	}

	void Question(){
		Operation curOp = (Operation)Random.Range((int) Operation.Add, ((int) Operation.Div) + 1);
		curOperationData =  SetOpData (curOp);
		curQuestionData = FormQuestion (curOperationData);
		optionsScript.UpdateUI (curQuestionData);
	}

	QuestionData FormQuestion(OpData curOpData){
		Question question;
		question.operation = curOpData.operation;
		int min = curOpData.min;
		int max = curOpData.max;

		switch (question.operation) {

		case Operation.Add:
			question.l = Random.Range (min,max);	
			question.r = Random.Range (min,max);	
			break;
		case Operation.Sub:
			question.l = Random.Range (min,max);	
			question.r = Random.Range (min,max);
			break;
		case Operation.Prd:
			question.l = Random.Range (min,max);	
			question.r = Random.Range (min,max);
			break;
		case Operation.Div:
			int a = Random.Range (min, max);	
			int b = Random.Range (min, max);
			int c = a * b;
			question.l = c;
			question.r = a;
			break;
		default:
			question.l = Random.Range (min,max);	
			question.r = Random.Range (min,max);
			break;
		}

		Options options = FormOptions (question);
		QuestionData questionData;
		questionData.opts = options;
		questionData.ques = question;
		return questionData;
	}


	Options FormOptions(Question question){
		Options options;

		int l = question.l, r = question.r;
		int correctOption = 0;

		switch (question.operation) {
		case Operation.Add:
			correctOption = l + r;
			break;
		case Operation.Sub:
			correctOption = l - r;
			break;
		case Operation.Prd:
			correctOption = l * r;
			break;
		case Operation.Div:
			correctOption = l / r;
			break;
		}

		int correctIndex = Random.Range (0, 4);
		options.correctIndex = correctIndex;
		List<int> opts = new List<int>();

		for (int i = 0; i < 4; i++) {
			if (i == correctIndex) {
				opts.Add (correctOption);
				continue;
			} 

			int opt;
			do {
				opt = correctOption + Random.Range (-10, 10);
			} while(opt == correctOption);
			opts.Add (opt);
		}

		options.options = opts;

		return options;
	}

	OpData SetOpData(Operation op){
		OpData cod = operationData[0];
		foreach (OpData opData in operationData) {
			if (opData.operation == op) {
				cod = opData;
				break;
			}
		}
		return cod;
	}

	public void UpdateScore(){
		score += scoreMultiplier;
		optionsScript.UpdateScoreUI (score);
	}


	public void PlayAgain(){
		SceneManager.LoadScene ("Game");
	}

	public void MenuButton(){
		SceneManager.LoadScene ("Menu");
	}

	void GameOver(){
		StopCoroutine (MakeQuestionCoron ());
		canvasAnimator.SetTrigger ("GameOver");
		if (PlayerPrefs.GetInt ("HighScore") < score) {
			PlayerPrefs.SetInt ("HighScore", score);
		}
		highScoreText.text = "HIGHSCORE : " + PlayerPrefs.GetInt ("HighScore").ToString();
	}

}
