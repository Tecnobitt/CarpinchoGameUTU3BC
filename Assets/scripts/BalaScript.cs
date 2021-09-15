using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaScript : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;
    public float velocity;

    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Rigidbody2D.velocity = Direction * velocity;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }

    public void ChauBala()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        control CARLOS = collision.GetComponent<control>();
        plantaScript planta = collision.GetComponent<plantaScript>();
        if (CARLOS != null)
        {
            CARLOS.Golpe();
        }
        ChauBala();
    }


}
