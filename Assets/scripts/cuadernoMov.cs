using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cuadernoMov : MonoBehaviour
{
    private Rigidbody2D Rigidbody2D;
    bool mirandoLeft;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * 2 * Time.deltaTime);
    }

    void OnCollisionEnter2D(Collision2D c1)
    {
        if (c1 != null && !c1.collider.CompareTag("Player") && c1.collider.CompareTag("Ground"))
        {
            mirandoLeft = !mirandoLeft;
        }

        if (mirandoLeft)
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(0, 180, 0);
        }
    }

}
