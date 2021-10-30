using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class contador : MonoBehaviour
{
    float tiempoinicio;
    public Text tiempoInicioTexto;

    // Start is called before the first frame update
    void Start()
    {
        tiempoinicio = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoinicio = tiempoinicio + Time.deltaTime;
        TimeSpan time = TimeSpan.FromSeconds(tiempoinicio);
        tiempoInicioTexto.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

}
