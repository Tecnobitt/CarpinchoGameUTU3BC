using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jefeScriptMov : MonoBehaviour
{
    [SerializeField]
    Transform player;

    [SerializeField]
    float agroRange;

    [SerializeField]
    float velocidad;

    Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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

    void PerseguirJugador()
    {
        if (transform.position.x < player.position.x)
        {
            rb2d.velocity = new Vector2(velocidad, 0);
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
        else
        {
            rb2d.velocity = new Vector2(-velocidad, 0);
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }

    void PararPJugador()
    {
        rb2d.velocity = Vector2.zero;
    }
}
