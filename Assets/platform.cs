using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        myrigidbody2D = GetComponent < Rigidbody2D >();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            myrigidbody2D.velocity = new Vector2(-6, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            myrigidbody2D.velocity = new Vector2(6, 0);
        }
        else
        {
            myrigidbody2D.velocity = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey (KeyCode.D))
        {
            myrigidbody2D.velocity = new Vector2(0, 0);
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.Space))
        {
            myrigidbody2D.AddForce(new Vector2 (-10,0), ForceMode2D.Impulse);
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space))
        {
            myrigidbody2D.AddForce(new Vector2(10, 0), ForceMode2D.Impulse);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
