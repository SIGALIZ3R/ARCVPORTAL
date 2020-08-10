using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float x, y, z;
    Vector3 vect;
        
    void Start()
    {}

    void Update()
    {
        vect = new Vector3(x, y, z);
        transform.Rotate(vect * Time.deltaTime);
    }
}
