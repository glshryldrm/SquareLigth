using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public float waitTime = 2f;
    private float stopTime = 0f;

    
    void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            stopTime += Time.deltaTime;
            ChangeColor(color1);

            if (stopTime >= waitTime)
            {
                ChangeColor(color2);
            }
            
        }
        else
        {
            stopTime = 0f;
        }
    }
    
    private void ChangeColor(Color color)
    {
        GetComponent<Renderer>().material.color = color;
    }
}
