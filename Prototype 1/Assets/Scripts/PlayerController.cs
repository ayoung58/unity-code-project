using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        // We could technically also use 0,0,1, but Vector3.forward is more readable
        // We use Time.deltaTime because Update is once per frame, but that depends on device
        // So, we want to do move based on time (i.e. seconds)
        // The code below is 0,0,1 per second, * 20, so 20 meters per second :)
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
