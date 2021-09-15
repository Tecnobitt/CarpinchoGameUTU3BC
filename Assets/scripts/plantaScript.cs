using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantaScript : MonoBehaviour
{
    public GameObject estupido;
    public GameObject BalaPrefab;

    private float UltimoBalazo;

    private void Update()
    {
        if (estupido == null) return;
        Vector3 direction = estupido.transform.position - transform.position;
        if (direction.x >= 0.0f) transform.localScale = new Vector3(-5.0f, 5.0f, 1.0f);
        else transform.localScale = new Vector3(5.0f, 5.0f, 1.0f);

        float distance = Mathf.Abs(estupido.transform.position.x - transform.position.x);

        if (distance < 5.0f && Time.time > UltimoBalazo + 0.5f)
        {
            Balazo();
            UltimoBalazo = Time.time;
        }

    }

    private void Balazo()
    {
        Vector3 direction;
        if (transform.localScale.x == 5.0f) direction = Vector3.left;
        else direction = Vector3.right;

        GameObject bala = Instantiate(BalaPrefab, transform.position + direction * 1, Quaternion.identity);
        bala.GetComponent<BalaScript>().SetDirection(direction);
    }
}
