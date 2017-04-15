using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitZoneManager : MonoBehaviour {

    void Start()
    {
        Debug.Log("Logging Collision script");
    }

	void OnTriggerEnter(Collider CollisionCube)
    {
        Debug.Log("Collision Detected");
        Renderer render = GetComponent<Renderer>();
        render.material.color = Color.cyan;
        SceneManager.LoadScene("VuforiaTest");

    }


}
