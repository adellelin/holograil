using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestureHandler : MonoBehaviour {

    private bool isActive = false;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (isActive)
        {
            this.transform.Rotate(.5f, 1, .5f);
        }	


	}

    void OnAirTapped()
    {
        isActive = !isActive;
    }
}
