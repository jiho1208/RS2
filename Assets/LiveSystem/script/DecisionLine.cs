using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecisionLine : MonoBehaviour
{
    public GameObject FigureObject;
    private float Perfect;
    private float Great;
    private float Good;
    private float Bad;
    private float zPos;
    private List<Sprite> DecisionImage;
    private Figure figure;
    void Start()
    {
        figure = FigureObject.GetComponent<Figure>();
        Perfect = figure.Perfect;
        Great = figure.Great;
        Good = figure.Good;
        Bad = figure.Bad;
        DecisionImage = figure.DecisionImage;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Note")
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

}
