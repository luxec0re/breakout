using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boll : MonoBehaviour
{
    Rigidbody2D myrigidbody2D;
    
    // Start is called before the first frame update
    void Start()
    {
        float start = Random.Range(-3, 3);
        myrigidbody2D = GetComponent<Rigidbody2D>();
        myrigidbody2D.AddForce(new Vector2 (start, -10));
    }

    // Update is called once per frame
    void Update()
    {
        float start = Random.Range(-3, 3);
        float speed = 6;

        myrigidbody2D.velocity = myrigidbody2D.velocity.normalized * speed;

        if(transform.position.y <= -4.1f)
        {
            transform.position = new Vector2(start, -0.5f);
        }
    }
}
