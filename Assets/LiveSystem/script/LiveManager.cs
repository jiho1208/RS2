using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveManager : MonoBehaviour
{
    public static LiveManager Instance;
    public GameObject FigureObject;
    public List<GameObject> Decision;
    public List<GameObject> Decision2;
    public List<Transform> SpawnPoint;
    public GameObject Note;
    public float SpawnDelay;
    [SerializeField]
    private List<SpriteRenderer> NoteRail;
    [SerializeField]
    private List<Sprite> NoteRailImage;
    private List<Sprite> DecisionImage;
    private Image DecisionUI;
    private Figure figure;

    void Start()
    {
        figure = FigureObject.GetComponent<Figure>();
        if (Instance == null)
        {
            Instance = this;
        }
        StartCoroutine(NoteSpawn());
        DecisionImage = figure.DecisionImage;
        DecisionUI = figure.DecisionUI;
        figure = FigureObject.GetComponent<Figure>();
    }

    void Update()
    {
        PressKeyboard();
    }

    void PressKeyboard()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            LineOn(0, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            LineOn(0, false, 0);
            StartCoroutine(LongOn(0));
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            LineOn(1, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            LineOn(1, false, 0);
            StartCoroutine(LongOn(1));
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            LineOn(2, true, 1);
        }
        else if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            LineOn(2, false, 0);
            StartCoroutine(LongOn(2));
        }

        if (Input.GetKeyDown(KeyCode.Quote))
        {
            LineOn(3, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.Quote))
        {
            LineOn(3, false, 0);
            StartCoroutine(LongOn(3));
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

    public IEnumerator UIChange(int num)
    {
        DecisionUI.sprite = DecisionImage[num];
        DecisionUI.GetComponent<Image>().color = new Color(1, 1, 1, 1);
        WaitForSeconds wait = new WaitForSeconds(0.01f);
        yield return new WaitForSeconds(0.1f);
        while (DecisionUI.GetComponent<Image>().color.a >= 0)
        {
            DecisionUI.GetComponent<Image>().color -= new Color(0, 0, 0, 0.1f);
            yield return wait;
        }
    }

    void LineOn(int num, bool ison, int on)
    {
        Decision[num].GetComponent<BoxCollider>().enabled = ison;
        NoteRail[num].sprite = NoteRailImage[on];
    }

    IEnumerator LongOn(int num)
    {
        Decision2[num].GetComponent<BoxCollider>().enabled = true;
        yield return new WaitForSeconds(0.1f);
        Decision2[num].GetComponent<BoxCollider>().enabled = false;
    }
}
