using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class BallFactory : MonoBehaviour
{

    public GameObject BallObject;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // This method manufactures a new cube by cloning the Cube object and placing it under the Cube Factory object
    //  where it will fall to the ground by gravity
    public GameObject MakeBall()
    {
        if (BallObject)
        {
            GameObject newBall = Instantiate(BallObject) as GameObject;
            Vector3 ballpos = new Vector3(0.125f, 0.33f, 0.125f);
            newBall.transform.position = ballpos;
            newBall.layer = 10;  //Grabbable

            // Must not have glueable tag on creation or wonky stuff happens
            newBall.tag = "Ball";

            return newBall;
        }

        return null;
    }


    private void Update()
    {
     
    }

    public void Fire(InputAction.CallbackContext context)
    {
        Debug.Log("Fire!");
    }
}