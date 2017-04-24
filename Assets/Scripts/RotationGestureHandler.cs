﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationGestureHandler : MonoBehaviour {

    private bool isActive = false;
    

	// Use this for initialization
	void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
        //this.transform.Rotate(0, 0, 0.5f);
        //this.transform.GetChild(0).Rotate(0, 0, 1f);

        if (isActive)
        {
            this.transform.Rotate(0, 0, 1f);
            this.transform.GetChild(0).Rotate(0, 0, 1f);
        }
	}
    /*
    void OnAirTapped()
    {
        isActive = !isActive;
    }*/
    void OnSelect()
    {
        isActive = !isActive;
    }
}