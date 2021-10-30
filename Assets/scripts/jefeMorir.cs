using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class jefeMorir : MonoBehaviour
{
    int vidaJefe = 3;

    // Update is called once per frame
    void Update()
    {
        if(vidaJefe == 0)
        {
            SceneManager.LoadScene("tutorialInicio");
        }
    }

    void jefeGolpe()
    {
        vidaJefe--;
    }
}

