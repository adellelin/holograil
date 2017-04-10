using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class GazeGestureMaanger : MonoBehaviour {

    public static GazeGestureMaanger instance { get; private set; }

    // hologram being gazed at
    public GameObject FocusedObject { get; private set; }

    GestureRecognizer recognizer;

    GameObject movieTop;
    private movieStart MovieStartObject;
   

    // Use this for initialization
    void Start () {

        instance = this;

        movieTop = GameObject.Find("MovieTop");

        // set up a gesture recognizer to detect select gestures
        recognizer = new GestureRecognizer();
        recognizer.TappedEvent += (source, tapCount, ray) =>
        {
            // send an onselect message to the focused object and its ancestors.
            if (FocusedObject != null)
            {
                FocusedObject.SendMessageUpwards("OnSelect");
            }
        };
        recognizer.StartCapturingGestures();	
	}
	
	// Update is called once per frame
	void Update () {
        GameObject oldFocusedObject = FocusedObject;

        // do raycast into world based on user's head position
        var headPosition = Camera.main.transform.position;
        var gazeDirection = Camera.main.transform.forward;

        RaycastHit hitInfo;

        if (Physics.Raycast(headPosition, gazeDirection, out hitInfo))
        {
            FocusedObject = hitInfo.collider.gameObject;
            
        } else
        {
            // if the raycast did no hit holo, clear focused object
            FocusedObject = null;
        }

        // if the focused object changed, start detecting fresh gestures
        if (FocusedObject != oldFocusedObject)
        {

            if (FocusedObject == movieTop)
            {
                MovieStartObject = movieTop.GetComponent<movieStart>();
                MovieStartObject.PlayMovie();
            } else
            {
                MovieStartObject.PauseMovie();
            }
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }

    }
}
