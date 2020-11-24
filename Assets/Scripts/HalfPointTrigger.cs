using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject Trigger1;
    public int TriggerCounter;


    public void OnTriggerEnter()
    {


        Trigger1.SetActive(false);
        LapCompleteTrigger.SetActive(true);

    }
}
