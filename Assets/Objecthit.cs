using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objecthit : MonoBehaviour
{

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            gameObject.tag = "Hit";
        }//Debug.Log("Boom");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
