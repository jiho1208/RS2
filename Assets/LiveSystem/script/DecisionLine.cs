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

    private int NoteScore = 0;

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
        switch (other.gameObject.tag)
        {
            case "ShotNote":
                NoteScore = 400;
                break;
            case "LoogNote":
                NoteScore = 800;
                break;
            case "HardShotNote":
                NoteScore = 400;
                break;
            case "HardLoogNote":
                NoteScore = 800;
                break;
        }

        zPos = Mathf.Abs(other.transform.position.z);
        if (zPos <= Perfect)
        {
            Debug.Log("Perfect");
            StartCoroutine(LiveManager.Instance.UIChange(4));
            ScoreBoard.Instance.Score += NoteScore * 2;
        }
        else if (zPos <= Great)
        {
            Debug.Log("Great");
            StartCoroutine(LiveManager.Instance.UIChange(3));
            ScoreBoard.Instance.Score += NoteScore * 1.5f;
        }
        else if (zPos <= Good)
        {
            Debug.Log("Good");
            StartCoroutine(LiveManager.Instance.UIChange(2));
            ScoreBoard.Instance.Score += NoteScore * 1;
        }
        else if (zPos <= Bad)
        {
            Debug.Log("Bad");
            StartCoroutine(LiveManager.Instance.UIChange(1));
            ScoreBoard.Instance.HPMinus(1);
            ScoreBoard.Instance.Score += NoteScore * 0.5f;
        }
        else
        {
            Debug.Log("Miss");
            StartCoroutine(LiveManager.Instance.UIChange(0));
            ScoreBoard.Instance.HPMinus(1);
        }
        Destroy(other.gameObject);
    }
}
