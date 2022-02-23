using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLine : MonoBehaviour
{

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            StartCoroutine(LiveManager.Instance.UIChange(0));
        }
    }
}
