using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class LogicaCambioEscena : MonoBehaviour
{
    public bool cambio;
    public int indice;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CambiarEscena(indice);
        }

        if(cambio)
        {
            CambiarEscena(indice);
        }
    }

    public void CambiarEscena(int indice)
    {
        SceneManager.LoadScene(indice);
    }

    public void Salir()
    {
        Application.Quit();
    }
}
