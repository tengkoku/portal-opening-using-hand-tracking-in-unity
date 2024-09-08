using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRecognizer : MonoBehaviour
{
    public Transform objectToTrack;
    public GameObject detectedPortalA;
    public GameObject detectedPortalB;
    private float previousYPosition;
    private bool numUp = false;
    private bool numDown = false;

    void Start()
    {
        detectedPortalA.SetActive(false); //false //true
        detectedPortalB.SetActive(false);
        previousYPosition = objectToTrack.position.y;
    }

    void Update()
    {
        float currentYPosition = objectToTrack.position.y;
        float deltaYPosition = currentYPosition - previousYPosition;

        if (deltaYPosition > 3)  //can modify to fit your game screen 
        {
           // Debug.Log("Object is moving up");
            numUp = true; 
        }
        else if (deltaYPosition < 0)
        {
           // Debug.Log("Object is moving down");
            numDown = true;
        }

        if (numUp && numDown )   //&& !circularMotionDetected
        {
            Debug.Log("Up: " + numUp);
            Debug.Log("Down: " + numDown);
            Debug.Log("Circular motion is detected");
            detectedPortalA.SetActive(true);
            detectedPortalB.SetActive(true);
        }

    }
}
