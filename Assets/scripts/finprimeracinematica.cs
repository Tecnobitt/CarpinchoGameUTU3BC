using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finprimeracinematica : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D c1)
    {
        if (c1.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("cinematica0p2");
        }
    }
}
