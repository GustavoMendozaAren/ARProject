using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    [SerializeField] private string url;
    [SerializeField] private string url2;

    public void OpenFacebook()
    {
        Application.OpenURL(url);
    }

    public void OpenPagina()
    {
        Application.OpenURL(url2);
    }
    public void ScanButton()
    {
        SceneManager.LoadScene(1);
    }
}
