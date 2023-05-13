using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nodo 
{
    public string [] datos = new string [2];
    public Nodo next = null;
    public Nodo(string pregunta, string respuesta)
    {
        datos[0] = pregunta;
        datos[1]= respuesta;
    }

}
