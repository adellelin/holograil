using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivationZoneManagerTom : MonoBehaviour
{
    public GameObject paintingActivationZonePosition;       //Public variable to store a reference to the painting game object
    public Light paintingActivationZoneLightObject;
    public GameObject sculptureActivationZonePosition;       //Public variable to store a reference to the sculpture game object
                                                             //public Light sculptureActivationZoneLightObject;
    public GameObject sculptureActivationZoneLightObject;
    public GameObject deskActivationZonePosition;       //Public variable to store a reference to the desk game object
    public Light deskActivationZoneLightObject;
    private Vector3 paintingActivationZoneOffset;         //Private variable to store the offset distance between the painting and camera
    private Vector3 sculptureActivationZoneOffset;         //Private variable to store the offset distance between the sculpture and camera
    private Vector3 deskActivationZoneOffset;         //Private variable to store the offset distance between the desk and camera
    private Vector3 viewerTransform;
    private bool paintingAudioTriggered = false;
    private bool sculptureAudioTriggered = false;

    //AudioClip paintingAudio;
    AudioSource paintingAudio;
    AudioSource sculptureAudio;


    // public Text PositionCamera;

    // Use this for initialization
    void Start()
    {

        paintingActivationZoneLightObject.enabled = false;
        sculptureActivationZonePosition.SetActive(false);
        sculptureActivationZoneLightObject.SetActive(false);
        deskActivationZoneLightObject.enabled = false;
        //Calculate and store the offset value by getting the distance between the player's position and camera's position.
        viewerTransform = transform.position;
        Debug.Log("viewerPosition: " + viewerTransform);
        paintingAudio = paintingActivationZonePosition.GetComponent<AudioSource>();

        Debug.Log("paintingaudio length" + paintingAudio.clip.length);
    }

    // Update is called once per frame
    void Update()
    {

        //Dynamic evaluation of distance to painting activation zone
        paintingActivationZoneOffset = transform.position - paintingActivationZonePosition.transform.position;

        if (Mathf.Abs(paintingActivationZoneOffset.x) < 2f)
        {
            paintingActivationZoneLightObject.enabled = true;

            if (!paintingAudioTriggered)
            {
                playPaintingAudio();
                paintingAudioTriggered = true;
            }
        }
        else
        {
            paintingActivationZoneLightObject.enabled = false;
            paintingAudio.Pause();
        }

        //Dynamic evaluation of distance to sculpture activation zone
        sculptureActivationZoneOffset = transform.position - sculptureActivationZonePosition.transform.position;
        //Debug.Log("sculptureoffset: "+sculptureActivationZoneOffset);
        if (Mathf.Abs(sculptureActivationZoneOffset.x) < 2f)
        {
            sculptureActivationZoneLightObject.SetActive(true);
            if (!sculptureAudioTriggered)
            {
                playSculptureAudio();
                sculptureAudioTriggered = true;
            }
        }
        else
        {
            sculptureActivationZoneLightObject.SetActive(false);
        }

        //Dynamic evaluation of distance to desk activation zone
        deskActivationZoneOffset = transform.position - deskActivationZonePosition.transform.position;

        if (Mathf.Abs(deskActivationZoneOffset.x) < 2f)
        {
            deskActivationZoneLightObject.enabled = true;
        }
        else
        {
            deskActivationZoneLightObject.enabled = false;
        }
    }

    private void playSculptureAudio()
    {
        sculptureAudio.Play();
        
    }

    private void playPaintingAudio()
    {

        paintingAudio.Play();
        Invoke("SculptureAppear", paintingAudio.clip.length);
    }

    void SculptureAppear()
    {
        sculptureActivationZonePosition.SetActive(true);
        paintingAudio.Stop();
    }
}
