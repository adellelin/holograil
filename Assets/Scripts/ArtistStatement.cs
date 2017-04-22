using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtistStatement : MonoBehaviour {

    public GameObject StatementText;
    private bool isActive = false;
    // Use this for initialization
    void Start () {
        StatementText.SetActive(false);
    }




    private void Update()
    {
        if (isActive)
        {
            StatementText.SetActive(true);
        }
        else
        {
            StatementText.SetActive(false);
        }
    }
    public void OnSelect()
    {

        //BioText.SetActive(true);
        isActive = !isActive;
    }
}
