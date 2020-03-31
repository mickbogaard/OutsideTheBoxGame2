using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    [SerializeField] Text textElement;
    [SerializeField] State startState;
    State state;

    public Button buttonLeft;
    public Button buttonMiddle;
    public Button buttonRight;

    // Start is called before the first frame update
    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
    }

    // Update is called once per frame
    void Update()
    {
        //GameMain();
    }

    //used to respond to input
    /*private void GameMain()
    {
        State[] statesArray = state.GetOtherStates();
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            state = statesArray[0];
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            state = statesArray[1];
        }
        textElement.text = state.GetStateText();
    }*/

    public void leftClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[0];
        textElement.text = state.GetStateText();
    }

    public void middleClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[1];
        textElement.text = state.GetStateText();
    }

    public void rightClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[2];
        textElement.text = state.GetStateText();
    }
}
