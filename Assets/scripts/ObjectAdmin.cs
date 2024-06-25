using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectAdmin : MonoBehaviour
{
    public GameObject[] objetos;

    public int numero;
    int mínimo = 1;
    int máximo = 8;


    // Start is called before the first frame update
    void Start()
    {

        DeactivateAll();
    }

    // Update is called once per frame
    void Update()
    {

    }
   void DeactivateAll();
    {
    for (int i = 0; i < objetos.Length; i++)
        
    }
}
}
