using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class botonOpc : MonoBehaviour
{
    public void ApretarTuerca()
    {
        SceneManager.LoadScene("MENUOPCIONES");
    }

    public void ApretarBoton()
    {
        SceneManager.LoadScene("MENUPRINCIPAL");
    }
}


