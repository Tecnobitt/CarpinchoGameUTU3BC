using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sciptCinematica1 : MonoBehaviour
{
    // Update isalled once per frame
    void Update()
    {
        transform.Translate(10f* Time.deltaTime, 0f, 0f);
    }
}
