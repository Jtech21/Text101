using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdventureGame : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI _textComponent;
    [SerializeField] State _startingState;

    State _currentState;

    // Start is called before the first frame update
    void Start()
    {
        _currentState = _startingState; 
        _textComponent.text = _currentState.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

	private void ManageState()
	{
        var nextStates = _currentState.GetNextStates();

        for(int i = 0; i < nextStates.Length; i++)
		{
            if (Input.GetKeyDown(KeyCode.Alpha1 + i))
            {
                _currentState = nextStates[i];
            }
        }
        _textComponent.text = _currentState.GetStateStory();
	}
}
