using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionLine : MonoBehaviour
{
    private float zPos;
    public float Perfect = 0.49f;
    public float Great = 0.9f;
    public float Good = 1.19f;
    public float Bad = 1.5f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        zPos = Mathf.Abs(other.transform.position.z);
        if (zPos <= Perfect)
        {
            Debug.Log("Perfect");
        }
        else if (zPos <= Great)
        {
            Debug.Log("Great");
        }
        else if (zPos <= Good)
        {
            Debug.Log("Good");
        }
        else if (zPos <= Bad)
        {
            Debug.Log("Bad");
        }
        else
        {
            Debug.Log("Miss");
        }
        Destroy(other.gameObject);
    }

}
