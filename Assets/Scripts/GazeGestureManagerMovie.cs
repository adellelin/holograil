using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR.WSA.Input;

public class GazeGestureManagerMovie : MonoBehaviour {

    public static GazeGestureManagerMovie instance { get; private set; }

    // hologram being gazed at
    public GameObject FocusedObject { get; private set; }

    GestureRecognizer recognizer;

    GameObject movieTop;
    GameObject movieBottom;
    private movieStart MovieTopStartObject;
    private movieStart MovieBottomStartObject;

    // Use this for initialization
    void Start () {

        instance = this;

        movieTop = GameObject.Find("MovieTop");
        movieBottom = GameObject.Find("MovieBottom");

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
                MovieTopStartObject = movieTop.GetComponent<movieStart>();
                MovieTopStartObject.PlayMovie();
            } else
            {
                MovieTopStartObject.PauseMovie();
            }

            if (FocusedObject == movieBottom)
            {
                MovieBottomStartObject = movieBottom.GetComponent<movieStart>();
                MovieBottomStartObject.PlayMovie();
            }
            else
            {
                MovieBottomStartObject.PauseMovie();
            }
            recognizer.CancelGestures();
            recognizer.StartCapturingGestures();
        }

    }

}
