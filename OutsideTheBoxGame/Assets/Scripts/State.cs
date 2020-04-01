using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject
{
    //[SerializeField] string gameText;

    public string gameText;

    [SerializeField] string buttonTextLeft;
    [SerializeField] string buttonTextMiddle;
    [SerializeField] string buttonTextRight;
    [SerializeField] State[] otherStates;

    public string GetStateText()
    {
        GameObject.Find("Story Text").GetComponent<TypeWriterEffect>().fullText = gameText;
        GameObject.Find("Story Text").GetComponent<TypeWriterEffect>().startText = true;
        GameObject.Find("Story Text").GetComponent<TypeWriterEffect>().forLoop = 0;

        return gameText;
    }

    public string GetButtonTextLeft()
    {
        return buttonTextLeft;
    }

    public string GetButtonTextMiddle()
    {
        return buttonTextMiddle;
    }

    public string GetButtonTextRight()
    {
        return buttonTextRight;
    }

    public State[] GetOtherStates()
    {
        return otherStates;
    }
}
