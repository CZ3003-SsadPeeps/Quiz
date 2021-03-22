using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Database;
using System;

public class GetEvent : MonoBehaviour
{
    public List<EventRecord> events;
    public int currentEvent;
    public string eventText;
    public EventRecordDAO eventsDAO;

    public GetEvent()
    {
        this.currentEvent = 0;
    }
    void Start()
    {
        this.eventsDAO = new EventRecordDAO();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            Popup popup = UIController.Instance.CreatePopup();
            popup.Init(UIController.Instance.MainCanvas,
                eventText, //replace this line with retrieveEvent() after linking to database
                "Confirm");
        });
        EventRecord e1 = new EventRecord(1, "your earn is 1000", 1000);
        eventsDAO.addData(e1);
        EventRecord e2 = new EventRecord(2, "your earn is 0", 0);
        eventsDAO.addData(e2);
        EventRecord e3 = new EventRecord(3, "your loss is 1000", -1000);
        eventsDAO.addData(e3);
        events = eventsDAO.RetrieveEventRecords();
        retrieveEvent();
        
    }

    public void retrieveEvent()
    {
        currentEvent = UnityEngine.Random.Range(0, events.Count);
        this.eventText = events[currentEvent].Content;
        Debug.Log(currentEvent);
        events.RemoveAt(currentEvent);
    }
}
