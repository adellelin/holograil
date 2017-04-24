using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArtistStatement : MonoBehaviour
{

    public GameObject StatementText;
    private bool isActive = false;
    // Use this for initialization
    void Start()
    {
        StatementText.SetActive(true);
    }

    private void Update()
    {
        if (isActive)
        {
            Debug.Log("is active");
            StatementText.SetActive(true);
            gameObject.GetComponent<AudioSource>().Play();
        }
        else
        {
            //StatementText.SetActive(false);
        }
    }
    public void OnSelect()
    {
        Debug.Log("statement selected");
        //BioText.SetActive(true);
        isActive = !isActive;
        StatementText.SetActive(true);
        gameObject.GetComponent<AudioSource>().Play();

    }


}
