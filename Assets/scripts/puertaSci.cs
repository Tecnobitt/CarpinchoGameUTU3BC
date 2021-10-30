using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puertaSci : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var CARLOS = collision.GetComponent<control>();
            CARLOS?.tp();
        }
    }
}
