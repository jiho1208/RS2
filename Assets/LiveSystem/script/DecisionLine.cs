using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecisionLine : MonoBehaviour
{
    public GameObject FigureObject;
    private Figure figure;
    private float Perfect;
    private float Great;
    private float Good;
    private float Bad;
    private float zPos;
    
    void Start()
    {
        figure = FigureObject.GetComponent<Figure>();
        Perfect = figure.Perfect;
        Great = figure.Great;
        Good = figure.Good;
        Bad = figure.Bad;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
        {
            zPos = Mathf.Abs(other.transform.position.z);
            if (zPos <= Perfect)
            {
               Debug.Log("Perfect");
               StartCoroutine(LiveManager.Instance.UIChange(4));
            }
            else if (zPos <= Great)
            {
                Debug.Log("Great");
                StartCoroutine(LiveManager.Instance.UIChange(3));
            }
            else if (zPos <= Good)
            {
                Debug.Log("Good");
                StartCoroutine(LiveManager.Instance.UIChange(2));
            }
            else if (zPos <= Bad)
            {
                Debug.Log("Bad");
                StartCoroutine(LiveManager.Instance.UIChange(1));
            }
            else
            {
                Debug.Log("Miss");
                StartCoroutine(LiveManager.Instance.UIChange(0));
            }
            Destroy(other.gameObject);
        }
    }
}
