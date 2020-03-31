﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu (menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] string gameText;
    [SerializeField] State[] otherStates;

    public string GetStateText()
    {
        return gameText;
    }

    public State[] GetOtherStates()
    {
        return otherStates;
    }
}
