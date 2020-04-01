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
    public Button buttonExtra;

    public bool machete;
    public bool souvenir;
    public bool fakkel;
    public bool pistool;

    void Start()
    {
        state = startState;
        textElement.text = state.GetStateText();
        SetButtonText();
        RestartGame();
        buttonExtra.gameObject.SetActive(false);
    }

    public void leftClick()
    {
        if (state.name == "Kratten")
        {
            souvenir = true;
        }

        if (state.name == "Vervallen huis 2")
        {
            pistool = true;
        }

        State[] statesArray = state.GetOtherStates();
        state = statesArray[0];
        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void middleClick()
    {
        if (state.name == "Kratten")
        {
            machete = true;
        }

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

    public void extraClick()
    {
        State[] statesArray = state.GetOtherStates();
        state = statesArray[3];
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

        if (machete == true && buttonExtra.GetComponentInChildren<Text>().text != "" && fakkel == false)
        {
            buttonExtra.gameObject.SetActive(true);
        }
        else buttonExtra.gameObject.SetActive(false);

        if (state.name == "Tak")
        {
            fakkel = true;
        }
    }

    private void SetButtonText()
    {
        buttonLeft.GetComponentInChildren<Text>().text = state.GetButtonTextLeft();
        buttonMiddle.GetComponentInChildren<Text>().text = state.GetButtonTextMiddle();
        buttonRight.GetComponentInChildren<Text>().text = state.GetButtonTextRight();
        buttonExtra.GetComponentInChildren<Text>().text = state.GetButtonTextExtra();
    }

    private void RestartGame()
    {
        machete = false;
        souvenir = false;
        fakkel = false;
        pistool = false;
    }
}
