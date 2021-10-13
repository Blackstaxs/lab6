using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatePlane : MonoBehaviour
{
    public GameObject fallingBall;
    public GameObject fallingBall2;
    private Quaternion defaultRotation;
    private Vector3 defaultBallPosition,defaultBallVelocity,defaultBallAngularVelocity;
    private Quaternion defaultRotation2;
    private Vector3 defaultBallPosition2, defaultBallVelocity2, defaultBallAngularVelocity2;
    private Rigidbody rb;
    private Rigidbody rb2;
    void Start() 
    { 
        rb = fallingBall.GetComponent<Rigidbody>(); 
        defaultBallPosition = rb.transform.position; 
        defaultBallVelocity = rb.velocity; 
        defaultBallAngularVelocity = rb.angularVelocity; 
        defaultRotation = transform.rotation;

        rb2 = fallingBall2.GetComponent<Rigidbody>();
        defaultBallPosition2 = rb2.transform.position;
        defaultBallVelocity2 = rb2.velocity;
        defaultBallAngularVelocity2 = rb2.angularVelocity;
        defaultRotation2 = transform.rotation;
    }
    void Update() 
    { 
        if (Input.GetKeyDown(KeyCode.Minus))  
        { 
            transform.Rotate(new Vector3(0, 0, 1), -2);
        } 
        else if(Input.GetKeyDown(KeyCode.Equals))
            { 
            transform.Rotate(new Vector3(0, 0, 1), 2);
        }
        if (Input.GetKeyDown("r")) 
        { 
            fallingBall.SetActive(true); 
            transform.rotation = defaultRotation; 
            rb.transform.position = defaultBallPosition; 
            rb.velocity = defaultBallVelocity; 
            rb.angularVelocity = defaultBallAngularVelocity;

            fallingBall2.SetActive(true);
            transform.rotation = defaultRotation2;
            rb2.transform.position = defaultBallPosition2;
            rb2.velocity = defaultBallVelocity2;
            rb2.angularVelocity = defaultBallAngularVelocity2;
        }
    }
}
