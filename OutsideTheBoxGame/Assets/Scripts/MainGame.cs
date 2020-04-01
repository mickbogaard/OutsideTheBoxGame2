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

    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void leftClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[0];
        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void middleClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[1];
        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void rightClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[2];
        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void Update()
    {
        if (buttonLeft.GetComponentInChildren<Text>().text == "")
        {
            buttonLeft.gameObject.SetActive(false);
        }
        else buttonLeft.gameObject.SetActive(true);

        if (buttonMiddle.GetComponentInChildren<Text>().text == "")
        {
            buttonMiddle.gameObject.SetActive(false);
        }
        else buttonMiddle.gameObject.SetActive(true);

        if (buttonRight.GetComponentInChildren<Text>().text == "")
        {
            buttonRight.gameObject.SetActive(false);
        }
        else buttonRight.gameObject.SetActive(true);
    }

    private void SetButtonText()
    {
        buttonLeft.GetComponentInChildren<Text>().text = state.GetButtonTextLeft();
        buttonMiddle.GetComponentInChildren<Text>().text = state.GetButtonTextMiddle();
        buttonRight.GetComponentInChildren<Text>().text = state.GetButtonTextRight();
    }
}
