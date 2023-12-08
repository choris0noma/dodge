using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour
{
    public float timeStart = 5;
    public float endTime = 0;
    public Text timerText;
    public GameObject explosionAnimation;

    void Start()
    {
        timerText.text = timeStart.ToString();
    }

    void FixedUpdate()
    {
        timeStart -= Time.deltaTime;
        timerText.text = Mathf.Round(timeStart).ToString();

        if (timeStart <= endTime)
        {
            Instantiate(explosionAnimation, transform.position, Quaternion.identity);

            Destroy (gameObject);
        }
    }
}
