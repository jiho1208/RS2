using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    public static ScoreBoard Instance;
    public int HP;
    private Slider HPSlider;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        HPSlider = GetComponent<Slider>();
    }

    void Update()
    {
        HPSlider.value = HP;
    }

    public void HPMinus(int num)
    {
        HP -= num;
        if (HP == 0)
        {
            Debug.Log("ÀÀ Á×¾î");
        }
    }
}
