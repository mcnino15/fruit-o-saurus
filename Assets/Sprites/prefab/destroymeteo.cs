using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroymeteo : MonoBehaviour
{

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Ground")
        {
            Destroy(gameObject);
        }
        if (col.gameObject.tag == "Basket")
        {
            
            Destroy(gameObject);
           
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
