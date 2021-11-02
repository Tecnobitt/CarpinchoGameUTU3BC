using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ratonMov : MonoBehaviour
{
    public GameObject carlitos;
    public GameObject BalaPrefab;
    private float UltimoBalazo;

    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float velocidad;

    Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (carlitos == null) return;
        var direction = carlitos.transform.position - transform.position;
        transform.localScale = new Vector3(direction.x >= 0.0f ? -1f : 1f, 1f, 1.0f);
        if (Time.time > UltimoBalazo + 0.7f)
        {
            Balazo();
            UltimoBalazo = Time.time;
        }

        {
            float distToCarlos = Vector2.Distance(transform.position, player.position);

            if (distToCarlos < agroRange)
            {
                //persiga al carlitos
                PerseguirJugador();
            }
            else
            {
                //para de perseguirlo
                PararPJugador();
            }
        }
    }

    private void Balazo()
    {
        var direction = transform.localScale.x == 5.0f ? Vector3.left : Vector3.right;
        var bala = Instantiate(BalaPrefab, transform.position + direction * 1, Quaternion.identity);
        bala.GetComponent<bolaScript>().SetDirection(direction);
    }

    void PerseguirJugador()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(-velocidad, 0);
        }
        else
        {
            rb2d.velocity = new Vector2(velocidad, 0);
        }
    }

    void PararPJugador()
    {
        rb2d.velocity = Vector2.zero;
    }
}
