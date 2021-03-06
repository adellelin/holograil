﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyCommandsToni : MonoBehaviour {

    public Text ToniDoveBio;
    public GameObject ToniDoveStudio;
    public GameObject TomsStudio;
    public GameObject MovieBottom;
    public GameObject KeyScene;
    public GazeGestureManagerToni gazeToni;
    public GazeGestureManager gazeKeyScene;
    public ActivationZoneManagerToni activationZoneToni;
    public ActivationZoneManagerTom activationZoneTom;

    // called by gazegesturemanager

    public void OnSelect()
    {
        if (ToniDoveStudio.activeSelf == false)
        {
            MovieBottom.SetActive(true);
            ToniDoveStudio.SetActive(true);
            KeyScene.SetActive(false);
            activationZoneTom.enabled = false;
            activationZoneToni.enabled = true;
          
            gazeKeyScene.enabled = false;
       
            
            TomsStudio.SetActive(false);
           
            ToniDoveStudio.GetComponent<AudioSource> ().Play();
            //SceneManager.LoadScene("ToniDove");
            ToniDoveBio.text = "Toni Dove Bio ";
            //gazeToni.enabled = true;


        }

       

    }
}
