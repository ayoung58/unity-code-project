using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    // add an offset so that the camera is above and behind vehicle
    // we need the new keyword to add the "new" Vector3 offset
    // we can now edit this offset in inspector :)
    public Vector3 offset = new Vector3(0, 8, -7);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // sets camera's position to player's position
        transform.position = player.transform.position + offset;
    }
}
