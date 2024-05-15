using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

namespace DataModel
{
	public enum Operation {Add = 0, Sub, Prd, Div};

	public struct OpData{
		public Operation operation;
		public int min,max;
	};

	public struct Options{
		public List<int> options;
		public int correctIndex;
	};

	public struct Question{
		public int l,r;
		public Operation operation;
	};

	public struct QuestionData{
		public Question ques;
		public Options opts;
	};

	public struct OptionData{
		public Button button;
		public Text text;
	}
}