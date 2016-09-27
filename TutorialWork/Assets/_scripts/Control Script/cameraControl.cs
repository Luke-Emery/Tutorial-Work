// PROJECT:                             TutorialWork
// FILE NAME:                           cameraControl
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

public class cameraControl : MonoBehaviour
{
    //Class Variables
    private Vector3 vecOffset;
    private Vector3 vecGoToEndPos;
    private bool bGameOver;

    public playerControl scrptPlayer; 
    public GameObject player;


    // FUNCTION:                        Start
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         
    // KEY VARIABLES:                   vecOffset, vecGoToEnd
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         Used for initilisation
    void Start ()
    {
        vecOffset = transform.position - player.transform.position;
        vecGoToEndPos.Set(0.0f, 16.5f, 0.0f);
        bGameOver = false;
	}


    // FUNCTION:                        LateUpdate
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         
    // KEY VARIABLES:                   bGameOver, vecGoToEnd
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         LateUpdate called once per frame
    void LateUpdate ()
    {
        if (scrptPlayer.getPickUpCount() >= 4 && bGameOver == false)
        {
            transform.position = vecGoToEndPos;
            transform.Rotate(65, 0, 0);
            bGameOver = true;
        }
        else if (bGameOver == false)
        {
            transform.position = player.transform.position + vecOffset;
        }
    }
}
