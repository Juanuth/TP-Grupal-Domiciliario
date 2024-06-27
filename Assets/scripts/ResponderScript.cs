using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResponderScript : MonoBehaviour
{
    public Text Texto1;
    public Text Texto2;
    // Start is called before the first frame update
    void Start()
    {
      

    }
   
    public void OnButtonpressed()
    {
        float Texto3 = System.Convert.ToInt32(Texto1.text) + System.Convert.ToInt32(Texto2);

        if (Texto3 != System.Convert.ToInt32(Texto1.text) + System.Convert.ToInt32(Texto2))
        {
            Debug.Log("resultado incorrecto");
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
