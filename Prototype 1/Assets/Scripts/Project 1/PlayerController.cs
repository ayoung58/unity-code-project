using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float turnSpeed = 45.0f;
    private float horizontalInput;
    private float forwardInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // Move the vehicle forward
        // We could technically also use 0,0,1, but Vector3.forward is more readable
        // We use Time.deltaTime because Update is once per frame, but that depends on device
        // So, we want to do move based on time (i.e. seconds)
        // The code below is 0,0,1 per second, * 20, so 20 meters per second :)
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // if turnSpeed is negative, the car goes along left axis (car will face forward and slide with code below)
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);

        // We use Vector3.up since that is the Y-axis, and we want to rotate along that
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
    }
}
