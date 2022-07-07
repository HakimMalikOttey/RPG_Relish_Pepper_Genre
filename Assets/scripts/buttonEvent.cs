using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class buttonEvent : MonoBehaviour
{
    public int id;
    public GameObject wordBlock;
    public GameObject target;
    // Start is called before the first frame update
    private void Start()
    {
        GameEvents.current.eventTrigger += OnClicked;
    }
    private void OnClicked(int id)
    {
        Transform textContainer = target.transform.GetChild(target.GetComponent<createBox>().textBoxPointer).GetChild(0);
        if (id == this.id)
        {
            foreach (Transform child in textContainer)
            {
                if (child.GetComponent<textData>().origin == this.name)
                {
                    Destroy(child.gameObject);
                    return;
                }
            }
            GameObject spawnBlock = Instantiate(wordBlock,Vector3.zero, Quaternion.identity);
            spawnBlock.transform.SetParent(textContainer);
            spawnBlock.transform.GetComponent<TMP_Text>().SetText("test");
            spawnBlock.AddComponent<textData>();
            spawnBlock.transform.GetComponent<textData>().origin = this.name;
            Debug.Log(this.transform.name);
        }
    }
}
