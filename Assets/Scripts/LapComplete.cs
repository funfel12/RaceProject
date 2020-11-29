using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapComplete : MonoBehaviour
{
    public GameObject LapCompleteTrigger;
    public GameObject HalfLapTrigger;

    public GameObject MinuteDisplay, SecondDisplay, MilliSecDisplay;

    public GameObject LapTimeBox;

    public GameObject LapCounter;
    public int LapsDone;

    void OnTriggerEnter(Collider collision)
    {
        LapsDone++;
        if(collision.gameObject.tag != "Opponent01")
        {
        MilliSecDisplay.GetComponent<Text>().text = "" + LapTimeManager.milliSecCount;
        if (LapTimeManager.secondCount <= 9)
        {
            SecondDisplay.GetComponent<Text>().text = "0" + LapTimeManager.secondCount + ".";
        }
        else
        {
            SecondDisplay.GetComponent<Text>().text = "" + LapTimeManager.secondCount + ".";
        }

        if (LapTimeManager.minuteCount <= 9)
        {
            MinuteDisplay.GetComponent<Text>().text = "0" + LapTimeManager.minuteCount + ":";
        }
        else
        {
            MinuteDisplay.GetComponent<Text>().text = "" + LapTimeManager.minuteCount + ":";
        }

        print(LapTimeManager.minuteCount + ":" + LapTimeManager.secondCount + "." + LapTimeManager.milliSecCount);
        LapTimeManager.minuteCount = 0;
        LapTimeManager.secondCount = 0;
        LapTimeManager.milliSecCount = 0;
        LapCounter.GetComponent<Text>().text = "" + LapsDone;

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

        }

        
    }

}
