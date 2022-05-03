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
        if (other.gameObject.tag == "BackNote") return;
        switch (other.gameObject.tag)
        {
            case "ShortNote":
                NoteScore = 400;
                break;
            case "LongNote":
                NoteScore = 800;
                break;
            case "HardShortNote":
                NoteScore = 400;
                break;
            case "HardLongNote":
                NoteScore = 800;
                break;
        }

        zPos = Mathf.Abs(other.transform.position.z);
        Decision(zPos);
        if (other.gameObject.tag == "LongNote")
        {
            Vector3 pos = other.gameObject.transform.position;
            other.gameObject.GetComponent<Note>().NoteSpeed = 0;
            other.gameObject.transform.position = new Vector3(pos.x, pos.y, 0);
        }
        other.gameObject.GetComponent<Note>().isdestroy = true;
    }

    protected void Decision(float zpos)
    {

        if (zpos <= Perfect)
        {
            LiveManager.Instance.DNum = 1;
            StartCoroutine(LiveManager.Instance.UIChange(4));
            ScoreBoard.Instance.Score += NoteScore * 2;
        }
        else if (zpos <= Great)
        {
            LiveManager.Instance.DNum = 2;
            StartCoroutine(LiveManager.Instance.UIChange(3));
            ScoreBoard.Instance.Score += NoteScore * 1.5f;
        }
        else if (zpos <= Good)
        {
            LiveManager.Instance.DNum = 3;
            StartCoroutine(LiveManager.Instance.UIChange(2));
            ScoreBoard.Instance.Score += NoteScore * 1;
        }
        else if (zpos <= Bad)
        {
            LiveManager.Instance.DNum = 4;
            StartCoroutine(LiveManager.Instance.UIChange(1));
            ScoreBoard.Instance.HPMinus(1);
            ScoreBoard.Instance.Score += NoteScore * 0.5f;
        }
        else
        {
            LiveManager.Instance.DNum = 5;
            StartCoroutine(LiveManager.Instance.UIChange(0));
            ScoreBoard.Instance.HPMinus(1);
        }
    }
}
