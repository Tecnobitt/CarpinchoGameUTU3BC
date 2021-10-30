using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pisar : MonoBehaviour
{
    public float force;
    bool pisado = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var CARLOS = collision.GetComponent<control>();
            Rigidbody2D Rigidbody2D = collision.GetComponent<Rigidbody2D>();
            Rigidbody2D.AddForce(Vector2.up * force);
            pisado = true;
            BoxCollider2D boxCollider = transform.parent.gameObject.GetComponent<BoxCollider2D>();
            boxCollider.enabled = false;
            
        }
    }

    void OnBecameInvisible()
    {
        if (pisado == true)
        {
            Destroy(transform.parent.gameObject);
        }
    }

}
