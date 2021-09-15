using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonIniciar : MonoBehaviour
{
    public void BotonApretar()
    {
        SceneManager.LoadScene("tutorialInicio");
    }
  

}
