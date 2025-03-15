using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_movment : MonoBehaviour
{
    public float s = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, s, 0);
    }
}
