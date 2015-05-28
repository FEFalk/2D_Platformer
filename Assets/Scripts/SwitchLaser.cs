﻿using UnityEngine;
using System.Collections;

public class SwitchLaser : MonoBehaviour {

    public GameObject currentLaser;
    public Material redLaser, greenLaser, blueLaser;
    void Update()
    {

    }

    public void Switch(float newSpeed)
    {
        GameObject Laser = transform.parent.gameObject.transform.Find("Laser").gameObject;
        if (newSpeed == 0)
        {
            
            if (GetComponent<GreenLaser>().activated == false)
            {
                Laser.GetComponent<LineRenderer>().material = blueLaser;
                GetComponent<GreenLaser>().enabled = false;
                GetComponent<PlayerShoot>().enabled = true;
                GetComponent<RedLaser>().enabled = false;
            }
            if (currentLaser != null)
            {
                if (currentLaser.GetComponent<GreenLaser>().activated == false)
                {
                    currentLaser.GetComponent<GreenLaser>().enabled = false;
                    currentLaser.GetComponent<PlayerShoot>().enabled = true;
                    currentLaser.GetComponent<RedLaser>().enabled = false;
                }
            }
        }

        else if (newSpeed == 1)
        {
           
            if (GetComponent<GreenLaser>().activated == false)
            {
                Laser.GetComponent<LineRenderer>().material = greenLaser;
                GetComponent<GreenLaser>().enabled = true;
                GetComponent<PlayerShoot>().enabled = false;
                GetComponent<RedLaser>().enabled = false;
            }
            if (currentLaser != null)
            {
                if (currentLaser.GetComponent<GreenLaser>().activated == false)
                {
                    currentLaser.GetComponent<GreenLaser>().enabled = true;
                    currentLaser.GetComponent<PlayerShoot>().enabled = false;
                    currentLaser.GetComponent<RedLaser>().enabled = false;
                }
            }

        }
        else if (newSpeed == 2)
        {
            
            if (GetComponent<GreenLaser>().activated == false)
            {
                Laser.GetComponent<LineRenderer>().material = redLaser;
                GetComponent<GreenLaser>().enabled = false;
                GetComponent<PlayerShoot>().enabled = false;
                GetComponent<RedLaser>().enabled = true;
            }
            if (currentLaser != null)
            {
                if (currentLaser.GetComponent<GreenLaser>().activated == false)
                {

                    currentLaser.GetComponent<GreenLaser>().enabled = false;
                    currentLaser.GetComponent<PlayerShoot>().enabled = false;
                    currentLaser.GetComponent<RedLaser>().enabled = true;
                }
            }
        }
    }
}
