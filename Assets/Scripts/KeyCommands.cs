using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KeyCommands : MonoBehaviour {

    // called by gazegesturemanager
    public void OnSelect()
    {
        SceneManager.LoadScene("SwitchTo");
    }
}
