using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eventGetter : MonoBehaviour
{
    [System.Serializable]
public class SingleEvent{
    public int eventId;
    public string eventTitle;
    public string eventDescription;
    public List<string> eventChoices;
}

[System.Serializable]
public class EventList 
{
    public List<SingleEvent> Events;
}
    public TextAsset eventFile;
    public TMPro.TextMeshProUGUI eventTitle, eventDesc;
    public TMPro.TextMeshProUGUI choice1, choice2;

    public List<SingleEvent> myEventList;
    // Start is called before the first frame update
    void Start()
    {
        myEventList = new List<SingleEvent>();
        SingleEvent singleEvent = new SingleEvent();
        singleEvent.eventId = 1;
        singleEvent.eventTitle = "Help me";
        singleEvent.eventDescription = "fuck";
        singleEvent.eventChoices = new List<string>();
        singleEvent.eventChoices.Add("help");
        singleEvent.eventChoices.Add("test");
        myEventList.Add(singleEvent);
        Debug.Log(myEventList);
        Debug.Log(JsonUtility.ToJson(myEventList.ToString()));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
