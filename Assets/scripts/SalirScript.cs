using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SalirScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(LaunchGameScene), 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LaunchGameScene()
    {
        SceneManager.LoadScene("SeleccionarJuegos");
    }
}
