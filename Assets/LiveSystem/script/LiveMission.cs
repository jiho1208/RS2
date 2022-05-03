using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveMission : MonoBehaviour
{
    WaitForSeconds wait = new WaitForSeconds(0.1f);
    IEnumerator DMission(int tvalue, int max, int success, int fail, int rimit)//판정 미션
    {
        int score = 0;
        float STime = Time.time;
        while (score != max)
        {
            if (Mathf.Abs(STime - Time.time) >= rimit) MissionFail();
            if (LiveManager.Instance.DNum == tvalue) score++;
            yield return wait;
        }
        MissionClear();
    }

    IEnumerator CMission(int tvalue, int success, int fail, int rimit)//콤보 미션
    {

        yield return wait;
    }

    IEnumerator HPMission(int tvalue, int success, int fail, int rimit)//HP미션
    {

        yield return wait;
    }

    void MissionClear()//미션 성공시
    {

    }

    void MissionFail()//미션 실패시
    {

    }
}
