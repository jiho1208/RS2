using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float MaxTime;
    private float sec = 0;
    private Image timer;
    void Start()
    {
        timer = gameObject.GetComponent<Image>(); 
    }

    void Update()
    {
        sec += Time.deltaTime;
        timer.fillAmount = sec * (1 / MaxTime);
    }
}
