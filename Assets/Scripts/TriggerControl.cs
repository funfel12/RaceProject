using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerControl : MonoBehaviour
{
    public GameObject CurrentTrigger, NextTrigger;
    public int TriggerCounter;


    public void OnTriggerEnter()
    {
        CurrentTrigger.SetActive(false);
        NextTrigger.SetActive(true);
        
    }
}
