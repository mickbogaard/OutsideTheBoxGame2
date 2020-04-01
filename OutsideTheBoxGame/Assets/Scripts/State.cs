using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string gameText;
    [SerializeField] string buttonTextLeft;
    [SerializeField] string buttonTextMiddle;
    [SerializeField] string buttonTextRight;
    [SerializeField] State[] otherStates;

    public string GetStateText()
    {
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
