using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    [SerializeField] float xAxis = 0, yAxis = 0.3f, zAxis = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAxis,yAxis,zAxis);
    }
}
