using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class control : MonoBehaviour
{

    float horizontal;
    float vertical;
    float velocidad = 10.0f;
    float salto = 7.0f;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * velocidad * Time.deltaTime;
        transform.Translate(horizontal, 0f, 0f);

        vertical = Input.GetAxis("Vertical") * salto * Time.deltaTime;
        transform.Translate(0f, vertical, 0f);

        if (Input.GetKey(KeyCode.R))
        {
            transform.position= new Vector3(0, 0, 0);
        }



    }
}
