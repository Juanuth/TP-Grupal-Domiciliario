using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameScript : MonoBehaviour
{

    public GameObject[] derecha;
    public GameObject[] izquierda;
    public int precioIzq;
    public int precioDer;

    // Start is called before the first frame update
    void Start()
    {
        
        DeactivateAll();
        ActivateRandom();
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DeactivateAll()
    {
        for (int i = 0; i < derecha.Length; i++)
        {

            derecha[i].SetActive(false);

        }
        for (int i = 0; i < izquierda.Length; i++)
        {
            izquierda[i].SetActive(false);
        }

    }
    public void ActivateRandom()
    {
        int random = Random.Range(0, derecha.Length);
        derecha[random].SetActive(true);
        
        int random1 = Random.Range(0, izquierda.Length);
        izquierda[random1].SetActive(true);

    }


}