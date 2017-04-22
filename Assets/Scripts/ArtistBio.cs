using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtistBio : MonoBehaviour {

    public GameObject BioText;

    private bool isActive = false;
    // Use this for initialization
    void Start () {

            BioText.SetActive(false);
   
    }

    private void Update()
    {
        if (isActive)
        {
            BioText.SetActive(true);
        }
        else
        {
            BioText.SetActive(false);
        }
    }
    public void OnSelect()
    {

        //BioText.SetActive(true);
        isActive = !isActive;
    }
}
