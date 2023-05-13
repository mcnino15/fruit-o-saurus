using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuOver : MonoBehaviour
{
   

 public void MainMenu()
 {
    SceneManager.LoadScene("MainMenu");
 }

 public void restart()
 {
        Time.timeScale = 1f;
        SceneManager.LoadScene("SampleScene");
 }
 public void Salir()
 {
    
    Application.Quit();
 }
}
