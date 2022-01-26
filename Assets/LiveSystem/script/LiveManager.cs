using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    public List<GameObject> Decision;
    private float Wait = 0.1f;

    void Start()
    {
        
    }

    void Update()
    {
        PressKeyboard();
    }

    void PressKeyboard()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Decision[0].SetActive(true);
            StartCoroutine(DecisionOff(Decision[0]));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Decision[1].SetActive(true);
            StartCoroutine(DecisionOff(Decision[1]));
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            Decision[2].SetActive(true);
            StartCoroutine(DecisionOff(Decision[2]));
        }

        if (Input.GetKeyDown(KeyCode.Quote))
        {
            Decision[3].SetActive(true);
            StartCoroutine(DecisionOff(Decision[3]));
        }

    }

    IEnumerator DecisionOff(GameObject OffObject)
    {
        yield return new WaitForSeconds(Wait);
        OffObject.SetActive(false);
    }
}
