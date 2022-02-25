using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    int count = 0, score = 0;
    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.tag != "Hit"){
            score++;
            Debug.Log(score);
        }
        count += 1;
        if (count % 4 == 0)
        {
            GetComponent<MeshRenderer>().material.color = Color.red;            
        }
        else if (count % 4 == 1)
        {
            GetComponent<MeshRenderer>().material.color = Color.blue;
        }
        else if (count % 4 == 2)
        {
            GetComponent<MeshRenderer>().material.color = Color.black;
        }
        else
        {
            GetComponent<MeshRenderer>().material.color = Color.green;
        }
    }

    void Start()
    {
    }
    float xvalue = 0f, yvalue = 0f, zvalue = 0f, movementspeed = 10;
    // Update is called once per frame
    void Update()
    {
        moveplayer();       
    }
    void  moveplayer(){
        xvalue = Input.GetAxis("Horizontal")*Time.deltaTime*movementspeed;
        yvalue = Input.GetAxis("Jump")*Time.deltaTime*movementspeed;
        zvalue = Input.GetAxis("Vertical")*Time.deltaTime*movementspeed;
        transform.Translate(xvalue,yvalue,zvalue); 
    }
}
