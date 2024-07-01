using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Move the vehicle forward
        // We could technically also use 0,0,1, but Vector3.forward is more readable
        transform.Translate(Vector3.forward);
    }
}
