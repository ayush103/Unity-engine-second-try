using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropper : MonoBehaviour
{
    Rigidbody Rigidbody;
    MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started");
        Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.useGravity = false;
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
     if (Time.time > 5)
    {
        renderer.enabled = true;
        Rigidbody.useGravity = true;
        //Debug.Log(Time.time);
        
    }   
    }
}
