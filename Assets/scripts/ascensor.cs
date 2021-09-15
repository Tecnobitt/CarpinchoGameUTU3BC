using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascensor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision c1)
    {
        if(c1.gameObject.tag == "Player")
        {
            transform.Translate(0f, 0.001f, 0f);
        }
    }
}
