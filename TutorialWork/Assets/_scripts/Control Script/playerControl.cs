// PROJECT:                             TutorialWork
// FILE NAME:                           playerControl
// NAME:                                Luke Emery
// COMPANY:                             Figment Productions
// VERSION:                             1.0
// DATE CREATED:                        26/09/2016
// DATE MODIFIED:                       
// MODIFICATIONS:
// CHANGE LOG:
// NOTES:

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

//Class to control the player
public class playerControl : MonoBehaviour
{
    //Class Variables
    private Rigidbody rb;
    private int nPickUpCount;

    public float flSpeed;
    public Text txtPickUpCount;
    public Text txtWin;


    // FUNCTION:                        getPickUpCount
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         FixedUpdate used due to being called before physics calculactions 
    // KEY VARIABLES:                   nPickUpCount
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         Update is called before rendering frame therefore game code goes there
    void FixedUpdate()
    {
        //Local Variables
        float flMoveHorz = Input.GetAxis("Horizontal");
        float flMoveVert = Input.GetAxis("Vertical");
        Vector3 vecMovement = new Vector3(flMoveHorz, 0.0f, flMoveVert);

        //Add force determined by variable declarations
        rb.AddForce(vecMovement * flSpeed);
    }

    // FUNCTION:                        getPickUpCount
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         To return amount of items picked up
    // KEY VARIABLES:                   nPickUpCount
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         
    public int getPickUpCount ()
    {
        return nPickUpCount;
    }


    // FUNCTION:                        onTriggerEnter
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         Function will deactivate the "other" a reference to the object touched.
    // KEY VARIABLES:                   
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("pickUp"))
        {
            other.gameObject.SetActive(false);
            nPickUpCount++;
            setCountText();
        }
    }


    // FUNCTION:                        Start
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         
    // KEY VARIABLES:                   
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         
    void Start()
    {
        //Initialising items
        rb = GetComponent<Rigidbody>();
        nPickUpCount = 0;
        setCountText();
        txtWin.text = "";
    }


    // FUNCTION:                        setCountText
    // NAME:                            Luke Emery
    // COMPANY:                         Figment Productions
    // VERSION AND DATE:                27/09/2016
    // PURPOSE:                         Updates both the count and win text
    // KEY VARIABLES:                   
    // FUNCTIONS AND LIBRARIES:         
    // MODIFICATIONS AND NOTES:         
    void setCountText()
    {
        txtPickUpCount.text = "Pick Ups: " + nPickUpCount.ToString();

        if (nPickUpCount >= 4)
        {
            txtWin.text = "You Win!";
        }

    }
}
