using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puntaje : MonoBehaviour
{
    private float puntos;
    [SerializeField]private Text text;
    [SerializeField]
    private void Start()
    {
        
        
    }
    
    private void Update()
    {
        
        text.text = puntos.ToString();
    }

    public void SumarPuntos (float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
