using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
	//Top level variables have underscore in front for readablility and searchablility
	[TextArea(14,18)] [SerializeField] string _storyText;
	[SerializeField] State[] _nextStates;

	public string GetStateStory()
	{
		return _storyText;
	}

	public State[] GetNextStates()
	{
		return _nextStates;
	}
}
