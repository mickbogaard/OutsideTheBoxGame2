using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainGame : MonoBehaviour
{
    public Text textElement;

    //[SerializeField] Text textElement;
    [SerializeField] State startState;
    State state;

    public string textDisplay;


    public Button buttonLeft;
    public Button buttonMiddle;
    public Button buttonRight;
    public Button buttonExtra;

    [SerializeField] State macheteSecret;
    [SerializeField] State grotFakkel;
    [SerializeField] State souvenirTijger;

    public bool machete;
    public bool souvenir;
    public bool fakkel;
    public bool pistool;

    void Start()
    {
        RestartGame();
        state = startState;
        textElement.text = state.GetStateText();
        SetButtonText();
        //buttonExtra.gameObject.SetActive(false);
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

        if (state.name == "Rotswand" && fakkel == true || state.name == "Jungle" && souvenir == true)
        {
            if (state.name == "Rotswand" && fakkel == true)
                state = grotFakkel;
            if (state.name == "Jungle" && souvenir == true)
                state = souvenirTijger;
        }
        else
        {
            State[] statesArray = state.GetOtherStates();
            state = statesArray[0];
        }

        //if (state.name == "Jungle" && souvenir == true)
        //{
        //    state = souvenirTijger;
        //}

        //if (state != grotFakkel)
        //{

        //}

        textElement.text = state.GetStateText();
        SetButtonText();
    }

    public void middleClick()
    {
        if (state.name == "Kratten")
        {
            machete = true;
        }

        if (state.name == "Start" && machete == true)
        {
            state = macheteSecret;
        }

        if (state != macheteSecret)
        {
            State[] statesArray = state.GetOtherStates();
            state = statesArray[1];
        }


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
        //sets buttons inactive if there is no text on button
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

        //sets extra button inactive if the player already has the torch
        //if (machete == true && buttonExtra.GetComponentInChildren<Text>().text != "" && fakkel == false)
        //{
        //    buttonExtra.gameObject.SetActive(true);
        //}

        ////////////////////////////////////////////////////else buttonExtra.gameObject.SetActive(false);

        //if player reaches this state they unlock the torch
        if (state.name == "Tak")
        {
            fakkel = true;
        }

        //unlocks machete option for tiger scene if the player has found the machete
        if (state.name == "Tijger" && machete == false || state.name == "Souvenir Tijger" && machete == false)
        {
            buttonMiddle.gameObject.SetActive(false);
        }
        //else buttonMiddle.gameObject.SetActive(true);

        if (state.name == "Tijger" && pistool == false || state.name == "Souvenir Tijger" && pistool == false)
        {
            buttonRight.gameObject.SetActive(false);
        }
        //else buttonRight.gameObject.SetActive(true);

        Debug.Log(state.name + " " + machete + "fakkel: " + fakkel);
    }

    private void SetButtonText()
    {
        buttonLeft.GetComponentInChildren<Text>().text = state.GetButtonTextLeft();
        buttonMiddle.GetComponentInChildren<Text>().text = state.GetButtonTextMiddle();
        buttonRight.GetComponentInChildren<Text>().text = state.GetButtonTextRight();
        /////////////////////////buttonExtra.GetComponentInChildren<Text>().text = state.GetButtonTextExtra();
    }

    private void RestartGame()
    {
        machete = false;
        souvenir = false;
        fakkel = false;
        pistool = false;
    }
}
