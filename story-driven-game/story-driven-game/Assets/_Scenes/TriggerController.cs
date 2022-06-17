using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerController : MonoBehaviour {

    public GameObject myCanvas;

    void Start() 
    {
    }

    public void triggerPressed() {
        Debug.Log("Trigger is pressed weee!");

        Debug.Log(myCanvas);

        myCanvas.SetActive(true);
    }

    // doesn't work
    //public void triggerClicked() {
    //    Debug.Log("The trigger is clicked.");
    //}

    public void triggerReleased() {
        Debug.Log("Trigger is released! omg!");

        myCanvas.SetActive(false);
    }

    //left controller?
    public void triggerPressedLeft() {
        Debug.Log("Left controller press! Woah!");
    }
}
