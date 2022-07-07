using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }
    public event Action<int> eventTrigger;
    public void EventTrigger(int id)
    {
        if(eventTrigger != null)
        {
            eventTrigger(id);
        }
    }
}
