using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;
public class LinkedListCreator : MonoBehaviour
{
    StreamReader ArchiveMaker = new StreamReader("Assets/preguntirris.csv");
    ListLinked lista = new ListLinked();
    [SerializeField] private GameObject menuPregunta;
    [SerializeField] private GameObject gameOver;
    [SerializeField] Text pregunta;
    string preguntaStr = "";
    void Start()
    {
        gameOver.SetActive(false);
        string linea;
        while ((linea = ArchiveMaker.ReadLine()) != null)
        {
            
            string[] parts = linea.Split(";");
            
            lista.agregarNodos(parts[0], parts[1]);
        }
    }

    public void cambioDePregunta()
    {
        lista.cambioDePregunta();
    }
    void Update()
    {
        preguntaStr = lista.current.datos[0];
        pregunta.text = preguntaStr;
    }
    public void checker(string respuesta)
    {
        if (respuesta == lista.current.datos[1] )
        {
            Reanudar();
            menuPregunta.SetActive(false);
            //Implementar la accion necesaria una vez la persona respondio la respuesta correcta.
            lista.cambioDePregunta();
        }
        else
        {
            //Dado el caso que la persona se equivoque en la pregunta.
            menuPregunta.SetActive(false);
            gameOver.SetActive(true);
        }
    }


    public void Reanudar (){
        Time.timeScale = 1f;
    }
}
