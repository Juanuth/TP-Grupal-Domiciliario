using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResponderScript : MonoBehaviour
{
    public Text Texto1;
    public Text Texto2;
    public Text Texto3;
    public GameObject panel1;
    public GameObject panel2;
    public GameObject Canvas;
    public GameObject Canvas2;
  
    // Start is called before the first frame update
    void Start()
    {
        panel1.SetActive(false);
        panel2.SetActive(false);
      

    }
    
   
    public void Resultado()
    {

        if (System.Convert.ToInt32(Texto3.text) != System.Convert.ToInt32(Texto1.text) + System.Convert.ToInt32(Texto2.text))
        {

            panel1.SetActive(true);
            Canvas.SetActive(false);
            
        }
        else
        {
            panel2.SetActive(true);
            Canvas.SetActive(false);
        }
      

    
    }

        // Update is called once per frame
        void Update()
    {
        
    }

    public void LaunchGameScene()
    {
        SceneManager.LoadScene("RespuestaIncorrecta");
    }

    public void LoadGameScene()
    {
        SceneManager.LoadScene("RespuestaCorrecta");
    }

    public void StartGameScene()
    {
        SceneManager.LoadScene("RespuestaNula");
    }
}
