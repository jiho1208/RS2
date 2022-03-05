using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;
    public float FullHP;
    public int MaxScore;
    public Image HPBar;
    public Image ScoreGauge;
    public float Score = 0;
    private float HP = 30;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        HPBar.fillAmount = HP * (1 / FullHP);
        ScoreGauge.fillAmount = (Score * (0.25f / MaxScore)) + 0.5f;
        GameClear();
    }

    public void HPMinus(int num)
    {
        HP -= num;
        if (HP == 0)
        {
            Debug.Log("응 죽어");
        }
    }

    void GameClear()
    {
        if (Score >= MaxScore)
        {
            Debug.Log("어 클리어야");
        }
    }
}
