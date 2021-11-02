using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class lol2 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c2)
    {
        if (c2.gameObject.tag == "Jefe")
        {
            SceneManager.LoadScene("nivelFinal");
        }
    }
}
