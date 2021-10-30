using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptMuerte : MonoBehaviour
{
    public void apretarRetry()
    {
        var escena = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(escena.ToString());
        Time.timeScale = 1f;
    }

    public void apretarMenu()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
    }
}
