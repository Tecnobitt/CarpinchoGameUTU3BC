using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jefeScript : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            var CARLOS = collision.GetComponent<control>();
            CARLOS?.Golpe();
        }
    }

}
