using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    public static bool Pausado = false;

    public GameObject PausaUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Pausado)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        PausaUI.SetActive(false);
        Time.timeScale = 1f;
        Pausado = false;
    }

    void Pause()
    {
        PausaUI.SetActive(true);
        Time.timeScale = 0f;
        Pausado = true;
    }

    public void CargarMenu()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
        Time.timeScale = 1f;
    }

    public void CerrarJuego()
    {
        Application.Quit();
    }

    public void apretGuardar()
    {
        string activeScene = SceneManager.GetActiveScene().name;
        PlayerPrefs.SetString("NivelGuardado", activeScene);
        Debug.Log("Se guardo la escena " + activeScene);
    }
}
