using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReiniciarScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Invoke(nameof(LaunchGameScene), 1);
    }

    public void LaunchGameScene()
    {
        SceneManager.LoadScene("Juego");
    }
}
