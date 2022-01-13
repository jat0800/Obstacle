using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer renderer;
    Rigidbody rigidBody;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidBody.useGravity = false;
    }
    void Update()
    {
        float time = Time.time;
        //Debug.Log("Time you play the game: " + time); //Debug.Log(Time.time);
        if (timeToWait < time)
        {
            renderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }
}
