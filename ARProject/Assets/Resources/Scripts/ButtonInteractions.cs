using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonInteractions : MonoBehaviour
{
    public GameObject boton;
    private bool botonVisible = false;
    public string MainMenu;

    public void MostrarOcultarBotonOnClick()
    {
        if (!botonVisible)
        {
            boton.SetActive(true);
            botonVisible = true;
        }
        else
        {          
            boton.SetActive(false);
            botonVisible = false;
        }
    }

    public void Regresar()
    {
        SceneManager.LoadScene(MainMenu);
    }    
}
