using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PrecioScript : MonoBehaviour
{
    public int Precio;
    public Text Texto;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Texto.text = Precio.ToString();
    }
}
