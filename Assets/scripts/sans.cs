using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sans : MonoBehaviour
{
    private float tiempo = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.time>tiempo)
        {
            Debug.Log(tiempo);
            tiempo = Time.time + 3;

            transform.position = new Vector3(6.67f, 4.2f, 0f);

            
        }
        void OnCollisionEnter2D(Collision lol)
        {
            if (lol.gameObject.tag == "Respawn")
            {
                Destroy(lol.gameObject);
                Destroy(this.gameObject);
            }
        }



    }
}
