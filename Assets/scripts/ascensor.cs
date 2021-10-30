using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ascensor : MonoBehaviour
{
    public GameObject lol;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision c1)
    {
        if(c1.gameObject.tag == "Player")
        {
            lol.transform.position += lol.transform.up * Time.deltaTime;
        }
    }
}
