using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sciptFinCinematica1 : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c1)
    {
        if(c1.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("nivel1");
        }
    }
}
