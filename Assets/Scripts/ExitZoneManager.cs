using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitZoneManager : MonoBehaviour {

    public Text exitText;
    void Start()
    {
        Debug.Log("Logging Collision script");
    }

	void OnTriggerEnter(Collider CollisionCube)
    {
        Debug.Log("Went through the exit");
        Renderer render = GetComponent<Renderer>();
        
        render.material.color = Color.cyan;
        SceneManager.LoadScene("VuforiaTest");
        exitText.text = "exited";

    }


}
