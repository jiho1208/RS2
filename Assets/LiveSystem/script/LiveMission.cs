using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiveMission : MonoBehaviour
{
    WaitForSeconds wait = new WaitForSeconds(0.1f);
    IEnumerator DMission(int tvalue, int max, int success, int fail, int rimit)//���� �̼�
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

    IEnumerator CMission(int tvalue, int success, int fail, int rimit)//�޺� �̼�
    {

        yield return wait;
    }

    IEnumerator HPMission(int tvalue, int success, int fail, int rimit)//HP�̼�
    {

        yield return wait;
    }

    void MissionClear()//�̼� ������
    {

    }

    void MissionFail()//�̼� ���н�
    {

    }
}
