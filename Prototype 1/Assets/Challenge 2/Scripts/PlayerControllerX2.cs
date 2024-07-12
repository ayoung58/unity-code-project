using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX2 : MonoBehaviour
{
    public GameObject dogPrefab;
    public float coolDownTime = 1.0f;
    private float coolDown;

    void Start() 
    {
        coolDown = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (coolDown > 0) {
            coolDown -= Time.deltaTime;
        }
        Debug.Log(coolDown);
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (coolDown <= 0) {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                coolDown = coolDownTime;
            }     
        }
    }
}
