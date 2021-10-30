using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sumaVida : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    public void NosVimo()
    {
        Destroy(gameObject);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        var CARLOS = collision.GetComponent<control>();
        if (CARLOS!= null)
        {
            CARLOS.MasVida();
            NosVimo();
        }
    }
}
