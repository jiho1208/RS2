using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveManager : MonoBehaviour
{
    public List<GameObject> Decision;
    public List<Transform> SpawnPoint;
    public GameObject Note;
    public float SpawnDelay;

    void Start()
    {
        StartCoroutine(NoteSpawn());
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
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            Decision[0].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            Decision[1].SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            Decision[1].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            Decision[2].SetActive(true);
        }
        else if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            Decision[2].SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Quote))
        {
            Decision[3].SetActive(true);
        }

        if (Input.GetKeyUp(KeyCode.Quote))
        {
            Decision[3].SetActive(false);
        }

    }

    IEnumerator NoteSpawn()
    {
        WaitForSeconds Wait = new WaitForSeconds(SpawnDelay);
        while (true)
        {
            int RandomSpawn = Random.Range(0, 4);
            Instantiate(Note, SpawnPoint[RandomSpawn]);
            yield return Wait;
        }
    }
}
