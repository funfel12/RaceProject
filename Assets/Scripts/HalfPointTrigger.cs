using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfPointTrigger : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;


    public void OnTriggerEnter(Collider other)
    {

        HalfLapTrigger.SetActive(false);
        LapCompleteTrigger.SetActive(true);
        print("Collision detected");
    }
}
