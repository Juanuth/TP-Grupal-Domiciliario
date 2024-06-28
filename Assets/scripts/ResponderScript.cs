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
    // Start is called before the first frame update
    void Start()
    {
      

    }
   
    public void Resultado()
    {

        if (System.Convert.ToInt32(Texto3.text) != System.Convert.ToInt32(Texto1.text) + System.Convert.ToInt32(Texto2.text))
        {
            Invoke(nameof(LaunchGameScene), 1);
        }
        else
        {
            Invoke(nameof(LoadGameScene), 1);
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
}
