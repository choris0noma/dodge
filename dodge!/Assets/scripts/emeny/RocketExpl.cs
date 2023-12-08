using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RocketExpl : MonoBehaviour
{
    float timeStart = 7;
    float endTime = 0;

    void FixedUpdate()
    {
        timeStart -= Time.deltaTime;
        
        if (timeStart <= endTime)
        {
            Destroy (gameObject);
        }
    }
}
