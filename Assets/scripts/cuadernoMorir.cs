using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadernoMorir : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D c1)
    {
        if (c1.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Destroy(transform.parent.gameObject);
        }
    }
}
