using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpponentTrack : MonoBehaviour
{
    public GameObject Tracker;
    public GameObject Mark01;
    public GameObject Mark02;
    public GameObject Mark03;
    public GameObject Mark04;
    public GameObject Mark05;
    public GameObject Mark06;
    public GameObject Mark07;
    public GameObject Mark08;
    public int MarkCount;

    // Update is called once per frame
    void Update()
    {
        if(MarkCount == 0)
        {
            Tracker.transform.position = Mark01.transform.position;
        }

        if (MarkCount == 1)
        {
            Tracker.transform.position = Mark02.transform.position;
        }

        if (MarkCount == 2)
        {
            Tracker.transform.position = Mark03.transform.position;
        }

        if (MarkCount == 3)
        {
            Tracker.transform.position = Mark04.transform.position;
        }

        if (MarkCount == 4)
        {
            Tracker.transform.position = Mark05.transform.position;
        }

        if (MarkCount == 5)
        {
            Tracker.transform.position = Mark06.transform.position;
        }

        if (MarkCount == 6)
        {
            Tracker.transform.position = Mark07.transform.position;
        }

        if (MarkCount == 7)
        {
            Tracker.transform.position = Mark08.transform.position;
        }
    }

    IEnumerator OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.tag=="Opponent01")
        {
            this.GetComponent<BoxCollider>().enabled = false;
            MarkCount += 1;
            if(MarkCount == 8)
            {
                MarkCount = 0;
            }
            yield return new WaitForSeconds(1);
            this.GetComponent<BoxCollider>().enabled = true;
        }
    }
}
