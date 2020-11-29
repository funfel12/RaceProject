using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public GameObject NormalCam;
    public GameObject FarCam;
    public GameObject FPCam;
    public int CamMode;


    void Update()
    {
        if (Input.GetButtonDown("Viewmode"))
        {
            if (CamMode == 2)
            {
                CamMode = 0;
            }
            else { CamMode++; }

            StartCoroutine(ModeChange());

        }
    }
    IEnumerator ModeChange()
    {
        yield return new WaitForSeconds(0.01f);
        if (CamMode == 0)
        {
            NormalCam.SetActive(true);
            FPCam.SetActive(false);
        }
        if (CamMode == 1)
        {
            NormalCam.SetActive(false);
            FarCam.SetActive(true);
        }
        if (CamMode == 2)
        {
            FarCam.SetActive(false);
            FPCam.SetActive(true);
        }
    }
}
