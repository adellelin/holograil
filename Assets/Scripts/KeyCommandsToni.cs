using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KeyCommandsToni : MonoBehaviour {

    public Text ToniDoveBio;
    public GameObject ToniDoveStudio;
    public GameObject TomsStudio;

    // called by gazegesturemanager
    

    public void OnSelect()
    {
        if (ToniDoveStudio.activeSelf == false)
        {
            ToniDoveStudio.SetActive(true);
			gameObject.GetComponent<GazeGestureManagerTom>().enabled = false;
            TomsStudio.SetActive(false);
			ToniDoveStudio.GetComponent<AudioSource> ().Play ();
            //SceneManager.LoadScene("ToniDove");
            ToniDoveBio.text = "Toni Dove Bio ";
        }
       
    }
}
