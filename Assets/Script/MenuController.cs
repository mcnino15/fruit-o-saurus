using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    [SerializeField] private Animator transicionAnim;
    [SerializeField] private AudioMixer audioMixer;
    public void musicControll(float slider)
    {
        audioMixer.SetFloat("VolumeMusic", Mathf.Log10(slider) * 20);
    }
    public void cambioDeEscena(string escena)
    {
        
        StartCoroutine(transiciona(escena));
    }
    IEnumerator transiciona(string scene)
    {
        transicionAnim.SetTrigger("Transicion");
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(scene);
    }
    public void salir() {
        Application.Quit();
    }
}
