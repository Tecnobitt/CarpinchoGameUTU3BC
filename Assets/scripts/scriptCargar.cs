using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scriptCargar : MonoBehaviour
{
    [SerializeField] private string newGameLevel;

    public void apretarLoad()
    {
        if (PlayerPrefs.HasKey("NivelGuardado"));
        string nivelACargar = PlayerPrefs.GetString("NivelGuardado");
        SceneManager.LoadScene(nivelACargar);
    }
}
