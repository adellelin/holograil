using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyCommandsTom : MonoBehaviour {

    public Text TomsBio;
    public GameObject ToniDoveStudio;
    public GameObject TomsStudio;

    // called by gazegesturemanager
    

    public void OnSelect()
    {
        if (TomsStudio.activeSelf == false)
        {
            ToniDoveStudio.SetActive(false);
			gameObject.GetComponent<GazeGestureManagerToni>().enabled = false;
            TomsStudio.SetActive(true);
			TomsStudio.GetComponent<AudioSource> ().Play ();
            //SceneManager.LoadScene("ToniDove");
            TomsBio.text = "Tom Shannon Bio ";
        }
       
    }
}
