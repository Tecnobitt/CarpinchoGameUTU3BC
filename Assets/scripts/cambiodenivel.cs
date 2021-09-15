using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambiodenivel : MonoBehaviour
{
    // Start is called before the first frame update
   void OnCollisionEnter2D(Collision2D c2)
    {
        if(c2.gameObject.tag == "Player") { 
        SceneManager.LoadScene("nivel1");
        
        }
    }
    
}
