using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class textovidas : MonoBehaviour
{

    [SerializeField] Text vida;
    control stats;
    // Start is called before the first frame update
    void Start()
    {
        stats = GetComponent<control>();
    }

    // Update is called once per frame
    void Update()
    {
        vida.text = control.vida.ToString();
    }
}
