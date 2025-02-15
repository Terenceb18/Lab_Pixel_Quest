using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//string str = "Hello World";

public class GeoController : MonoBehaviour
{
    string str = "Hello ";
    string str2;
    public int newint = 5;
    double new_val = 3.65d;

    // Start is called before the first frame update
    void Start()
    {
        str2 = "World";
        Debug.Log(str + str2);
        //Debug.Log(new_val);
        //newint = 6;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(new_val);
        new_val++;
    }
}
