using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basket : MonoBehaviour
{
    [SerializeField]private puntaje puntaje;

     void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Fruit")
        {
            puntaje.SumarPuntos(50);
            Destroy(col.gameObject);
        }

       
    }
    
}
