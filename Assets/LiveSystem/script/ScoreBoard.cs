using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;
    public int HP;
    public int MaxScore;
    public Slider HPSlider;
    public Image ScoreGauge;
    public float Score = 0;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    void Update()
    {
        HPSlider.value = HP;
        ScoreGauge.fillAmount = (Score * (0.25f / MaxScore)) + 0.5f;
        GameClear();
    }

    public void HPMinus(int num)
    {
        HP -= num;
        if (HP == 0)
        {
            Debug.Log("�� �׾�");
        }
    }

    void GameClear()
    {
        if (Score >= MaxScore)
        {
            Debug.Log("�� Ŭ�����");
        }
    }
}
