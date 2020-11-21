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

    void OnTriggerEnter()
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

        HalfLapTrigger.SetActive(true);
        LapCompleteTrigger.SetActive(false);

        
    }

}
