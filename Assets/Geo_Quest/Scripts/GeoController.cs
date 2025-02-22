using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

//string str = "Hello World";

public class GeoController : MonoBehaviour
{
    string str = "Hello ";
    string str2;
    public int newint = 5;
    double new_val = 3.65d;
    private Rigidbody2D rb;
    public string nextLevel = "Scene2";

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        str2 = "World";
        Debug.Log(str + str2);
        //Debug.Log(new_val);
        //newint = 6;
    }

    // Update is called once per frame
    void Update()
    {
        /*Debug.Log(new_val);
        new_val++;*/
        //transform.position += new Vector3(0.005f, 0, 0);
        
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.position += new Vector3(0, 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1, 0);
        }
        /*
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity += new Vector2(-2, rb.velocity.y);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            rb.velocity += new Vector2(2, rb.velocity.y);
        }
        */

        float xInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(xInput * newint, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Hit");
        switch (collision.tag)
        {
            case "Death":
                {
                    string thisLevel = SceneManager.GetActiveScene().name;
                    SceneManager.LoadScene(thisLevel);
                    break;
                }
            case "Finish":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
