using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class träff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject låda = collision.gameObject;
        enemy fiende = låda.GetComponent<enemy>();
        if (fiende != null)
        {
            fiende.takedamage();
        }
        


    }
}
