using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds2 : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > topBound) {
            Destroy(gameObject);
        } else if (transform.position.z < lowerBound) {
            // Basically, when an animal gets destroyed past the player, then we end game
            Debug.Log("Game Over!");
            Destroy(gameObject);
        }
    }
}
