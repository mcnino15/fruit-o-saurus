using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListLinked 
{
   public Nodo root = null;
   public Nodo current;
   public ListLinked()
   {
        root = null;
        
       
   }
   public void cambioDePregunta()
   {
        current = current.next;
   }
   public void agregarNodos(string pregunta, string respuesta)
   {
        Nodo nodo = new Nodo(pregunta, respuesta);
        
        if ( root == null){
                
           root = nodo;
           current = root;
           root.next = root;
           return;

        }else{
            Nodo p = root;
         
            while(p.next != root) {
                p = p.next;    
            }
            p.next = nodo;
            p.next.next = root;
        }
       
        
   }
    
}
