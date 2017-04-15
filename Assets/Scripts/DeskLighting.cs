using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeskLighting : MonoBehaviour {
    public GameObject deskPosition;       //Public variable to store a reference to the player game object
    public Light deskLightObject;
    private Vector3 deskOffset;         //Private variable to store the offset distance between the player and camera
   // public Text PositionCamera;

    // Use this for initialization
    void Start () {

        deskLightObject.enabled = false;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        //deskOffset = transform.localPosition - deskPosition.transform.localPosition;
        //deskLightObject = new GameObject("TheLight");
        //Light lightComp = deskLightObject.AddComponent<Light>();
        //lightComp.color = Color.blue;
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider CollisionCube)
    {
        deskLightObject.enabled = true;

    }

    // LateUpdate is called after Update each frame
    void LateUpdate()
    {
        // Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
        //deskLightObject.transform.localPosition = deskPosition.transform.localPosition + new Vector3(0, 2, 0);
        //deskLightObject.transform.localPosition = new Vector3(0, 0, 0);
        Debug.Log(transform.localPosition);
       // PositionCamera.text = transform.localPosition.ToString();
    }
}
