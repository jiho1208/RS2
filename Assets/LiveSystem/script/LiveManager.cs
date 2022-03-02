using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveManager : MonoBehaviour
{
    public static LiveManager Instance;
    public GameObject FigureObject;
    public List<GameObject> Decision;
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
            asdf(0, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.A))
        {
            asdf(0, false, 0);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            asdf(1, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.S))
        {
            asdf(1, false, 0);
        }

        if (Input.GetKeyDown(KeyCode.Semicolon))
        {
            asdf(2, true, 1);
        }
        else if (Input.GetKeyUp(KeyCode.Semicolon))
        {
            asdf(2, false, 0);
        }

        if (Input.GetKeyDown(KeyCode.Quote))
        {
            asdf(3, true, 1);
        }

        else if (Input.GetKeyUp(KeyCode.Quote))
        {
            asdf(3, false, 0);
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

    void asdf(int num, bool ison, int on)
    {
        Decision[num].GetComponent<BoxCollider>().enabled = ison;
        NoteRail[num].sprite = NoteRailImage[on];
    }
}
