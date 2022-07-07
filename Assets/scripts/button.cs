using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class button : MonoBehaviour
{
    public int id;
    void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(() => GameEvents.current.EventTrigger(id));
    }
}
