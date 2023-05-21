using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScr : MonoBehaviour
{
    public GameObject options;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        SceneManager.LoadScene("Juego");

    }

    public void OptionsOn(){
        options.SetActive(true);

    }

    public void OptionsOff(){
        options.SetActive(false);

    }

    public void Exit(){
      

    }
}
