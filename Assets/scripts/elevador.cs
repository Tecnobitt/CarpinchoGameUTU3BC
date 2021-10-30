using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevador : MonoBehaviour
{
    private float velocidad = 0f;
 
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f, velocidad, 0f);
    }

    private void OnCollisionEnter2D(Collision2D c1)
    {
        if (c1.gameObject.tag == "Player")
        {
            velocidad = 0.005f;
        }
     }
}

