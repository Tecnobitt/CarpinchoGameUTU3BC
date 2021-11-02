using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTexto : MonoBehaviour
{
    public GameObject PanelTexto;
    void OnCollisionEnter2D(Collision2D c1)
    {
        if (c1.gameObject.tag == "Player")
        {
            PanelTexto.SetActive(true);
        }
    }
}
