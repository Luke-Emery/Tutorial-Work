// PROJECT:                             TutorialWork
// FILE NAME:                           pickUpControl
// NAME:                                Luke Emery
// COMPANY:                             Figment Productions
// VERSION:                             1.0
// DATE CREATED:                        26/09/2016
// DATE MODIFIED:                       
// MODIFICATIONS:
// CHANGE LOG:
// NOTES:

using UnityEngine;
using System.Collections;

public class pickUpControl : MonoBehaviour
{

    // FUNCTION:                        Update
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         applies a rotation to the object each frame
    // KEY VARIABLES:                   
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         
    void Update ()
    {
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
	}
}
