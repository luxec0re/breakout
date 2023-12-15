using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [SerializeField]
    GameObject boxes;
    int hp = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void takedamage()
    {
        hp -= 1;
        if (hp == 0)
        {
            Destroy(gameObject);
        }

      
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
