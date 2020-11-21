using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LapTimeManager : MonoBehaviour
{
    public static int minuteCount, secondCount;
    public static float milliSecCount;
    public static string milliDisplay;

    public GameObject MinuteBox, SecondBox, MilliBox;

    void Update()
    {
        milliSecCount += Time.deltaTime * 10;
        milliDisplay = milliSecCount.ToString("F0");
        MilliBox.GetComponent<Text>().text = "" + milliDisplay;

        if(milliSecCount >= 10)
        {
            milliSecCount = 0;
            secondCount += 1;
        }

        if(secondCount <=9)
        {
            SecondBox.GetComponent<Text>().text = "0" + secondCount + ".";
        }
        else
        {
            SecondBox.GetComponent<Text>().text = "" + secondCount + ".";
        }

        if(secondCount >= 60)
        {
            minuteCount += 1;
            secondCount = 0;
        }

        if(minuteCount <= 9)
        {
            MinuteBox.GetComponent<Text>().text = "0" + minuteCount.ToString() + ":";
        }
        else
        {
            MinuteBox.GetComponent<Text>().text = "" + minuteCount.ToString() + ":";
        }
    }
}
