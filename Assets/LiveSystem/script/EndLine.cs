using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndLine : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(LiveManager.Instance.UIChange(0));
        ScoreBoard.Instance.HPMinus(1);
        Destroy(other.gameObject);
    }
}
