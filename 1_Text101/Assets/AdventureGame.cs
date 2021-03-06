using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingText;
    
    State state;
    // Start is called before the first frame update
    void Start()
    {
        state = startingText;
        textComponent.text = state.GetStateStory(); ;
    }

    // Update is called once per frame
    void Update()
    {
        ManageStates();
    }

    private void ManageStates()
    {
        var nextState = state.GetNextState();
        for(int index = 0; index < nextState.Length; index++)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1 + index))
            {
                state = nextState[index];
            }
        }
        textComponent.text = state.GetStateStory();
    }
}
