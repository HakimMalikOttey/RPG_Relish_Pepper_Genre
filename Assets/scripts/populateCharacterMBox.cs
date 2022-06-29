using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class populateCharacterMBox : MonoBehaviour
{
    public GameObject player;
    public GameObject newPrefab;
    private GameObject message;
    public void AddMessage(ScriptableObject newConfig)
    {
        GameObject messageGroups = player.transform.Find("messageGroups").gameObject;
        GameObject groupPointer = messageGroups.transform.GetChild(0).gameObject;
        int groupChildCount = groupPointer.transform.childCount;
        if (groupChildCount != 0)
        {
            GameObject Cell = groupPointer.transform.GetChild(0).gameObject;
            InstantiateMessage(Cell);

        }
        else
        {
            GameObject newCell = Instantiate(newPrefab);
            newCell.transform.parent = groupPointer.transform;
            InstantiateMessage(newCell);
        }
    }
    public void InstantiateMessage(GameObject cell)
    {
        GameObject addedMessage = Instantiate(message);
        addedMessage.transform.parent = cell.transform;
    }
}
