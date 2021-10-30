using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plantaScript : MonoBehaviour
{
    public GameObject carlitos;
    public GameObject BalaPrefab;
    private float UltimoBalazo;

    private void Update()
    {
        if (carlitos == null) return;
        var direction = carlitos.transform.position - transform.position;
        transform.localScale = new Vector3(direction.x >= 0.0f ? - 5.0f : 5.0f, 5.0f, 1.0f);
        var distance = Mathf.Abs(carlitos.transform.position.x - transform.position.x);
        if (distance < 5.0f && Time.time > UltimoBalazo + 0.5f)
        {
            Balazo();
            UltimoBalazo = Time.time;
        }
    }

    private void Balazo()
    {
        var direction = transform.localScale.x == 5.0f ? Vector3.left : Vector3.right;
        var bala = Instantiate(BalaPrefab, transform.position + direction * 1, Quaternion.identity);
        bala.GetComponent<BalaScript>().SetDirection(direction);
    }
}
