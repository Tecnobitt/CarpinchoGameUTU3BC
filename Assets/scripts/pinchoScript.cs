using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pinchoScript : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var CARLOS = collision.GetComponent<control>();
        CARLOS?.Golpe();

        if(collision.gameObject.tag == "Jefe")
        {
            SceneManager.LoadScene("cinematica2");
        }
    }
}

