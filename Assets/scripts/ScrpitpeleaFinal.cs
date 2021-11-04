using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScrpitpeleaFinal : MonoBehaviour
{
    public void ApretarSi()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("PANTALLAFINAL");
    }

    public void ApretarNo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("nivelFinal");
    }
}
